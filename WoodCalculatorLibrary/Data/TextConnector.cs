using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WoodCalculatorLibrary.Models;

namespace WoodCalculatorLibrary.Data
{
    public class TextConnector : IDataConnection
    {
        public void DeleteEssence(EssenceModel essence)
        {
            List<EssenceModel> essences = GlobalConfig.EssenceFile.FullFilePath().LoadFile().ConvertToEssenceModel();

            EssenceModel essenceToRemove = essences.Where(x => x.Id == essence.Id).FirstOrDefault();
            essences.Remove(essenceToRemove);

            essences.SaveToEssenceFile();
        }

        public void DeleteProject(ProjectModel project)
        {
            List<ProjectModel> projects = GlobalConfig.ProjectFile.FullFilePath().LoadFile().ConvertToProjectModel();

            ProjectModel projectToRemove = projects.Where(x => x.Id == project.Id).FirstOrDefault();
            projects.Remove(projectToRemove);

            DeleteWoods(project.Woods);

            projects.SaveToProjectFile();
        }

        private void DeleteWoods(List<WoodModel> woods)
        {
            List<WoodModel> savedWoods = GlobalConfig.WoodFile.FullFilePath().LoadFile().ConvertToWoodModel();

            foreach (WoodModel wood in woods)
            {
                WoodModel woodToRemove = savedWoods.Where(x => x.Id == wood.Id).FirstOrDefault();
                savedWoods.Remove(woodToRemove);
            }

            savedWoods.SaveToWoodFile();
        }

        public List<EssenceModel> GetEssenceAll()
        {
            return GlobalConfig.EssenceFile.FullFilePath().LoadFile().ConvertToEssenceModel();
        }

        public List<ProjectModel> GetProjectAll()
        {
            return GlobalConfig.ProjectFile.FullFilePath().LoadFile().ConvertToProjectModel();
        }

        public List<WoodModel> GetWoodAll()
        {
            return GlobalConfig.WoodFile.FullFilePath().LoadFile().ConvertToWoodModel();
        }

        public void SaveEssence(EssenceModel essence)
        {
            List<EssenceModel> essences = GlobalConfig.EssenceFile.FullFilePath().LoadFile().ConvertToEssenceModel();

            // Find the max ID
            int currId = 1;
            if (essences.Count > 0)
            {
                currId = essences.OrderByDescending(x => x.Id).First().Id + 1;
            }

            essence.Id = currId;
            essences.Add(essence);

            essences.SaveToEssenceFile();
        }

        public void SaveProject(ProjectModel project)
        {
            SaveWood(project.Woods);

            List<ProjectModel> projects = GlobalConfig.ProjectFile.FullFilePath().LoadFile().ConvertToProjectModel();

            if (projects.Where(x => x.Name == project.Name).FirstOrDefault() != null)
            {
                project.Name += "(1)";
            }

            if (project.Id == 0)
            {
                // Find max ID
                int currId = 1;
                if (projects.Count > 0)
                {
                    currId = projects.OrderByDescending(x => x.Id).First().Id + 1;
                }

                project.Id = currId; 
            }
            else
            {
                projects.Remove(projects.Find(x => x.Id == project.Id));
            }

            projects.Add(project);

            projects.SaveToProjectFile();
        }

        private void SaveWood(List<WoodModel> woods)
        {
            List<WoodModel> savedWoods = GlobalConfig.WoodFile.FullFilePath().LoadFile().ConvertToWoodModel();

            // Find max Id
            int currId = 1;
            if (savedWoods.Count > 0)
            {
                currId = savedWoods.OrderByDescending(x => x.Id).First().Id + 1;
            }

            foreach (WoodModel wood in woods)
            {
                if (wood.Id == 0)
                {
                    wood.Id = currId;
                    currId++;
                }
                else
                {
                    savedWoods.Remove(savedWoods.Find(x => x.Id == wood.Id));
                }
                
                savedWoods.Add(wood);
            }

            savedWoods.SaveToWoodFile();
        }
    }
}

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
            throw new NotImplementedException();
        }

        public List<EssenceModel> GetEssenceAll()
        {
            return GlobalConfig.EssenceFile.FullFilePath().LoadFile().ConvertToEssenceModel();
        }

        public List<ProjectModel> GetProjectAll()
        {
            throw new NotImplementedException();
        }

        public List<WoodModel> GetWoodAll()
        {
            throw new NotImplementedException();
        }

        public void SaveEssence(EssenceModel essence)
        {
            List<EssenceModel> essences = GlobalConfig.EssenceFile.FullFilePath().LoadFile().ConvertToEssenceModel();

            // Find the max ID
            int currId = 1;
            if (essences.Count > 0)
            {
                currId = essences.OrderByDescending(x => x.Id).First().Id;
            }

            essence.Id = currId;
            essences.Add(essence);

            essences.SaveToEssenceFile();
        }

        public void SaveProject(ProjectModel project)
        {
            throw new NotImplementedException();
        }

        public void SaveWood(WoodModel wood)
        {
            throw new NotImplementedException();
        }
    }
}

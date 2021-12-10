using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WoodCalculatorLibrary.Models;

namespace WoodCalculatorLibrary.Data
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string file)
        {
            return Directory.GetCurrentDirectory() + "\\" + file;
        }

        public static List<string> LoadFile(this string file)
        {
            List<string> lines = new List<string>();

            if (File.Exists(file))
                lines = File.ReadAllLines(file).ToList();

            return lines;
        }

        public static List<WoodModel> ConvertToWoodModel(this List<string> lines)
        {
            List<WoodModel> output = new List<WoodModel>();
            WoodModel currWood;

            //id,NomMeuble,NomPiece,Essence,Longueur,Largeur,Epaisseur,NbPiece
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                currWood = new WoodModel();
                currWood.Id = int.Parse(cols[0]);
                currWood.NomMeuble = cols[1];
                currWood.NomPiece = cols[2];
                currWood.Essence = cols[3];
                currWood.Longueur = decimal.Parse(cols[4]);
                currWood.Largeur = decimal.Parse(cols[5]);
                currWood.Epaisseur = decimal.Parse(cols[6]);
                currWood.NbPieces = int.Parse(cols[7]);

                output.Add(currWood);
            }

            return output;
        }

        public static List<EssenceModel> ConvertToEssenceModel(this List<string> lines)
        {
            List<EssenceModel> output = new List<EssenceModel>();
            EssenceModel currEssence;

            // id,name
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                currEssence = new EssenceModel();
                currEssence.Id = int.Parse(cols[0]);
                currEssence.Name = cols[1];

                output.Add(currEssence);
            }

            return output;
        }

        public static List<ProjectModel> ConvertToProjectModel(this List<string> lines)
        {
            List<ProjectModel> output = new List<ProjectModel>();
            ProjectModel currProject;

            List<WoodModel> woods = GlobalConfig.WoodFile.FullFilePath().LoadFile().ConvertToWoodModel();

            //id,name,wood|wood...
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                currProject = new ProjectModel();
                currProject.Id = int.Parse(cols[0]);
                currProject.Name = cols[1];

                string[] woodIds = cols[2].Split('|');
                foreach (string woodId in woodIds)
                {
                    currProject.Woods.Add(woods.Find(x => x.Id == int.Parse(woodId)));
                }

                output.Add(currProject);
            }

            return output;
        }

        public static void SaveToProjectFile(this List<ProjectModel> projects)
        {
            List<string> lines = new List<string>();

            //id,name,wood|wood...
            foreach (ProjectModel project in projects)
            {
                lines.Add($"{project.Id},{project.Name},{ConvertListWoodToString(project.Woods)}");
            }

            File.WriteAllLines(GlobalConfig.ProjectFile.FullFilePath(), lines);
        }

        private static string ConvertListWoodToString(List<WoodModel> woods)
        {
            string output = "";

            foreach(WoodModel wood in woods)
            {
                output += $"{wood.Id}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        public static void SaveToWoodFile(this List<WoodModel> woods)
        {
            List<string> lines = new List<string>();

            //id,NomMeuble,NomPiece,Essence,Longueur,Largeur,Epaisseur,NbPiece
            foreach (WoodModel wood in woods)
            {
                lines.Add($"{wood.Id},{wood.NomMeuble},{wood.NomPiece},{wood.Essence},{wood.Longueur}," +
                    $"{wood.Largeur},{wood.Epaisseur},{wood.NbPieces}");
            }

            File.WriteAllLines(GlobalConfig.WoodFile.FullFilePath(), lines);
        }

        public static void SaveToEssenceFile(this List<EssenceModel> essences)
        {
            List<string> lines = new List<string>();

            // id,name
            foreach (EssenceModel essence in essences)
            {
                lines.Add($"{essence.Id},{essence.Name}");
            }

            File.WriteAllLines(GlobalConfig.EssenceFile.FullFilePath(), lines);
        }
    }
}

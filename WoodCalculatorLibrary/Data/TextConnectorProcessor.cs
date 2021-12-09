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

        public static void SaveToEssenceFile(this List<EssenceModel> essences)
        {
            List<string> lines = new List<string>();

            foreach (EssenceModel essence in essences)
            {
                string line = $"{essence.Id},{essence.Name}";
                lines.Add(line);
            }

            File.WriteAllLines(GlobalConfig.EssenceFile.FullFilePath(), lines);
        }
    }
}

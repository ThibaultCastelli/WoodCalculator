using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WoodCalculatorLibrary.Data;

namespace WoodCalculatorLibrary
{
    public static class GlobalConfig
    {
        public const string DataDirectory = "//WoodCalculator_Saves//Data//";
        public const string ScreenShotsDirectory = "//WoodCalculator_Saves//ScreenShots//";
        public const string ProjectFile = "Projects.csv";
        public const string WoodFile = "Woods.csv";
        public const string EssenceFile = "Essences.csv";

        public static IDataConnection connection;

        public static void InitializeConnection(ConnectionType connectionType)
        {
            switch (connectionType)
            {
                case ConnectionType.Text:
                    connection = new TextConnector();
                    break;
            }
        }

        public static void CreateDataDirectory()
        {
            if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}{GlobalConfig.DataDirectory}"))
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}{GlobalConfig.DataDirectory}");
            }

            if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}{GlobalConfig.ScreenShotsDirectory}"))
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}{GlobalConfig.ScreenShotsDirectory}");
            }
        }
    }
}

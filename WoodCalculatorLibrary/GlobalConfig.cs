using System;
using System.Collections.Generic;
using System.Text;
using WoodCalculatorLibrary.Data;

namespace WoodCalculatorLibrary
{
    public static class GlobalConfig
    {
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
    }
}

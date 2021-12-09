using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WoodCalculatorLibrary.Data
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string file)
        {
            return Directory.GetCurrentDirectory() + "\\" + file;
        }
    }
}

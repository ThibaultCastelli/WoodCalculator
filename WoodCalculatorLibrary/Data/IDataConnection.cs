using System;
using System.Collections.Generic;
using System.Text;
using WoodCalculatorLibrary.Models;

namespace WoodCalculatorLibrary.Data
{
    public interface IDataConnection
    {
        void SaveEssence(EssenceModel model);
        void DeleteEssence(EssenceModel model);
        List<EssenceModel> GetEssenceAll();

        void SaveWood(WoodModel model);
        List<WoodModel> GetWoodAll();

        void SaveProject(ProjectModel model);
        void DeleteProject(ProjectModel model);
        List<ProjectModel> GetProjectAll();
    }
}

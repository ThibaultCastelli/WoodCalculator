using System;
using System.Collections.Generic;
using System.Text;
using WoodCalculatorLibrary.Models;

namespace WoodCalculatorLibrary.Data
{
    public interface IDataConnection
    {
        void SaveEssence(EssenceModel essence);
        void DeleteEssence(EssenceModel essence);
        List<EssenceModel> GetEssenceAll();

        void SaveWood(WoodModel wood);
        List<WoodModel> GetWoodAll();

        void SaveProject(ProjectModel project);
        void DeleteProject(ProjectModel project);
        List<ProjectModel> GetProjectAll();
    }
}

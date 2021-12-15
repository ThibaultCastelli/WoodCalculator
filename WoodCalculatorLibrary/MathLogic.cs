using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WoodCalculatorLibrary.Models;

namespace WoodCalculatorLibrary
{
    public static class MathLogic
    {
        public static List<EssenceVolumeModel> Add30Percent(this List<EssenceVolumeModel> volumes)
        {
            List<EssenceVolumeModel> output = new List<EssenceVolumeModel>();
            EssenceVolumeModel currVolume;

            foreach (EssenceVolumeModel volume in volumes)
            {
                currVolume = new EssenceVolumeModel();
                currVolume.Essence = volume.Essence;
                currVolume.Volume = decimal.Multiply(volume.Volume, Convert.ToDecimal(1.30));
                currVolume.Volume = decimal.Round(currVolume.Volume, 4);

                output.Add(currVolume);
            }

            return output;
        }

        public static List<EssenceVolumeModel> CalculateVolume(this List<WoodModel> woods)
        {
            List<EssenceVolumeModel> output = new List<EssenceVolumeModel>();
            List<List<WoodModel>> sortedWoods = new List<List<WoodModel>>();

            if (woods.Count == 0)
                return output;

            sortedWoods = OrderWoodsByEssence(woods);

            output = SetVolumes(sortedWoods);

            return output;
        }

        private static List<EssenceVolumeModel> SetVolumes(List<List<WoodModel>> sortedWoods)
        {
            List<EssenceVolumeModel> output = new List<EssenceVolumeModel>();

            foreach (List<WoodModel> woodsList in sortedWoods)
            {
                EssenceVolumeModel currVolume = new EssenceVolumeModel();
                currVolume.Essence = woodsList[0].Essence;
                currVolume.Volume = 0;

                foreach (WoodModel wood in woodsList)
                {
                    currVolume.Volume = decimal.Add(currVolume.Volume, wood.GetVolume());
                }

                currVolume.Volume = decimal.Round(currVolume.Volume, 4);
                output.Add(currVolume);
            }

            return output;
        }

        private static decimal GetVolume(this WoodModel wood)
        {
            decimal output;

            decimal longueur = decimal.Divide(wood.Longueur, 1000);
            decimal largeur = decimal.Divide(wood.Largeur, 1000);
            decimal epaisseur = decimal.Divide(wood.Epaisseur, 1000);

            decimal m2 = decimal.Multiply(longueur, largeur);
            decimal m3 = decimal.Multiply(m2, epaisseur);
            output = decimal.Multiply(m3, wood.NbPieces);

            return output;
        }

        private static List<List<WoodModel>> OrderWoodsByEssence(List<WoodModel> woods)
        {
            List<List<WoodModel>> output = new List<List<WoodModel>>();

            woods = woods.OrderBy(x => x.Essence).ToList();

            string currEssence = "";
            string prevEssence = "";
            List<WoodModel> currList = new List<WoodModel>();

            foreach (WoodModel wood in woods)
            {
                if (wood.Essence == null)
                    continue;

                currEssence = wood.Essence;

                if (currEssence != prevEssence)
                {
                    currList = new List<WoodModel>();
                    currList.Add(wood);
                    output.Add(currList);
                }
                else
                {
                    currList.Add(wood);
                }

                prevEssence = currEssence;
            }

            return output;
        }
    }
}

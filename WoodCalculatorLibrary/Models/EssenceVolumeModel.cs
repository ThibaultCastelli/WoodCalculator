using System;
using System.Collections.Generic;
using System.Text;

namespace WoodCalculatorLibrary.Models
{
    /// <summary>
    /// Représente le volume de bois à commander selon l'essence.
    /// </summary>
    public class EssenceVolumeModel
    {
        /// <summary>
        /// L'essence du bois.
        /// </summary>
        public string Essence { get; set; }

        /// <summary>
        /// Le volume total pour cette essence de bois.
        /// </summary>
        public decimal Volume { get; set; }
    }
}

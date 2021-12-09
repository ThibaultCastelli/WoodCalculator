using System;
using System.Collections.Generic;
using System.Text;

namespace WoodCalculatorLibrary.Models
{
    /// <summary>
    /// Représente une essence de bois.
    /// </summary>
    public class EssenceModel
    {
        /// <summary>
        /// L'identifiant unique de cette essence.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Le nom de cette essence.
        /// </summary>
        public string Name { get; set; }
    }
}

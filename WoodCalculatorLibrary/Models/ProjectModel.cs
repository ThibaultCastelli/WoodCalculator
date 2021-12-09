using System;
using System.Collections.Generic;
using System.Text;

namespace WoodCalculatorLibrary.Models
{
    /// <summary>
    /// Représente un projet de calcul de volume.
    /// </summary>
    public class ProjectModel
    {
        /// <summary>
        /// L'identifiant unique de ce projet.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Le nom du projet.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Les différents bois qui compose le projet.
        /// </summary>
        public List<WoodModel> Woods { get; set; } = new List<WoodModel>();
    }
}

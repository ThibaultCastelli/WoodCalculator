using System;
using System.Collections.Generic;
using System.Text;

namespace WoodCalculatorLibrary.Models
{
    /// <summary>
    /// Représente une planche de bois.
    /// </summary>
    public class WoodModel
    {
        /// <summary>
        /// L'identifiant unique de ce bois.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Le nom du meuble qui contiendra ce bois.
        /// </summary>
        public string NomMeuble { get; set; }

        /// <summary>
        /// Le nom de la pièce de bois.
        /// </summary>
        public string NomPiece { get; set; }

        /// <summary>
        /// L'essence du ce bois.
        /// </summary>
        public string Essence { get; set; }

        /// <summary>
        /// La longueur du bois (en mm).
        /// </summary>
        public decimal Longueur { get; set; }

        /// <summary>
        /// La largeur du bois (en mm).
        /// </summary>
        public decimal Largeur { get; set; }

        /// <summary>
        /// L'épaisseur du bois (en mm).
        /// </summary>
        public decimal Epaisseur { get; set; }

        /// <summary>
        /// Le nombre de pièces identiques de ce bois.
        /// </summary>
        public int NbPieces { get; set; }
    }
}

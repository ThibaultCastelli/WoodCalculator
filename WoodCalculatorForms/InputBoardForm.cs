using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WoodCalculatorLibrary;
using WoodCalculatorLibrary.Models;

namespace WoodCalculatorForms
{
    public partial class InputBoardForm : Form
    {
        List<WoodModel> woods = new List<WoodModel>();
        List<EssenceModel> essences = new List<EssenceModel>();

        public InputBoardForm(List<WoodModel> woods)
        {
            InitializeComponent();

            this.woods = woods;
            essences = GlobalConfig.connection.GetEssenceAll();
        }



        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void RemoveRowBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void InputBoardForm_Load(object sender, EventArgs e)
        {
            //EssenceModel etre = new EssenceModel("Être");
            //EssenceModel boulo = new EssenceModel("Boulot");
            //essences.Add(etre);
            //essences.Add(boulo);

            //WoodModel model = new WoodModel();
            //model.NomMeuble = "Meuble1";
            //model.NomPiece = "Pièce1";
            //model.Essence = null;
            //model.Longueur = 12;
            //model.Largeur = 13;
            //model.Epaisseur = 19;
            //model.NbPieces = 2;

            //woods.Add(model);

            //model = new WoodModel();
            //model.NomMeuble = "Meuble2";
            //model.NomPiece = "Pièce2";
            //model.Essence = null;
            //model.Longueur = 14;
            //model.Largeur = 15;
            //model.Epaisseur = 16;
            //model.NbPieces = 5;

            //woods.Add(model);

            
            EssenceComboBox.DataSource = essences;
            EssenceComboBox.DisplayMember = "Name";
            EssenceComboBox.ValueMember = "Name";
            WoodDataGridView.DataSource = woods;
        }
    }
}

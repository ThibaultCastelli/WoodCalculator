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
    public partial class EssenceEditForm : Form
    {
        List<EssenceModel> essences = new List<EssenceModel>();

        public EssenceEditForm()
        {
            InitializeComponent();

            essences = GlobalConfig.connection.GetEssenceAll();
            PopulateListBox();
        }

        void PopulateListBox()
        {
            EssencesListBox.DataSource = null;
            EssencesListBox.DataSource = essences;
            EssencesListBox.DisplayMember = "Name";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEssence();
        }

        private void AddEssence()
        {
            if (EssenceNameTxtBox.Text.Length == 0)
            {
                MessageBox.Show("Il faut donner un nom à l'essence avant de l'ajouter.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (essences.Find(x => x.Name.ToLower() == EssenceNameTxtBox.Text.ToLower()) != null)
            {
                MessageBox.Show("Cette essence existe déjà dans la base de donnée.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EssenceModel newEssence = new EssenceModel(EssenceNameTxtBox.Text);
            essences.Add(newEssence);
            PopulateListBox();

            GlobalConfig.connection.SaveEssence(newEssence);

            EssenceNameTxtBox.Text = "";
        }

        private void DeleteEssenceBtn_Click(object sender, EventArgs e)
        {
            if (EssencesListBox.SelectedItem == null)
                return;

            EssenceModel essenceToDelete = (EssenceModel)EssencesListBox.SelectedItem;
            essences.Remove(essenceToDelete);
            PopulateListBox();

            GlobalConfig.connection.DeleteEssence(essenceToDelete);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EssenceNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddEssence();
            }
        }
    }
}

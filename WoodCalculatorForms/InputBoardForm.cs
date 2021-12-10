using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WoodCalculatorLibrary;
using WoodCalculatorLibrary.Models;

namespace WoodCalculatorForms
{
    public partial class InputBoardForm : Form
    {
        public Action OnCloseForm;

        List<WoodModel> woods = new List<WoodModel>();
        List<WoodModel> emptyWoods = new List<WoodModel>();

        List<EssenceModel> essences = new List<EssenceModel>();

        ProjectModel project;

        bool hasSaved = false;

        public InputBoardForm(ProjectModel project)
        {
            InitializeComponent();

            this.project = project;

            woods = project.Woods;
            essences = GlobalConfig.connection.GetEssenceAll();

            SetDataGridView();

            if (project.Name != null)
            {
                ProjectNameTxtBox.Text = project.Name;
            }
        }

        private void SetDataGridView()
        {
            EssenceComboBox.DataSource = essences;
            EssenceComboBox.DisplayMember = "Name";
            EssenceComboBox.ValueMember = "Name";

            WoodDataGridView.DataSource = emptyWoods;
            WoodDataGridView.DataSource = woods;
        }

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            woods.Add(new WoodModel());

            SetDataGridView();
        }

        private void RemoveRowBtn_Click(object sender, EventArgs e)
        {
            if (WoodDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Il n'y a pas de ligne à supprimer.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var validDelete = MessageBox.Show("Êtes vous sûr de vouloir supprimer cette ligne ?", "Confirmez la suppression.", MessageBoxButtons.YesNo);

            if (validDelete == DialogResult.Yes)
            {
                woods.RemoveAt(WoodDataGridView.CurrentCell.RowIndex);
                SetDataGridView();
            }
        }

        private void WoodDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            switch (e.ColumnIndex)
            {
                case 1:
                    woods[e.RowIndex].NomMeuble = WoodDataGridView.SelectedCells[0].Value.ToString();
                    break;
                case 2:
                    woods[e.RowIndex].NomPiece = WoodDataGridView.SelectedCells[0].Value.ToString();
                    break;
                case 3:
                    woods[e.RowIndex].Essence = WoodDataGridView.SelectedCells[0].Value.ToString();
                    break;
                case 4:
                    woods[e.RowIndex].Longueur = (decimal)WoodDataGridView.SelectedCells[0].Value;
                    break;
                case 5:
                    woods[e.RowIndex].Largeur = (decimal)WoodDataGridView.SelectedCells[0].Value;
                    break;
                case 6:
                    woods[e.RowIndex].Epaisseur = (decimal)WoodDataGridView.SelectedCells[0].Value;
                    break;
                case 7:
                    woods[e.RowIndex].NbPieces = (int)WoodDataGridView.SelectedCells[0].Value;
                    break;
            }
        }

        private void WoodDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex > 3 && e.ColumnIndex < 7)
            {
                decimal newDecimal;
                if (!decimal.TryParse(e.FormattedValue.ToString(), out newDecimal) || newDecimal < 0)
                {
                    e.Cancel = true;
                    WoodDataGridView.Rows[e.RowIndex].ErrorText = "La valeur doit être un nombre positif.";
                }
            }
            else if (e.ColumnIndex == 7)
            {
                int newInt;
                if (!int.TryParse(e.FormattedValue.ToString(), out newInt) || newInt < 0)
                {
                    e.Cancel = true;
                    WoodDataGridView.Rows[e.RowIndex].ErrorText = "La valeur doit être un nombre positif.";
                }
            }
        }

        private void SaveExitBtn_Click(object sender, EventArgs e)
        {
            if (project.Name == null)
            {
                MessageBox.Show("Il faut donner un nom au projet pour le sauvegarder.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveProject();
            hasSaved = true;

            this.Close();
        }

        private void SaveProject()
        {
            if (project.Name == null)
            {
                project.Name = "Untitled";
            }

            project.Woods = woods;
            GlobalConfig.connection.SaveProject(project);
        }

        private void InputBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!hasSaved)
            {
                var validSave = MessageBox.Show("Voulez-vous sauvegarder avant de quitter ?", "Sauvegarder ?", MessageBoxButtons.YesNo);
                
                if (validSave == DialogResult.Yes)
                {
                    SaveProject();
                }
            }

            OnCloseForm?.Invoke();
        }

        private void EssenceNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            project.Name = ProjectNameTxtBox.Text;
        }

        private void EraseProjectBtn_Click(object sender, EventArgs e)
        {
            var validDelete = MessageBox.Show("Voulez-vous vraiment supprimer ce projet ?", "Supprimer ?", MessageBoxButtons.YesNo);

            if (validDelete == DialogResult.Yes)
            {
                GlobalConfig.connection.DeleteProject(project);
                hasSaved = true;
                this.Close();
            }
        }

        private void CalculBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

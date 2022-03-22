using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        List<EssenceVolumeModel> volumes = new List<EssenceVolumeModel>();
        List<EssenceVolumeModel> volumes30Percent = new List<EssenceVolumeModel>();
        List<EssenceVolumeModel> emptyVolumes = new List<EssenceVolumeModel>();

        ProjectModel project;

        bool hasSaved;
        bool hasChangedValues;

        public InputBoardForm(ProjectModel project)
        {
            InitializeComponent();

            this.project = project;

            woods = project.Woods;
            essences = GlobalConfig.connection.GetEssenceAll();

            SetInputDataGridView();
            SetResultsDataGridView();

            if (project.Name != null)
            {
                ProjectNameTxtBox.Text = project.Name;
            }

            hasSaved = false;
            hasChangedValues = false;
        }

        private void SetInputDataGridView()
        {
            EssenceComboBox.DataSource = essences;
            EssenceComboBox.DisplayMember = "Name";
            EssenceComboBox.ValueMember = "Name";

            WoodDataGridView.DataSource = emptyWoods;
            WoodDataGridView.DataSource = woods;
        }

        private void SetResultsDataGridView()
        {
            volumes = woods.CalculateVolume();
            volumes30Percent = volumes.Add30Percent();

            ResultsDataGridView.DataSource = emptyVolumes;
            ResultsDataGridView.DataSource = volumes;

            Results30PercentDataGridView.DataSource = emptyVolumes;
            Results30PercentDataGridView.DataSource = volumes30Percent;
        }

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            woods.Add(new WoodModel());

            SetInputDataGridView();
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

                SetInputDataGridView();
                SetResultsDataGridView();

                hasChangedValues = true;
            }
        }

        private void WoodDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            switch (e.ColumnIndex)
            {
                case 1:
                    if (WoodDataGridView.SelectedCells[0].Value == null)
                    {
                        woods[e.RowIndex].NomMeuble = "";
                    }
                    woods[e.RowIndex].NomMeuble = WoodDataGridView.SelectedCells[0].Value.ToString();
                    break;
                case 2:
                    if (WoodDataGridView.SelectedCells[0].Value == null)
                    {
                        woods[e.RowIndex].NomPiece = "";
                    }
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

            hasChangedValues = true;
            SetResultsDataGridView();
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

            TakeScreenShot();
        }

        private void TakeScreenShot()
        {
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                bitmap.Save($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}{GlobalConfig.ScreenShotsDirectory}{project.Name}.jpg", ImageFormat.Jpeg);
            }
        }

        private void InputBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!hasSaved && hasChangedValues)
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
            hasChangedValues = true;
        }

        private void EraseProjectBtn_Click(object sender, EventArgs e)
        {
            var validDelete = MessageBox.Show("Voulez-vous vraiment supprimer ce projet ?", "Supprimer ?", MessageBoxButtons.YesNo);

            if (validDelete == DialogResult.Yes)
            {
                GlobalConfig.connection.DeleteProject(project);

                if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}{GlobalConfig.ScreenShotsDirectory}{project.Name}.jpg"))
                {
                    File.Delete($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}{GlobalConfig.ScreenShotsDirectory}{project.Name}.jpg");
                }

                hasSaved = true;
                this.Close();
            }
        }

        private void InputBoardForm_Load(object sender, EventArgs e)
        {
            WoodDataGridView.CurrentCell.Selected = false;

            if (ResultsDataGridView.CurrentCell != null)
            {
                ResultsDataGridView.CurrentCell.Selected = false;
            }
            if (Results30PercentDataGridView.CurrentCell != null)
            {
                Results30PercentDataGridView.CurrentCell.Selected = false;
            }
        }
    }
}

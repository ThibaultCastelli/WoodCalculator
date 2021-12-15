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
    public partial class MainMenuForm : Form
    {
        List<ProjectModel> projects = new List<ProjectModel>();

        public MainMenuForm()
        {
            InitializeComponent();

            WireUpDropdown();
        }

        private void WireUpDropdown()
        {
            projects = GlobalConfig.connection.GetProjectAll();

            projectsDropdown.DataSource = null;
            projectsDropdown.DataSource = projects;
            projectsDropdown.DisplayMember = "Name";
        }

        private void createProjectBtn_Click(object sender, EventArgs e)
        {
            if (CheckEssenceEditFormOpen())
            {
                MessageBox.Show("Il faut fermer la fenêtre d'édition des essences pour créer un nouveau projet.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prevent from having two input forms open at the same time
            Form inputBoardForm = GetInputBoardFormOpen();
            if (inputBoardForm != null)
            {
                inputBoardForm.Close();
            }

            ProjectModel emptyProject = new ProjectModel();
            List<WoodModel> emptyWoods = new List<WoodModel>();

            for(int i = 0; i < 10; i++)
                emptyWoods.Add(new WoodModel());

            emptyProject.Woods = emptyWoods;

            InputBoardForm frm = new InputBoardForm(emptyProject);
            frm.OnCloseForm += WireUpDropdown;
            frm.Show();
        }

        private void LoadProjectBtn_Click(object sender, EventArgs e)
        {
            if (CheckEssenceEditFormOpen())
            {
                MessageBox.Show("Il faut fermer la fenêtre d'édition des essences pour charger un projet.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prevent from having two input forms open at the same time
            Form inputBoardForm = GetInputBoardFormOpen();
            if (inputBoardForm != null)
            {
                inputBoardForm.Close();
            }

            ProjectModel selectedProject = (ProjectModel)projectsDropdown.SelectedItem;

            if (selectedProject == null)
            {
                MessageBox.Show("Il faut selectionner un projet.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InputBoardForm frm = new InputBoardForm(selectedProject);
            frm.OnCloseForm += WireUpDropdown;
            frm.Show();
        }

        private void editEssencesBtn_Click(object sender, EventArgs e)
        {
            if (CheckEssenceEditFormOpen())
                return;

            EssenceEditForm frm = new EssenceEditForm();
            frm.Show();
        }

        private bool CheckEssenceEditFormOpen()
        {
            FormCollection forms = Application.OpenForms;

            foreach (Form form in forms)
            {
                if (form.Name == "EssenceEditForm")
                    return true;
            }

            return false;
        }

        private Form GetInputBoardFormOpen()
        {
            FormCollection forms = Application.OpenForms;
            
            foreach (Form form in forms)
            {
                if (form.Name == "InputBoardForm")
                    return form;
            }

            return null;
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form inputBoardForm = GetInputBoardFormOpen();
            if (inputBoardForm != null)
            {
                inputBoardForm.Close();
            }
        }
    }
}

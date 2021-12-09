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
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void createProjectBtn_Click(object sender, EventArgs e)
        {
            List<WoodModel> emptyWoods = new List<WoodModel>();
            emptyWoods.Add(new WoodModel());

            InputBoardForm frm = new InputBoardForm(emptyWoods);
            frm.Show();
        }

        private void editEssencesBtn_Click(object sender, EventArgs e)
        {
            FormCollection forms = Application.OpenForms;
            foreach (Form form in forms)
            {
                if (form.Name == "EssenceEditForm")
                    return;
            }

            EssenceEditForm frm = new EssenceEditForm();
            frm.Show();
        }
    }
}

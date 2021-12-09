
namespace WoodCalculatorForms
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.title = new System.Windows.Forms.Label();
            this.createProjectBtn = new System.Windows.Forms.Button();
            this.LoadProjectBtn = new System.Windows.Forms.Button();
            this.editEssencesBtn = new System.Windows.Forms.Button();
            this.projectsDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.title.Location = new System.Drawing.Point(112, 19);
            this.title.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(5);
            this.title.Size = new System.Drawing.Size(579, 82);
            this.title.TabIndex = 1;
            this.title.Text = "WOOD CALCULATOR";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createProjectBtn
            // 
            this.createProjectBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.createProjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.createProjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.createProjectBtn.FlatAppearance.BorderSize = 2;
            this.createProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProjectBtn.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createProjectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.createProjectBtn.Location = new System.Drawing.Point(19, 176);
            this.createProjectBtn.Margin = new System.Windows.Forms.Padding(10);
            this.createProjectBtn.Name = "createProjectBtn";
            this.createProjectBtn.Size = new System.Drawing.Size(422, 99);
            this.createProjectBtn.TabIndex = 4;
            this.createProjectBtn.Text = "Créer un Nouveau Projet";
            this.createProjectBtn.UseVisualStyleBackColor = false;
            this.createProjectBtn.Click += new System.EventHandler(this.createProjectBtn_Click);
            // 
            // LoadProjectBtn
            // 
            this.LoadProjectBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoadProjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.LoadProjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.LoadProjectBtn.FlatAppearance.BorderSize = 2;
            this.LoadProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadProjectBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadProjectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.LoadProjectBtn.Location = new System.Drawing.Point(19, 340);
            this.LoadProjectBtn.Margin = new System.Windows.Forms.Padding(10);
            this.LoadProjectBtn.Name = "LoadProjectBtn";
            this.LoadProjectBtn.Size = new System.Drawing.Size(308, 89);
            this.LoadProjectBtn.TabIndex = 5;
            this.LoadProjectBtn.Text = "Charger un Projet";
            this.LoadProjectBtn.UseVisualStyleBackColor = false;
            // 
            // editEssencesBtn
            // 
            this.editEssencesBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editEssencesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.editEssencesBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.editEssencesBtn.FlatAppearance.BorderSize = 2;
            this.editEssencesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEssencesBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editEssencesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.editEssencesBtn.Location = new System.Drawing.Point(19, 494);
            this.editEssencesBtn.Margin = new System.Windows.Forms.Padding(10);
            this.editEssencesBtn.Name = "editEssencesBtn";
            this.editEssencesBtn.Size = new System.Drawing.Size(226, 79);
            this.editEssencesBtn.TabIndex = 6;
            this.editEssencesBtn.Text = "Editer les Essences";
            this.editEssencesBtn.UseVisualStyleBackColor = false;
            this.editEssencesBtn.Click += new System.EventHandler(this.editEssencesBtn_Click);
            // 
            // projectsDropdown
            // 
            this.projectsDropdown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.projectsDropdown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.projectsDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsDropdown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectsDropdown.FormattingEnabled = true;
            this.projectsDropdown.Location = new System.Drawing.Point(428, 363);
            this.projectsDropdown.Margin = new System.Windows.Forms.Padding(10);
            this.projectsDropdown.Name = "projectsDropdown";
            this.projectsDropdown.Size = new System.Drawing.Size(356, 45);
            this.projectsDropdown.TabIndex = 7;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(803, 671);
            this.Controls.Add(this.projectsDropdown);
            this.Controls.Add(this.editEssencesBtn);
            this.Controls.Add(this.LoadProjectBtn);
            this.Controls.Add(this.createProjectBtn);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(819, 710);
            this.Name = "MainMenuForm";
            this.Text = "Wood Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button createProjectBtn;
        private System.Windows.Forms.Button LoadProjectBtn;
        private System.Windows.Forms.Button editEssencesBtn;
        private System.Windows.Forms.ComboBox projectsDropdown;
    }
}
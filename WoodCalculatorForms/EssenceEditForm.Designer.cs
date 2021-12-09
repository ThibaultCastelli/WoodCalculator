
namespace WoodCalculatorForms
{
    partial class EssenceEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EssenceEditForm));
            this.EssenceNameTxtBox = new System.Windows.Forms.TextBox();
            this.EssenceNameLabel = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EssencesListBox = new System.Windows.Forms.ListBox();
            this.DeleteEssenceBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EssenceNameTxtBox
            // 
            this.EssenceNameTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EssenceNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EssenceNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.EssenceNameTxtBox.Location = new System.Drawing.Point(19, 106);
            this.EssenceNameTxtBox.Name = "EssenceNameTxtBox";
            this.EssenceNameTxtBox.Size = new System.Drawing.Size(360, 52);
            this.EssenceNameTxtBox.TabIndex = 0;
            // 
            // EssenceNameLabel
            // 
            this.EssenceNameLabel.AutoSize = true;
            this.EssenceNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.EssenceNameLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EssenceNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.EssenceNameLabel.Location = new System.Drawing.Point(19, 29);
            this.EssenceNameLabel.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.EssenceNameLabel.Name = "EssenceNameLabel";
            this.EssenceNameLabel.Size = new System.Drawing.Size(290, 46);
            this.EssenceNameLabel.TabIndex = 1;
            this.EssenceNameLabel.Text = "Nom de l\'essence :";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.FlatAppearance.BorderSize = 2;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.AddBtn.Location = new System.Drawing.Point(19, 189);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(10);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(265, 66);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Ajouter l\'essence";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EssencesListBox
            // 
            this.EssencesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EssencesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.EssencesListBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EssencesListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.EssencesListBox.FormattingEnabled = true;
            this.EssencesListBox.ItemHeight = 37;
            this.EssencesListBox.Location = new System.Drawing.Point(473, 29);
            this.EssencesListBox.Name = "EssencesListBox";
            this.EssencesListBox.Size = new System.Drawing.Size(308, 485);
            this.EssencesListBox.TabIndex = 8;
            // 
            // DeleteEssenceBtn
            // 
            this.DeleteEssenceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteEssenceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.DeleteEssenceBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteEssenceBtn.FlatAppearance.BorderSize = 2;
            this.DeleteEssenceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEssenceBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteEssenceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.DeleteEssenceBtn.Location = new System.Drawing.Point(484, 533);
            this.DeleteEssenceBtn.Margin = new System.Windows.Forms.Padding(10);
            this.DeleteEssenceBtn.Name = "DeleteEssenceBtn";
            this.DeleteEssenceBtn.Size = new System.Drawing.Size(286, 60);
            this.DeleteEssenceBtn.TabIndex = 9;
            this.DeleteEssenceBtn.Text = "Retirer l\'essence séléctionnée";
            this.DeleteEssenceBtn.UseVisualStyleBackColor = false;
            this.DeleteEssenceBtn.Click += new System.EventHandler(this.DeleteEssenceBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BackBtn.FlatAppearance.BorderSize = 2;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.BackBtn.Location = new System.Drawing.Point(19, 541);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(10);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(142, 52);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Retour";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EssenceEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteEssenceBtn);
            this.Controls.Add(this.EssencesListBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EssenceNameLabel);
            this.Controls.Add(this.EssenceNameTxtBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 651);
            this.Name = "EssenceEditForm";
            this.Text = "Edition des Essences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EssenceNameTxtBox;
        private System.Windows.Forms.Label EssenceNameLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListBox EssencesListBox;
        private System.Windows.Forms.Button DeleteEssenceBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}
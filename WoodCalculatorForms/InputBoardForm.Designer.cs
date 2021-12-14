
namespace WoodCalculatorForms
{
    partial class InputBoardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBoardForm));
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.ProjectNameTxtBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddRowBtn = new System.Windows.Forms.Button();
            this.RemoveRowBtn = new System.Windows.Forms.Button();
            this.WoodDataGridView = new System.Windows.Forms.DataGridView();
            this.IdTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomMeubleTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPieceTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EssenceComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LongueurTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LargeurTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EpaisseurTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbPieceTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveExitBtn = new System.Windows.Forms.Button();
            this.EraseProjectBtn = new System.Windows.Forms.Button();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.EssenceResultTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeResultTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WoodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ProjectNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ProjectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.ProjectNameLabel.Location = new System.Drawing.Point(156, 658);
            this.ProjectNameLabel.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(198, 37);
            this.ProjectNameLabel.TabIndex = 2;
            this.ProjectNameLabel.Text = "Nom du projet :";
            // 
            // ProjectNameTxtBox
            // 
            this.ProjectNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProjectNameTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ProjectNameTxtBox.Location = new System.Drawing.Point(360, 655);
            this.ProjectNameTxtBox.Name = "ProjectNameTxtBox";
            this.ProjectNameTxtBox.Size = new System.Drawing.Size(360, 43);
            this.ProjectNameTxtBox.TabIndex = 3;
            this.ProjectNameTxtBox.TextChanged += new System.EventHandler(this.EssenceNameTxtBox_TextChanged);
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.AddRowBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.AddRowBtn.FlatAppearance.BorderSize = 2;
            this.AddRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRowBtn.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddRowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.AddRowBtn.Location = new System.Drawing.Point(81, 640);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(63, 69);
            this.AddRowBtn.TabIndex = 9;
            this.AddRowBtn.Text = "+";
            this.AddRowBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddRowBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddRowBtn.UseVisualStyleBackColor = false;
            this.AddRowBtn.Click += new System.EventHandler(this.AddRowBtn_Click);
            // 
            // RemoveRowBtn
            // 
            this.RemoveRowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.RemoveRowBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.RemoveRowBtn.FlatAppearance.BorderSize = 2;
            this.RemoveRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRowBtn.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveRowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.RemoveRowBtn.Location = new System.Drawing.Point(12, 640);
            this.RemoveRowBtn.Name = "RemoveRowBtn";
            this.RemoveRowBtn.Size = new System.Drawing.Size(63, 69);
            this.RemoveRowBtn.TabIndex = 10;
            this.RemoveRowBtn.Text = "-";
            this.RemoveRowBtn.UseVisualStyleBackColor = false;
            this.RemoveRowBtn.Click += new System.EventHandler(this.RemoveRowBtn_Click);
            // 
            // WoodDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(135)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.WoodDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.WoodDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WoodDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.WoodDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WoodDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.WoodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WoodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTxt,
            this.NomMeubleTxt,
            this.NomPieceTxt,
            this.EssenceComboBox,
            this.LongueurTxt,
            this.LargeurTxt,
            this.EpaisseurTxt,
            this.NbPieceTxt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WoodDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.WoodDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.WoodDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.WoodDataGridView.Location = new System.Drawing.Point(19, 19);
            this.WoodDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.WoodDataGridView.Name = "WoodDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WoodDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.WoodDataGridView.RowHeadersWidth = 20;
            this.WoodDataGridView.RowTemplate.Height = 40;
            this.WoodDataGridView.Size = new System.Drawing.Size(1055, 610);
            this.WoodDataGridView.TabIndex = 11;
            this.WoodDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.WoodDataGridView_CellValidating);
            this.WoodDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.WoodDataGridView_CellValueChanged);
            // 
            // IdTxt
            // 
            this.IdTxt.DataPropertyName = "Id";
            this.IdTxt.HeaderText = "Id";
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Visible = false;
            // 
            // NomMeubleTxt
            // 
            this.NomMeubleTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomMeubleTxt.DataPropertyName = "NomMeuble";
            this.NomMeubleTxt.FillWeight = 40F;
            this.NomMeubleTxt.HeaderText = "Nom du Meuble";
            this.NomMeubleTxt.Name = "NomMeubleTxt";
            // 
            // NomPieceTxt
            // 
            this.NomPieceTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomPieceTxt.DataPropertyName = "NomPiece";
            this.NomPieceTxt.FillWeight = 40F;
            this.NomPieceTxt.HeaderText = "Nom de la Pièce";
            this.NomPieceTxt.Name = "NomPieceTxt";
            // 
            // EssenceComboBox
            // 
            this.EssenceComboBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EssenceComboBox.DataPropertyName = "Essence";
            this.EssenceComboBox.FillWeight = 40F;
            this.EssenceComboBox.HeaderText = "Essence";
            this.EssenceComboBox.Name = "EssenceComboBox";
            // 
            // LongueurTxt
            // 
            this.LongueurTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LongueurTxt.DataPropertyName = "Longueur";
            this.LongueurTxt.FillWeight = 20F;
            this.LongueurTxt.HeaderText = "Longueur";
            this.LongueurTxt.Name = "LongueurTxt";
            // 
            // LargeurTxt
            // 
            this.LargeurTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LargeurTxt.DataPropertyName = "Largeur";
            this.LargeurTxt.FillWeight = 20F;
            this.LargeurTxt.HeaderText = "Largeur";
            this.LargeurTxt.Name = "LargeurTxt";
            // 
            // EpaisseurTxt
            // 
            this.EpaisseurTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EpaisseurTxt.DataPropertyName = "Epaisseur";
            this.EpaisseurTxt.FillWeight = 20F;
            this.EpaisseurTxt.HeaderText = "Epaisseur";
            this.EpaisseurTxt.Name = "EpaisseurTxt";
            // 
            // NbPieceTxt
            // 
            this.NbPieceTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NbPieceTxt.DataPropertyName = "NbPieces";
            this.NbPieceTxt.FillWeight = 20F;
            this.NbPieceTxt.HeaderText = "Nb de Pièces";
            this.NbPieceTxt.Name = "NbPieceTxt";
            // 
            // SaveExitBtn
            // 
            this.SaveExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SaveExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.SaveExitBtn.FlatAppearance.BorderSize = 2;
            this.SaveExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveExitBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.SaveExitBtn.Location = new System.Drawing.Point(947, 649);
            this.SaveExitBtn.Margin = new System.Windows.Forms.Padding(10);
            this.SaveExitBtn.Name = "SaveExitBtn";
            this.SaveExitBtn.Size = new System.Drawing.Size(237, 53);
            this.SaveExitBtn.TabIndex = 12;
            this.SaveExitBtn.Text = "Sauvegarder et Quitter";
            this.SaveExitBtn.UseVisualStyleBackColor = false;
            this.SaveExitBtn.Click += new System.EventHandler(this.SaveExitBtn_Click);
            // 
            // EraseProjectBtn
            // 
            this.EraseProjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EraseProjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.EraseProjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.EraseProjectBtn.FlatAppearance.BorderSize = 2;
            this.EraseProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EraseProjectBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EraseProjectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            this.EraseProjectBtn.Location = new System.Drawing.Point(1204, 649);
            this.EraseProjectBtn.Margin = new System.Windows.Forms.Padding(10);
            this.EraseProjectBtn.Name = "EraseProjectBtn";
            this.EraseProjectBtn.Size = new System.Drawing.Size(161, 53);
            this.EraseProjectBtn.TabIndex = 13;
            this.EraseProjectBtn.Text = "Effacer le Projet";
            this.EraseProjectBtn.UseVisualStyleBackColor = false;
            this.EraseProjectBtn.Click += new System.EventHandler(this.EraseProjectBtn_Click);
            // 
            // ResultsDataGridView
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(135)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ResultsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ResultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ResultsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EssenceResultTxt,
            this.VolumeResultTxt});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultsDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.ResultsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ResultsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ResultsDataGridView.Location = new System.Drawing.Point(1094, 19);
            this.ResultsDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ResultsDataGridView.RowHeadersWidth = 20;
            this.ResultsDataGridView.RowTemplate.Height = 40;
            this.ResultsDataGridView.Size = new System.Drawing.Size(271, 610);
            this.ResultsDataGridView.TabIndex = 15;
            // 
            // EssenceResultTxt
            // 
            this.EssenceResultTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EssenceResultTxt.DataPropertyName = "Essence";
            this.EssenceResultTxt.HeaderText = "Essence";
            this.EssenceResultTxt.Name = "EssenceResultTxt";
            this.EssenceResultTxt.ReadOnly = true;
            // 
            // VolumeResultTxt
            // 
            this.VolumeResultTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VolumeResultTxt.DataPropertyName = "Volume";
            this.VolumeResultTxt.HeaderText = "Volume";
            this.VolumeResultTxt.Name = "VolumeResultTxt";
            this.VolumeResultTxt.ReadOnly = true;
            // 
            // InputBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1384, 721);
            this.Controls.Add(this.ResultsDataGridView);
            this.Controls.Add(this.EraseProjectBtn);
            this.Controls.Add(this.SaveExitBtn);
            this.Controls.Add(this.WoodDataGridView);
            this.Controls.Add(this.RemoveRowBtn);
            this.Controls.Add(this.AddRowBtn);
            this.Controls.Add(this.ProjectNameTxtBox);
            this.Controls.Add(this.ProjectNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "InputBoardForm";
            this.Text = "Feuille de Débit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputBoardForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.WoodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.TextBox ProjectNameTxtBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AddRowBtn;
        private System.Windows.Forms.Button RemoveRowBtn;
        private System.Windows.Forms.DataGridView WoodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomMeubleTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPieceTxt;
        private System.Windows.Forms.DataGridViewComboBoxColumn EssenceComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn LongueurTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LargeurTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpaisseurTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbPieceTxt;
        private System.Windows.Forms.Button SaveExitBtn;
        private System.Windows.Forms.Button EraseProjectBtn;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EssenceResultTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeResultTxt;
    }
}
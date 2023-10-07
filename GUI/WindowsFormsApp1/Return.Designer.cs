namespace WindowsFormsApp1
{
    partial class Return
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gAMEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETURNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.games_Rental_SystemDataSet = new WindowsFormsApp1.Games_Rental_SystemDataSet();
            this.GameID = new System.Windows.Forms.TextBox();
            this.AdminID = new System.Windows.Forms.TextBox();
            this.rETURNTableAdapter = new WindowsFormsApp1.Games_Rental_SystemDataSetTableAdapters.RETURNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.games_Rental_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 35F);
            this.label7.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label7.Location = new System.Drawing.Point(262, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(342, 59);
            this.label7.TabIndex = 67;
            this.label7.Text = "Return Game";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(3, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 19);
            this.label6.TabIndex = 66;
            this.label6.Text = "GameRental";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.GamingVs;
            this.pictureBox1.Location = new System.Drawing.Point(29, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button4.Location = new System.Drawing.Point(430, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(294, 27);
            this.button4.TabIndex = 64;
            this.button4.Text = "Show Available Games";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button1.Location = new System.Drawing.Point(89, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 27);
            this.button1.TabIndex = 60;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(355, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Game ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(355, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "CLIENT ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gAMEIDDataGridViewTextBoxColumn,
            this.cLIENTIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rETURNBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(255, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(302, 140);
            this.dataGridView1.TabIndex = 55;
            // 
            // gAMEIDDataGridViewTextBoxColumn
            // 
            this.gAMEIDDataGridViewTextBoxColumn.DataPropertyName = "GAME_ID";
            this.gAMEIDDataGridViewTextBoxColumn.HeaderText = "GAME_ID";
            this.gAMEIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gAMEIDDataGridViewTextBoxColumn.Name = "gAMEIDDataGridViewTextBoxColumn";
            this.gAMEIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            this.cLIENTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rETURNBindingSource
            // 
            this.rETURNBindingSource.DataMember = "RETURN";
            this.rETURNBindingSource.DataSource = this.games_Rental_SystemDataSet;
            // 
            // games_Rental_SystemDataSet
            // 
            this.games_Rental_SystemDataSet.DataSetName = "Games_Rental_SystemDataSet";
            this.games_Rental_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GameID
            // 
            this.GameID.BackColor = System.Drawing.Color.Pink;
            this.GameID.Location = new System.Drawing.Point(197, 218);
            this.GameID.Name = "GameID";
            this.GameID.Size = new System.Drawing.Size(407, 20);
            this.GameID.TabIndex = 54;
            // 
            // AdminID
            // 
            this.AdminID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AdminID.Location = new System.Drawing.Point(197, 167);
            this.AdminID.Name = "AdminID";
            this.AdminID.Size = new System.Drawing.Size(407, 20);
            this.AdminID.TabIndex = 50;
            // 
            // rETURNTableAdapter
            // 
            this.rETURNTableAdapter.ClearBeforeFill = true;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_323880864_TPsH5ropjEBo1ViILJmcFHJqsBzorxUB;
            this.ClientSize = new System.Drawing.Size(797, 452);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GameID);
            this.Controls.Add(this.AdminID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.games_Rental_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox GameID;
        private System.Windows.Forms.TextBox AdminID;
        private Games_Rental_SystemDataSet games_Rental_SystemDataSet;
        private System.Windows.Forms.BindingSource rETURNBindingSource;
        private Games_Rental_SystemDataSetTableAdapters.RETURNTableAdapter rETURNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAMEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
    }
}
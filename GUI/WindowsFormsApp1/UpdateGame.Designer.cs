namespace WindowsFormsApp1
{
    partial class UpdateGame
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aDMINIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLATFORMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPDATEGAMEDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.games_Rental_SystemDataSet = new WindowsFormsApp1.Games_Rental_SystemDataSet();
            this.GameID = new System.Windows.Forms.TextBox();
            this.GameName = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.PlatForm = new System.Windows.Forms.TextBox();
            this.AdminID = new System.Windows.Forms.TextBox();
            this.uPDATEGAMEDETAILSTableAdapter = new WindowsFormsApp1.Games_Rental_SystemDataSetTableAdapters.UPDATEGAMEDETAILSTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPDATEGAMEDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.games_Rental_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Digistyle Unicode", 10.8F);
            this.button4.Location = new System.Drawing.Point(686, 498);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(343, 33);
            this.button4.TabIndex = 30;
            this.button4.Text = "Show Updated Data";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Digistyle Unicode", 10.8F);
            this.button3.Location = new System.Drawing.Point(278, 498);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 33);
            this.button3.TabIndex = 29;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(3, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "PlatForm";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Digistyle Unicode", 10.8F);
            this.button2.Location = new System.Drawing.Point(422, 498);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 27;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Digistyle Unicode", 10.8F);
            this.button1.Location = new System.Drawing.Point(127, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label5.Location = new System.Drawing.Point(-2, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Game Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label4.Location = new System.Drawing.Point(4, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(29, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Game ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(19, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Admin ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDMINIDDataGridViewTextBoxColumn,
            this.gAMEIDDataGridViewTextBoxColumn,
            this.pLATFORMDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.gNAMEDataGridViewTextBoxColumn,
            this.yEARDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uPDATEGAMEDETAILSBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(517, 191);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(631, 272);
            this.dataGridView1.TabIndex = 21;
            // 
            // aDMINIDDataGridViewTextBoxColumn
            // 
            this.aDMINIDDataGridViewTextBoxColumn.DataPropertyName = "ADMIN_ID";
            this.aDMINIDDataGridViewTextBoxColumn.HeaderText = "ADMIN_ID";
            this.aDMINIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDMINIDDataGridViewTextBoxColumn.Name = "aDMINIDDataGridViewTextBoxColumn";
            this.aDMINIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // gAMEIDDataGridViewTextBoxColumn
            // 
            this.gAMEIDDataGridViewTextBoxColumn.DataPropertyName = "GAME_ID";
            this.gAMEIDDataGridViewTextBoxColumn.HeaderText = "GAME_ID";
            this.gAMEIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gAMEIDDataGridViewTextBoxColumn.Name = "gAMEIDDataGridViewTextBoxColumn";
            this.gAMEIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pLATFORMDataGridViewTextBoxColumn
            // 
            this.pLATFORMDataGridViewTextBoxColumn.DataPropertyName = "PLATFORM";
            this.pLATFORMDataGridViewTextBoxColumn.HeaderText = "PLATFORM";
            this.pLATFORMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pLATFORMDataGridViewTextBoxColumn.Name = "pLATFORMDataGridViewTextBoxColumn";
            this.pLATFORMDataGridViewTextBoxColumn.Width = 125;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.Width = 125;
            // 
            // gNAMEDataGridViewTextBoxColumn
            // 
            this.gNAMEDataGridViewTextBoxColumn.DataPropertyName = "G_NAME";
            this.gNAMEDataGridViewTextBoxColumn.HeaderText = "G_NAME";
            this.gNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gNAMEDataGridViewTextBoxColumn.Name = "gNAMEDataGridViewTextBoxColumn";
            this.gNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // yEARDataGridViewTextBoxColumn
            // 
            this.yEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR";
            this.yEARDataGridViewTextBoxColumn.HeaderText = "YEAR";
            this.yEARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yEARDataGridViewTextBoxColumn.Name = "yEARDataGridViewTextBoxColumn";
            this.yEARDataGridViewTextBoxColumn.Width = 125;
            // 
            // uPDATEGAMEDETAILSBindingSource
            // 
            this.uPDATEGAMEDETAILSBindingSource.DataMember = "UPDATEGAMEDETAILS";
            this.uPDATEGAMEDETAILSBindingSource.DataSource = this.games_Rental_SystemDataSet;
            // 
            // games_Rental_SystemDataSet
            // 
            this.games_Rental_SystemDataSet.DataSetName = "Games_Rental_SystemDataSet";
            this.games_Rental_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GameID
            // 
            this.GameID.BackColor = System.Drawing.Color.Pink;
            this.GameID.Location = new System.Drawing.Point(127, 255);
            this.GameID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GameID.Name = "GameID";
            this.GameID.Size = new System.Drawing.Size(382, 24);
            this.GameID.TabIndex = 20;
            // 
            // GameName
            // 
            this.GameName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.GameName.Location = new System.Drawing.Point(127, 436);
            this.GameName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(382, 24);
            this.GameName.TabIndex = 19;
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.Pink;
            this.Category.Location = new System.Drawing.Point(127, 373);
            this.Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(382, 24);
            this.Category.TabIndex = 18;
            // 
            // PlatForm
            // 
            this.PlatForm.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PlatForm.Location = new System.Drawing.Point(127, 312);
            this.PlatForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlatForm.Name = "PlatForm";
            this.PlatForm.Size = new System.Drawing.Size(382, 24);
            this.PlatForm.TabIndex = 17;
            // 
            // AdminID
            // 
            this.AdminID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AdminID.Location = new System.Drawing.Point(127, 194);
            this.AdminID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminID.Name = "AdminID";
            this.AdminID.Size = new System.Drawing.Size(382, 24);
            this.AdminID.TabIndex = 16;
            // 
            // uPDATEGAMEDETAILSTableAdapter
            // 
            this.uPDATEGAMEDETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(16, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "GameRental";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.GamingVs;
            this.pictureBox1.Location = new System.Drawing.Point(47, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 35F);
            this.label7.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label7.Location = new System.Drawing.Point(409, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(427, 74);
            this.label7.TabIndex = 49;
            this.label7.Text = "Update Game";
            // 
            // UpdateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_323880864_TPsH5ropjEBo1ViILJmcFHJqsBzorxUB;
            this.ClientSize = new System.Drawing.Size(1193, 625);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GameID);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.PlatForm);
            this.Controls.Add(this.AdminID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateGame";
            this.Text = "UpdateGame";
            this.Load += new System.EventHandler(this.UpdateGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPDATEGAMEDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.games_Rental_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox GameID;
        private System.Windows.Forms.TextBox GameName;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox PlatForm;
        private System.Windows.Forms.TextBox AdminID;
        private Games_Rental_SystemDataSet games_Rental_SystemDataSet;
        private System.Windows.Forms.BindingSource uPDATEGAMEDETAILSBindingSource;
        private Games_Rental_SystemDataSetTableAdapters.UPDATEGAMEDETAILSTableAdapter uPDATEGAMEDETAILSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAMEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLATFORMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}
namespace WindowsFormsApp1
{
    partial class Renting
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
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.GameID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.games_Rental_SystemDataSet = new WindowsFormsApp1.Games_Rental_SystemDataSet();
            this.rENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rENTTableAdapter = new WindowsFormsApp1.Games_Rental_SystemDataSetTableAdapters.RENTTableAdapter();
            this.gAMEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEOFRENTINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.games_Rental_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(160, 303);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(256, 20);
            this.Date.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gAMEIDDataGridViewTextBoxColumn,
            this.cLIENTIDDataGridViewTextBoxColumn,
            this.vENDORIDDataGridViewTextBoxColumn,
            this.dATEOFRENTINGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rENTBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(473, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(455, 146);
            this.dataGridView1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(299, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 71);
            this.button1.TabIndex = 19;
            this.button1.Text = "ADD";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientID
            // 
            this.ClientID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientID.Location = new System.Drawing.Point(160, 240);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(256, 20);
            this.ClientID.TabIndex = 18;
            // 
            // GameID
            // 
            this.GameID.BackColor = System.Drawing.Color.Pink;
            this.GameID.Location = new System.Drawing.Point(160, 177);
            this.GameID.Name = "GameID";
            this.GameID.Size = new System.Drawing.Size(256, 20);
            this.GameID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(8, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date of renting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(62, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Game ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(53, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Client ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 40F);
            this.label7.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label7.Location = new System.Drawing.Point(347, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 67);
            this.label7.TabIndex = 70;
            this.label7.Text = "Rent Game";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(17, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "GameRental";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.GamingVs;
            this.pictureBox1.Location = new System.Drawing.Point(44, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(568, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 23);
            this.button2.TabIndex = 71;
            this.button2.Text = "SHOW UPDATED DATA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // games_Rental_SystemDataSet
            // 
            this.games_Rental_SystemDataSet.DataSetName = "Games_Rental_SystemDataSet";
            this.games_Rental_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rENTBindingSource
            // 
            this.rENTBindingSource.DataMember = "RENT";
            this.rENTBindingSource.DataSource = this.games_Rental_SystemDataSet;
            // 
            // rENTTableAdapter
            // 
            this.rENTTableAdapter.ClearBeforeFill = true;
            // 
            // gAMEIDDataGridViewTextBoxColumn
            // 
            this.gAMEIDDataGridViewTextBoxColumn.DataPropertyName = "GAME_ID";
            this.gAMEIDDataGridViewTextBoxColumn.HeaderText = "GAME_ID";
            this.gAMEIDDataGridViewTextBoxColumn.Name = "gAMEIDDataGridViewTextBoxColumn";
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            // 
            // vENDORIDDataGridViewTextBoxColumn
            // 
            this.vENDORIDDataGridViewTextBoxColumn.DataPropertyName = "VENDOR_ID";
            this.vENDORIDDataGridViewTextBoxColumn.HeaderText = "VENDOR_ID";
            this.vENDORIDDataGridViewTextBoxColumn.Name = "vENDORIDDataGridViewTextBoxColumn";
            // 
            // dATEOFRENTINGDataGridViewTextBoxColumn
            // 
            this.dATEOFRENTINGDataGridViewTextBoxColumn.DataPropertyName = "DATEOFRENTING";
            this.dATEOFRENTINGDataGridViewTextBoxColumn.HeaderText = "DATEOFRENTING";
            this.dATEOFRENTINGDataGridViewTextBoxColumn.Name = "dATEOFRENTINGDataGridViewTextBoxColumn";
            // 
            // Renting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._360_F_323880864_TPsH5ropjEBo1ViILJmcFHJqsBzorxUB;
            this.ClientSize = new System.Drawing.Size(967, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClientID);
            this.Controls.Add(this.GameID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Renting";
            this.Text = "Renting";
            this.Load += new System.EventHandler(this.Renting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.games_Rental_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.TextBox GameID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private Games_Rental_SystemDataSet games_Rental_SystemDataSet;
        private System.Windows.Forms.BindingSource rENTBindingSource;
        private Games_Rental_SystemDataSetTableAdapters.RENTTableAdapter rENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAMEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEOFRENTINGDataGridViewTextBoxColumn;
    }
}
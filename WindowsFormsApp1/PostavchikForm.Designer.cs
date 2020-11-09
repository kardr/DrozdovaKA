namespace WindowsFormsApp1
{
    partial class PostavchikForm
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
            this.dataGridViewPostav = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet7 = new WindowsFormsApp1.SkladDataSet7();
            this.postavchikTableAdapter = new WindowsFormsApp1.SkladDataSet7TableAdapters.PostavchikTableAdapter();
            this.Namel = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.textBoxPostavName = new System.Windows.Forms.TextBox();
            this.textBoxPostavID = new System.Windows.Forms.TextBox();
            this.DobavleniePostav = new System.Windows.Forms.Button();
            this.RedaktirPostav = new System.Windows.Forms.Button();
            this.DeletePostav = new System.Windows.Forms.Button();
            this.textBoxPostavAdress = new System.Windows.Forms.TextBox();
            this.textBoxPostavTelefon = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPostavRedaTel = new System.Windows.Forms.TextBox();
            this.textBoxPostavRedaAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPostavRedakName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPostav
            // 
            this.dataGridViewPostav.AutoGenerateColumns = false;
            this.dataGridViewPostav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPostav.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridViewPostav.DataSource = this.postavchikBindingSource;
            this.dataGridViewPostav.Location = new System.Drawing.Point(26, 12);
            this.dataGridViewPostav.Name = "dataGridViewPostav";
            this.dataGridViewPostav.RowHeadersVisible = false;
            this.dataGridViewPostav.Size = new System.Drawing.Size(487, 184);
            this.dataGridViewPostav.TabIndex = 0;
            this.dataGridViewPostav.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPostav_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // postavchikBindingSource
            // 
            this.postavchikBindingSource.DataMember = "Postavchik";
            this.postavchikBindingSource.DataSource = this.skladDataSet7;
            // 
            // skladDataSet7
            // 
            this.skladDataSet7.DataSetName = "SkladDataSet7";
            this.skladDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavchikTableAdapter
            // 
            this.postavchikTableAdapter.ClearBeforeFill = true;
            // 
            // Namel
            // 
            this.Namel.AutoSize = true;
            this.Namel.Location = new System.Drawing.Point(79, 277);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(83, 13);
            this.Namel.TabIndex = 25;
            this.Namel.Text = "Наименование";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(79, 228);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 13);
            this.Id.TabIndex = 24;
            this.Id.Text = "ID";
            // 
            // textBoxPostavName
            // 
            this.textBoxPostavName.Location = new System.Drawing.Point(79, 296);
            this.textBoxPostavName.Name = "textBoxPostavName";
            this.textBoxPostavName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostavName.TabIndex = 23;
            // 
            // textBoxPostavID
            // 
            this.textBoxPostavID.Location = new System.Drawing.Point(79, 244);
            this.textBoxPostavID.Name = "textBoxPostavID";
            this.textBoxPostavID.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostavID.TabIndex = 22;
            // 
            // DobavleniePostav
            // 
            this.DobavleniePostav.Location = new System.Drawing.Point(588, 35);
            this.DobavleniePostav.Name = "DobavleniePostav";
            this.DobavleniePostav.Size = new System.Drawing.Size(99, 36);
            this.DobavleniePostav.TabIndex = 21;
            this.DobavleniePostav.Text = "Добавление";
            this.DobavleniePostav.UseVisualStyleBackColor = true;
            this.DobavleniePostav.Click += new System.EventHandler(this.DobavleniePostav_Click);
            // 
            // RedaktirPostav
            // 
            this.RedaktirPostav.Location = new System.Drawing.Point(588, 122);
            this.RedaktirPostav.Name = "RedaktirPostav";
            this.RedaktirPostav.Size = new System.Drawing.Size(99, 39);
            this.RedaktirPostav.TabIndex = 20;
            this.RedaktirPostav.Text = "Редактирование";
            this.RedaktirPostav.UseVisualStyleBackColor = true;
            this.RedaktirPostav.Click += new System.EventHandler(this.RedaktirPostav_Click);
            // 
            // DeletePostav
            // 
            this.DeletePostav.Location = new System.Drawing.Point(588, 77);
            this.DeletePostav.Name = "DeletePostav";
            this.DeletePostav.Size = new System.Drawing.Size(99, 39);
            this.DeletePostav.TabIndex = 19;
            this.DeletePostav.Text = "Удаление";
            this.DeletePostav.UseVisualStyleBackColor = true;
            this.DeletePostav.Click += new System.EventHandler(this.DeletePostav_Click);
            // 
            // textBoxPostavAdress
            // 
            this.textBoxPostavAdress.Location = new System.Drawing.Point(78, 347);
            this.textBoxPostavAdress.Name = "textBoxPostavAdress";
            this.textBoxPostavAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostavAdress.TabIndex = 26;
            // 
            // textBoxPostavTelefon
            // 
            this.textBoxPostavTelefon.Location = new System.Drawing.Point(78, 401);
            this.textBoxPostavTelefon.Name = "textBoxPostavTelefon";
            this.textBoxPostavTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostavTelefon.TabIndex = 27;
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(75, 331);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(38, 13);
            this.Adress.TabIndex = 28;
            this.Adress.Text = "Адрес";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(75, 385);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(52, 13);
            this.Telefon.TabIndex = 29;
            this.Telefon.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Адрес";
            // 
            // textBoxPostavRedaTel
            // 
            this.textBoxPostavRedaTel.Location = new System.Drawing.Point(570, 378);
            this.textBoxPostavRedaTel.Name = "textBoxPostavRedaTel";
            this.textBoxPostavRedaTel.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostavRedaTel.TabIndex = 35;
            // 
            // textBoxPostavRedaAdres
            // 
            this.textBoxPostavRedaAdres.Location = new System.Drawing.Point(570, 324);
            this.textBoxPostavRedaAdres.Name = "textBoxPostavRedaAdres";
            this.textBoxPostavRedaAdres.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostavRedaAdres.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Наименование";
            // 
            // textBoxPostavRedakName
            // 
            this.textBoxPostavRedakName.Location = new System.Drawing.Point(571, 273);
            this.textBoxPostavRedakName.Name = "textBoxPostavRedakName";
            this.textBoxPostavRedakName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostavRedakName.TabIndex = 31;
            // 
            // PostavchikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPostavRedaTel);
            this.Controls.Add(this.textBoxPostavRedaAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPostavRedakName);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.textBoxPostavTelefon);
            this.Controls.Add(this.textBoxPostavAdress);
            this.Controls.Add(this.Namel);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.textBoxPostavName);
            this.Controls.Add(this.textBoxPostavID);
            this.Controls.Add(this.DobavleniePostav);
            this.Controls.Add(this.RedaktirPostav);
            this.Controls.Add(this.DeletePostav);
            this.Controls.Add(this.dataGridViewPostav);
            this.Name = "PostavchikForm";
            this.Text = "Поставщик";
            this.Load += new System.EventHandler(this.PostavchikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPostav;
        private SkladDataSet7 skladDataSet7;
        private System.Windows.Forms.BindingSource postavchikBindingSource;
        private SkladDataSet7TableAdapters.PostavchikTableAdapter postavchikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Namel;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox textBoxPostavName;
        private System.Windows.Forms.TextBox textBoxPostavID;
        private System.Windows.Forms.Button DobavleniePostav;
        private System.Windows.Forms.Button RedaktirPostav;
        private System.Windows.Forms.Button DeletePostav;
        private System.Windows.Forms.TextBox textBoxPostavAdress;
        private System.Windows.Forms.TextBox textBoxPostavTelefon;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPostavRedaTel;
        private System.Windows.Forms.TextBox textBoxPostavRedaAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPostavRedakName;
    }
}
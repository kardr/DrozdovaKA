namespace WindowsFormsApp1
{
    partial class MarkaForm
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
            this.dataGridViewMarka = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet5 = new WindowsFormsApp1.SkladDataSet5();
            this.markaTableAdapter = new WindowsFormsApp1.SkladDataSet5TableAdapters.MarkaTableAdapter();
            this.DobavlenieMarka = new System.Windows.Forms.Button();
            this.RedaktirMarka = new System.Windows.Forms.Button();
            this.DeleteMarka = new System.Windows.Forms.Button();
            this.Namel = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.textBoxMarkaName = new System.Windows.Forms.TextBox();
            this.textBoxMarkaID = new System.Windows.Forms.TextBox();
            this.NameRedakMarka = new System.Windows.Forms.Label();
            this.IDredakMarka = new System.Windows.Forms.Label();
            this.textBoxRedakMarkaName = new System.Windows.Forms.TextBox();
            this.textBoxRedakMarkaID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMarka
            // 
            this.dataGridViewMarka.AutoGenerateColumns = false;
            this.dataGridViewMarka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewMarka.DataSource = this.markaBindingSource;
            this.dataGridViewMarka.Location = new System.Drawing.Point(65, 47);
            this.dataGridViewMarka.Name = "dataGridViewMarka";
            this.dataGridViewMarka.RowHeadersVisible = false;
            this.dataGridViewMarka.Size = new System.Drawing.Size(231, 184);
            this.dataGridViewMarka.TabIndex = 0;
            this.dataGridViewMarka.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarka_CellClick);
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
            // markaBindingSource
            // 
            this.markaBindingSource.DataMember = "Marka";
            this.markaBindingSource.DataSource = this.skladDataSet5;
            // 
            // skladDataSet5
            // 
            this.skladDataSet5.DataSetName = "SkladDataSet5";
            this.skladDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markaTableAdapter
            // 
            this.markaTableAdapter.ClearBeforeFill = true;
            // 
            // DobavlenieMarka
            // 
            this.DobavlenieMarka.Location = new System.Drawing.Point(389, 160);
            this.DobavlenieMarka.Name = "DobavlenieMarka";
            this.DobavlenieMarka.Size = new System.Drawing.Size(99, 36);
            this.DobavlenieMarka.TabIndex = 7;
            this.DobavlenieMarka.Text = "Добавление";
            this.DobavlenieMarka.UseVisualStyleBackColor = true;
            this.DobavlenieMarka.Click += new System.EventHandler(this.DobavlenieMarka_Click);
            // 
            // RedaktirMarka
            // 
            this.RedaktirMarka.Location = new System.Drawing.Point(602, 202);
            this.RedaktirMarka.Name = "RedaktirMarka";
            this.RedaktirMarka.Size = new System.Drawing.Size(99, 39);
            this.RedaktirMarka.TabIndex = 6;
            this.RedaktirMarka.Text = "Редактирование";
            this.RedaktirMarka.UseVisualStyleBackColor = true;
            this.RedaktirMarka.Click += new System.EventHandler(this.RedaktirMarka_Click);
            // 
            // DeleteMarka
            // 
            this.DeleteMarka.Location = new System.Drawing.Point(125, 237);
            this.DeleteMarka.Name = "DeleteMarka";
            this.DeleteMarka.Size = new System.Drawing.Size(99, 39);
            this.DeleteMarka.TabIndex = 5;
            this.DeleteMarka.Text = "Удаление";
            this.DeleteMarka.UseVisualStyleBackColor = true;
            this.DeleteMarka.Click += new System.EventHandler(this.DeleteMarka_Click);
            // 
            // Namel
            // 
            this.Namel.AutoSize = true;
            this.Namel.Location = new System.Drawing.Point(386, 106);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(83, 13);
            this.Namel.TabIndex = 18;
            this.Namel.Text = "Наименование";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(386, 57);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 13);
            this.Id.TabIndex = 17;
            this.Id.Text = "ID";
            // 
            // textBoxMarkaName
            // 
            this.textBoxMarkaName.Location = new System.Drawing.Point(386, 125);
            this.textBoxMarkaName.Name = "textBoxMarkaName";
            this.textBoxMarkaName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarkaName.TabIndex = 16;
            // 
            // textBoxMarkaID
            // 
            this.textBoxMarkaID.Location = new System.Drawing.Point(386, 73);
            this.textBoxMarkaID.Name = "textBoxMarkaID";
            this.textBoxMarkaID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarkaID.TabIndex = 15;
            // 
            // NameRedakMarka
            // 
            this.NameRedakMarka.AutoSize = true;
            this.NameRedakMarka.Location = new System.Drawing.Point(599, 141);
            this.NameRedakMarka.Name = "NameRedakMarka";
            this.NameRedakMarka.Size = new System.Drawing.Size(83, 13);
            this.NameRedakMarka.TabIndex = 22;
            this.NameRedakMarka.Text = "Наименование";
            // 
            // IDredakMarka
            // 
            this.IDredakMarka.AutoSize = true;
            this.IDredakMarka.Location = new System.Drawing.Point(599, 92);
            this.IDredakMarka.Name = "IDredakMarka";
            this.IDredakMarka.Size = new System.Drawing.Size(18, 13);
            this.IDredakMarka.TabIndex = 21;
            this.IDredakMarka.Text = "ID";
            // 
            // textBoxRedakMarkaName
            // 
            this.textBoxRedakMarkaName.Location = new System.Drawing.Point(599, 160);
            this.textBoxRedakMarkaName.Name = "textBoxRedakMarkaName";
            this.textBoxRedakMarkaName.Size = new System.Drawing.Size(100, 20);
            this.textBoxRedakMarkaName.TabIndex = 20;
            // 
            // textBoxRedakMarkaID
            // 
            this.textBoxRedakMarkaID.Location = new System.Drawing.Point(599, 108);
            this.textBoxRedakMarkaID.Name = "textBoxRedakMarkaID";
            this.textBoxRedakMarkaID.Size = new System.Drawing.Size(100, 20);
            this.textBoxRedakMarkaID.TabIndex = 19;
            // 
            // MarkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameRedakMarka);
            this.Controls.Add(this.IDredakMarka);
            this.Controls.Add(this.textBoxRedakMarkaName);
            this.Controls.Add(this.textBoxRedakMarkaID);
            this.Controls.Add(this.Namel);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.textBoxMarkaName);
            this.Controls.Add(this.textBoxMarkaID);
            this.Controls.Add(this.DobavlenieMarka);
            this.Controls.Add(this.RedaktirMarka);
            this.Controls.Add(this.DeleteMarka);
            this.Controls.Add(this.dataGridViewMarka);
            this.Name = "MarkaForm";
            this.Text = "Марка";
            this.Load += new System.EventHandler(this.MarkaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMarka;
        private SkladDataSet5 skladDataSet5;
        private System.Windows.Forms.BindingSource markaBindingSource;
        private SkladDataSet5TableAdapters.MarkaTableAdapter markaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DobavlenieMarka;
        private System.Windows.Forms.Button RedaktirMarka;
        private System.Windows.Forms.Button DeleteMarka;
        private System.Windows.Forms.Label Namel;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox textBoxMarkaName;
        private System.Windows.Forms.TextBox textBoxMarkaID;
        private System.Windows.Forms.Label NameRedakMarka;
        private System.Windows.Forms.Label IDredakMarka;
        private System.Windows.Forms.TextBox textBoxRedakMarkaName;
        private System.Windows.Forms.TextBox textBoxRedakMarkaID;
    }
}
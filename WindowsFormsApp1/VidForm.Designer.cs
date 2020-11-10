namespace WindowsFormsApp1
{
    partial class VidForm
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
            this.dataGridViewVid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet6 = new WindowsFormsApp1.SkladDataSet6();
            this.vidTableAdapter = new WindowsFormsApp1.SkladDataSet6TableAdapters.VidTableAdapter();
            this.DobavlenieVid = new System.Windows.Forms.Button();
            this.RedaktirVid = new System.Windows.Forms.Button();
            this.DeleteVid = new System.Windows.Forms.Button();
            this.textBoxVidName = new System.Windows.Forms.TextBox();
            this.Namel = new System.Windows.Forms.Label();
            this.NameRedakName = new System.Windows.Forms.Label();
            this.textBoxRedakVidName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVid
            // 
            this.dataGridViewVid.AutoGenerateColumns = false;
            this.dataGridViewVid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewVid.DataSource = this.vidBindingSource;
            this.dataGridViewVid.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewVid.Name = "dataGridViewVid";
            this.dataGridViewVid.RowHeadersVisible = false;
            this.dataGridViewVid.Size = new System.Drawing.Size(266, 227);
            this.dataGridViewVid.TabIndex = 0;
            this.dataGridViewVid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVid_CellClick);
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
            // vidBindingSource
            // 
            this.vidBindingSource.DataMember = "Vid";
            this.vidBindingSource.DataSource = this.skladDataSet6;
            // 
            // skladDataSet6
            // 
            this.skladDataSet6.DataSetName = "SkladDataSet6";
            this.skladDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vidTableAdapter
            // 
            this.vidTableAdapter.ClearBeforeFill = true;
            // 
            // DobavlenieVid
            // 
            this.DobavlenieVid.Location = new System.Drawing.Point(330, 163);
            this.DobavlenieVid.Name = "DobavlenieVid";
            this.DobavlenieVid.Size = new System.Drawing.Size(99, 36);
            this.DobavlenieVid.TabIndex = 10;
            this.DobavlenieVid.Text = "Добавление";
            this.DobavlenieVid.UseVisualStyleBackColor = true;
            this.DobavlenieVid.Click += new System.EventHandler(this.DobavlenieVid_Click);
            // 
            // RedaktirVid
            // 
            this.RedaktirVid.Location = new System.Drawing.Point(520, 160);
            this.RedaktirVid.Name = "RedaktirVid";
            this.RedaktirVid.Size = new System.Drawing.Size(99, 39);
            this.RedaktirVid.TabIndex = 9;
            this.RedaktirVid.Text = "Редактирование";
            this.RedaktirVid.UseVisualStyleBackColor = true;
            this.RedaktirVid.Click += new System.EventHandler(this.RedaktirVid_Click);
            // 
            // DeleteVid
            // 
            this.DeleteVid.Location = new System.Drawing.Point(520, 215);
            this.DeleteVid.Name = "DeleteVid";
            this.DeleteVid.Size = new System.Drawing.Size(99, 39);
            this.DeleteVid.TabIndex = 8;
            this.DeleteVid.Text = "Удаление";
            this.DeleteVid.UseVisualStyleBackColor = true;
            this.DeleteVid.Click += new System.EventHandler(this.DeleteVid_Click);
            // 
            // textBoxVidName
            // 
            this.textBoxVidName.Location = new System.Drawing.Point(330, 115);
            this.textBoxVidName.Name = "textBoxVidName";
            this.textBoxVidName.Size = new System.Drawing.Size(100, 20);
            this.textBoxVidName.TabIndex = 12;
            // 
            // Namel
            // 
            this.Namel.AutoSize = true;
            this.Namel.Location = new System.Drawing.Point(330, 96);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(83, 13);
            this.Namel.TabIndex = 14;
            this.Namel.Text = "Наименование";
            // 
            // NameRedakName
            // 
            this.NameRedakName.AutoSize = true;
            this.NameRedakName.Location = new System.Drawing.Point(520, 96);
            this.NameRedakName.Name = "NameRedakName";
            this.NameRedakName.Size = new System.Drawing.Size(83, 13);
            this.NameRedakName.TabIndex = 18;
            this.NameRedakName.Text = "Наименование";
            // 
            // textBoxRedakVidName
            // 
            this.textBoxRedakVidName.Location = new System.Drawing.Point(520, 115);
            this.textBoxRedakVidName.Name = "textBoxRedakVidName";
            this.textBoxRedakVidName.Size = new System.Drawing.Size(100, 20);
            this.textBoxRedakVidName.TabIndex = 16;
            // 
            // VidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameRedakName);
            this.Controls.Add(this.textBoxRedakVidName);
            this.Controls.Add(this.Namel);
            this.Controls.Add(this.textBoxVidName);
            this.Controls.Add(this.DobavlenieVid);
            this.Controls.Add(this.RedaktirVid);
            this.Controls.Add(this.DeleteVid);
            this.Controls.Add(this.dataGridViewVid);
            this.Name = "VidForm";
            this.Text = "Вид";
            this.Load += new System.EventHandler(this.VidForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVid;
        private SkladDataSet6 skladDataSet6;
        private System.Windows.Forms.BindingSource vidBindingSource;
        private SkladDataSet6TableAdapters.VidTableAdapter vidTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DobavlenieVid;
        private System.Windows.Forms.Button RedaktirVid;
        private System.Windows.Forms.Button DeleteVid;
        private System.Windows.Forms.TextBox textBoxVidName;
        private System.Windows.Forms.Label Namel;
        private System.Windows.Forms.Label NameRedakName;
        private System.Windows.Forms.TextBox textBoxRedakVidName;
    }
}
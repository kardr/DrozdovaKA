namespace WindowsFormsApp1
{
    partial class TransporForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteTransport = new System.Windows.Forms.Button();
            this.RedaktirTransport = new System.Windows.Forms.Button();
            this.dataGridViewTransport = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavchikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allTransport2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet9 = new WindowsFormsApp1.SkladDataSet9();
            this.allTransport2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet8 = new WindowsFormsApp1.SkladDataSet8();
            this.allTransportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet = new WindowsFormsApp1.SkladDataSet();
            this.DobavlenieTransport = new System.Windows.Forms.Button();
            this.all_TransportTableAdapter = new WindowsFormsApp1.SkladDataSetTableAdapters.All_TransportTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.all_Transport2TableAdapter = new WindowsFormsApp1.SkladDataSet8TableAdapters.All_Transport2TableAdapter();
            this.all_Transport2TableAdapter1 = new WindowsFormsApp1.SkladDataSet9TableAdapters.All_Transport2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTransport2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTransport2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTransportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-101, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeleteTransport
            // 
            this.DeleteTransport.Location = new System.Drawing.Point(667, 127);
            this.DeleteTransport.Name = "DeleteTransport";
            this.DeleteTransport.Size = new System.Drawing.Size(99, 39);
            this.DeleteTransport.TabIndex = 1;
            this.DeleteTransport.Text = "Удаление";
            this.DeleteTransport.UseVisualStyleBackColor = true;
            this.DeleteTransport.Click += new System.EventHandler(this.DeleteTransport_Click);
            // 
            // RedaktirTransport
            // 
            this.RedaktirTransport.Location = new System.Drawing.Point(667, 172);
            this.RedaktirTransport.Name = "RedaktirTransport";
            this.RedaktirTransport.Size = new System.Drawing.Size(99, 39);
            this.RedaktirTransport.TabIndex = 2;
            this.RedaktirTransport.Text = "Редактирование";
            this.RedaktirTransport.UseVisualStyleBackColor = true;
            this.RedaktirTransport.Click += new System.EventHandler(this.RedaktirTransport_Click);
            // 
            // dataGridViewTransport
            // 
            this.dataGridViewTransport.AutoGenerateColumns = false;
            this.dataGridViewTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.vidDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.postavchikDataGridViewTextBoxColumn,
            this.Mass,
            this.opisanieDataGridViewTextBoxColumn});
            this.dataGridViewTransport.DataSource = this.allTransport2BindingSource1;
            this.dataGridViewTransport.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewTransport.Name = "dataGridViewTransport";
            this.dataGridViewTransport.RowHeadersVisible = false;
            this.dataGridViewTransport.Size = new System.Drawing.Size(616, 250);
            this.dataGridViewTransport.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // vidDataGridViewTextBoxColumn
            // 
            this.vidDataGridViewTextBoxColumn.DataPropertyName = "Vid";
            this.vidDataGridViewTextBoxColumn.HeaderText = "Vid";
            this.vidDataGridViewTextBoxColumn.Name = "vidDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // postavchikDataGridViewTextBoxColumn
            // 
            this.postavchikDataGridViewTextBoxColumn.DataPropertyName = "Postavchik";
            this.postavchikDataGridViewTextBoxColumn.HeaderText = "Postavchik";
            this.postavchikDataGridViewTextBoxColumn.Name = "postavchikDataGridViewTextBoxColumn";
            // 
            // Mass
            // 
            this.Mass.DataPropertyName = "Mass";
            this.Mass.HeaderText = "Mass";
            this.Mass.Name = "Mass";
            // 
            // opisanieDataGridViewTextBoxColumn
            // 
            this.opisanieDataGridViewTextBoxColumn.DataPropertyName = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.HeaderText = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.Name = "opisanieDataGridViewTextBoxColumn";
            // 
            // allTransport2BindingSource1
            // 
            this.allTransport2BindingSource1.DataMember = "All_Transport2";
            this.allTransport2BindingSource1.DataSource = this.skladDataSet9;
            // 
            // skladDataSet9
            // 
            this.skladDataSet9.DataSetName = "SkladDataSet9";
            this.skladDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allTransport2BindingSource
            // 
            this.allTransport2BindingSource.DataMember = "All_Transport2";
            this.allTransport2BindingSource.DataSource = this.skladDataSet8;
            // 
            // skladDataSet8
            // 
            this.skladDataSet8.DataSetName = "SkladDataSet8";
            this.skladDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allTransportBindingSource
            // 
            this.allTransportBindingSource.DataMember = "All_Transport";
            this.allTransportBindingSource.DataSource = this.skladDataSet;
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "SkladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DobavlenieTransport
            // 
            this.DobavlenieTransport.Location = new System.Drawing.Point(667, 85);
            this.DobavlenieTransport.Name = "DobavlenieTransport";
            this.DobavlenieTransport.Size = new System.Drawing.Size(99, 36);
            this.DobavlenieTransport.TabIndex = 4;
            this.DobavlenieTransport.Text = "Добавление";
            this.DobavlenieTransport.UseVisualStyleBackColor = true;
            this.DobavlenieTransport.Click += new System.EventHandler(this.DobavlenieTransport_Click);
            // 
            // all_TransportTableAdapter
            // 
            this.all_TransportTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поставщикиToolStripMenuItem,
            this.видToolStripMenuItem,
            this.моделиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            this.видToolStripMenuItem.Click += new System.EventHandler(this.видToolStripMenuItem_Click);
            // 
            // моделиToolStripMenuItem
            // 
            this.моделиToolStripMenuItem.Name = "моделиToolStripMenuItem";
            this.моделиToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.моделиToolStripMenuItem.Text = "Марка";
            this.моделиToolStripMenuItem.Click += new System.EventHandler(this.моделиToolStripMenuItem_Click);
            // 
            // all_Transport2TableAdapter
            // 
            this.all_Transport2TableAdapter.ClearBeforeFill = true;
            // 
            // all_Transport2TableAdapter1
            // 
            this.all_Transport2TableAdapter1.ClearBeforeFill = true;
            // 
            // TransporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.DobavlenieTransport);
            this.Controls.Add(this.dataGridViewTransport);
            this.Controls.Add(this.RedaktirTransport);
            this.Controls.Add(this.DeleteTransport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TransporForm";
            this.Text = "Транспорт";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTransport2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTransport2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTransportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteTransport;
        private System.Windows.Forms.Button RedaktirTransport;
        private System.Windows.Forms.DataGridView dataGridViewTransport;
        private System.Windows.Forms.Button DobavlenieTransport;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource allTransportBindingSource;
        private SkladDataSetTableAdapters.All_TransportTableAdapter all_TransportTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделиToolStripMenuItem;
        private SkladDataSet8 skladDataSet8;
        private System.Windows.Forms.BindingSource allTransport2BindingSource;
        private SkladDataSet8TableAdapters.All_Transport2TableAdapter all_Transport2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavchikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private SkladDataSet9 skladDataSet9;
        private System.Windows.Forms.BindingSource allTransport2BindingSource1;
        private SkladDataSet9TableAdapters.All_Transport2TableAdapter all_Transport2TableAdapter1;
    }
}


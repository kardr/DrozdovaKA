namespace WindowsFormsApp1
{
    partial class TransportDialogForm
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
            this.comboBoxIDmarka = new System.Windows.Forms.ComboBox();
            this.markaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet3 = new WindowsFormsApp1.SkladDataSet3();
            this.comboBoxIDvid = new System.Windows.Forms.ComboBox();
            this.vidBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet2 = new WindowsFormsApp1.SkladDataSet2();
            this.comboBoxIDpostavchik = new System.Windows.Forms.ComboBox();
            this.postavchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet4 = new WindowsFormsApp1.SkladDataSet4();
            this.Vid = new System.Windows.Forms.Label();
            this.Marka = new System.Windows.Forms.Label();
            this.Postav = new System.Windows.Forms.Label();
            this.textBoxOpisanie = new System.Windows.Forms.TextBox();
            this.Opisanie = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.skladDataSet1 = new WindowsFormsApp1.SkladDataSet1();
            this.vidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vidTableAdapter = new WindowsFormsApp1.SkladDataSet1TableAdapters.VidTableAdapter();
            this.vidTableAdapter1 = new WindowsFormsApp1.SkladDataSet2TableAdapters.VidTableAdapter();
            this.markaTableAdapter = new WindowsFormsApp1.SkladDataSet3TableAdapters.MarkaTableAdapter();
            this.postavchikTableAdapter = new WindowsFormsApp1.SkladDataSet4TableAdapters.PostavchikTableAdapter();
            this.Mass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIDmarka
            // 
            this.comboBoxIDmarka.DataSource = this.markaBindingSource;
            this.comboBoxIDmarka.DisplayMember = "Name";
            this.comboBoxIDmarka.FormattingEnabled = true;
            this.comboBoxIDmarka.Location = new System.Drawing.Point(36, 105);
            this.comboBoxIDmarka.Name = "comboBoxIDmarka";
            this.comboBoxIDmarka.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIDmarka.TabIndex = 2;
            this.comboBoxIDmarka.ValueMember = "Id";
            // 
            // markaBindingSource
            // 
            this.markaBindingSource.DataMember = "Marka";
            this.markaBindingSource.DataSource = this.skladDataSet3;
            // 
            // skladDataSet3
            // 
            this.skladDataSet3.DataSetName = "SkladDataSet3";
            this.skladDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxIDvid
            // 
            this.comboBoxIDvid.DataSource = this.vidBindingSource1;
            this.comboBoxIDvid.DisplayMember = "Name";
            this.comboBoxIDvid.FormattingEnabled = true;
            this.comboBoxIDvid.Location = new System.Drawing.Point(36, 57);
            this.comboBoxIDvid.Name = "comboBoxIDvid";
            this.comboBoxIDvid.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIDvid.TabIndex = 3;
            this.comboBoxIDvid.ValueMember = "Id";
            // 
            // vidBindingSource1
            // 
            this.vidBindingSource1.DataMember = "Vid";
            this.vidBindingSource1.DataSource = this.skladDataSet2;
            // 
            // skladDataSet2
            // 
            this.skladDataSet2.DataSetName = "SkladDataSet2";
            this.skladDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxIDpostavchik
            // 
            this.comboBoxIDpostavchik.DataSource = this.postavchikBindingSource;
            this.comboBoxIDpostavchik.DisplayMember = "Name";
            this.comboBoxIDpostavchik.FormattingEnabled = true;
            this.comboBoxIDpostavchik.Location = new System.Drawing.Point(36, 161);
            this.comboBoxIDpostavchik.Name = "comboBoxIDpostavchik";
            this.comboBoxIDpostavchik.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIDpostavchik.TabIndex = 4;
            this.comboBoxIDpostavchik.ValueMember = "Id";
            // 
            // postavchikBindingSource
            // 
            this.postavchikBindingSource.DataMember = "Postavchik";
            this.postavchikBindingSource.DataSource = this.skladDataSet4;
            // 
            // skladDataSet4
            // 
            this.skladDataSet4.DataSetName = "SkladDataSet4";
            this.skladDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Vid
            // 
            this.Vid.AutoSize = true;
            this.Vid.Location = new System.Drawing.Point(36, 41);
            this.Vid.Name = "Vid";
            this.Vid.Size = new System.Drawing.Size(26, 13);
            this.Vid.TabIndex = 5;
            this.Vid.Text = "Вид";
            // 
            // Marka
            // 
            this.Marka.AutoSize = true;
            this.Marka.Location = new System.Drawing.Point(36, 89);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(40, 13);
            this.Marka.TabIndex = 6;
            this.Marka.Text = "Марка";
            // 
            // Postav
            // 
            this.Postav.AutoSize = true;
            this.Postav.Location = new System.Drawing.Point(33, 145);
            this.Postav.Name = "Postav";
            this.Postav.Size = new System.Drawing.Size(65, 13);
            this.Postav.TabIndex = 7;
            this.Postav.Text = "Поставщик";
            // 
            // textBoxOpisanie
            // 
            this.textBoxOpisanie.Location = new System.Drawing.Point(36, 269);
            this.textBoxOpisanie.Multiline = true;
            this.textBoxOpisanie.Name = "textBoxOpisanie";
            this.textBoxOpisanie.Size = new System.Drawing.Size(163, 134);
            this.textBoxOpisanie.TabIndex = 8;
            // 
            // Opisanie
            // 
            this.Opisanie.AutoSize = true;
            this.Opisanie.Location = new System.Drawing.Point(45, 253);
            this.Opisanie.Name = "Opisanie";
            this.Opisanie.Size = new System.Drawing.Size(57, 13);
            this.Opisanie.TabIndex = 9;
            this.Opisanie.Text = "Описание";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(224, 291);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(224, 330);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // skladDataSet1
            // 
            this.skladDataSet1.DataSetName = "SkladDataSet1";
            this.skladDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vidBindingSource
            // 
            this.vidBindingSource.DataMember = "Vid";
            this.vidBindingSource.DataSource = this.skladDataSet1;
            // 
            // vidTableAdapter
            // 
            this.vidTableAdapter.ClearBeforeFill = true;
            // 
            // vidTableAdapter1
            // 
            this.vidTableAdapter1.ClearBeforeFill = true;
            // 
            // markaTableAdapter
            // 
            this.markaTableAdapter.ClearBeforeFill = true;
            // 
            // postavchikTableAdapter
            // 
            this.postavchikTableAdapter.ClearBeforeFill = true;
            // 
            // Mass
            // 
            this.Mass.AutoSize = true;
            this.Mass.Location = new System.Drawing.Point(36, 200);
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(32, 13);
            this.Mass.TabIndex = 15;
            this.Mass.Text = "Mass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(36, 217);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(121, 20);
            this.textBoxMass.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Visible = false;
            // 
            // TransportDialogForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(410, 433);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMass);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.Opisanie);
            this.Controls.Add(this.textBoxOpisanie);
            this.Controls.Add(this.Postav);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.Vid);
            this.Controls.Add(this.comboBoxIDpostavchik);
            this.Controls.Add(this.comboBoxIDvid);
            this.Controls.Add(this.comboBoxIDmarka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TransportDialogForm";
            this.Text = "Добавление транспорта";
            this.Load += new System.EventHandler(this.TransportDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SkladDataSet1 skladDataSet1;
        private System.Windows.Forms.BindingSource vidBindingSource;
        private SkladDataSet1TableAdapters.VidTableAdapter vidTableAdapter;
        private SkladDataSet2 skladDataSet2;
        private System.Windows.Forms.BindingSource vidBindingSource1;
        private SkladDataSet2TableAdapters.VidTableAdapter vidTableAdapter1;
        private SkladDataSet3 skladDataSet3;
        private System.Windows.Forms.BindingSource markaBindingSource;
        private SkladDataSet3TableAdapters.MarkaTableAdapter markaTableAdapter;
        private SkladDataSet4 skladDataSet4;
        private System.Windows.Forms.BindingSource postavchikBindingSource;
        private SkladDataSet4TableAdapters.PostavchikTableAdapter postavchikTableAdapter;
        public System.Windows.Forms.ComboBox comboBoxIDmarka;
        public System.Windows.Forms.ComboBox comboBoxIDvid;
        public System.Windows.Forms.ComboBox comboBoxIDpostavchik;
        public System.Windows.Forms.Label Vid;
        public System.Windows.Forms.Label Marka;
        public System.Windows.Forms.Label Postav;
        public System.Windows.Forms.TextBox textBoxOpisanie;
        public System.Windows.Forms.Label Opisanie;
        public System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label Mass;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxMass;
        public System.Windows.Forms.TextBox textBox1;
    }
}
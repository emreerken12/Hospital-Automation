namespace ElifUygunHastane
{
    partial class AdminRandevuDoktor
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastasoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastatcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevutarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elifUygunHastaneDataSet2 = new ElifUygunHastane.ElifUygunHastaneDataSet2();
            this.randevularTableAdapter = new ElifUygunHastane.ElifUygunHastaneDataSet2TableAdapters.RandevularTableAdapter();
            this.elifUygunHastaneDataSet3 = new ElifUygunHastane.ElifUygunHastaneDataSet3();
            this.doktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doktorlarTableAdapter = new ElifUygunHastane.ElifUygunHastaneDataSet3TableAdapters.DoktorlarTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctortcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctortitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elifUygunHastaneDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elifUygunHastaneDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(103, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Doktor Ata";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hasta Tc";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(103, 40);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doktor ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.hastaadiDataGridViewTextBoxColumn,
            this.hastasoyadiDataGridViewTextBoxColumn,
            this.hastatcDataGridViewTextBoxColumn,
            this.randevutarihDataGridViewTextBoxColumn,
            this.doktorIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.randevularBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 120);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 162);
            this.dataGridView1.TabIndex = 10;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaadiDataGridViewTextBoxColumn
            // 
            this.hastaadiDataGridViewTextBoxColumn.DataPropertyName = "hastaadi";
            this.hastaadiDataGridViewTextBoxColumn.HeaderText = "hastaadi";
            this.hastaadiDataGridViewTextBoxColumn.Name = "hastaadiDataGridViewTextBoxColumn";
            // 
            // hastasoyadiDataGridViewTextBoxColumn
            // 
            this.hastasoyadiDataGridViewTextBoxColumn.DataPropertyName = "hastasoyadi";
            this.hastasoyadiDataGridViewTextBoxColumn.HeaderText = "hastasoyadi";
            this.hastasoyadiDataGridViewTextBoxColumn.Name = "hastasoyadiDataGridViewTextBoxColumn";
            // 
            // hastatcDataGridViewTextBoxColumn
            // 
            this.hastatcDataGridViewTextBoxColumn.DataPropertyName = "hastatc";
            this.hastatcDataGridViewTextBoxColumn.HeaderText = "hastatc";
            this.hastatcDataGridViewTextBoxColumn.Name = "hastatcDataGridViewTextBoxColumn";
            // 
            // randevutarihDataGridViewTextBoxColumn
            // 
            this.randevutarihDataGridViewTextBoxColumn.DataPropertyName = "randevutarih";
            this.randevutarihDataGridViewTextBoxColumn.HeaderText = "randevutarih";
            this.randevutarihDataGridViewTextBoxColumn.Name = "randevutarihDataGridViewTextBoxColumn";
            // 
            // doktorIdDataGridViewTextBoxColumn
            // 
            this.doktorIdDataGridViewTextBoxColumn.DataPropertyName = "DoktorId";
            this.doktorIdDataGridViewTextBoxColumn.HeaderText = "DoktorId";
            this.doktorIdDataGridViewTextBoxColumn.Name = "doktorIdDataGridViewTextBoxColumn";
            // 
            // randevularBindingSource
            // 
            this.randevularBindingSource.DataMember = "Randevular";
            this.randevularBindingSource.DataSource = this.elifUygunHastaneDataSet2;
            // 
            // elifUygunHastaneDataSet2
            // 
            this.elifUygunHastaneDataSet2.DataSetName = "ElifUygunHastaneDataSet2";
            this.elifUygunHastaneDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevularTableAdapter
            // 
            this.randevularTableAdapter.ClearBeforeFill = true;
            // 
            // elifUygunHastaneDataSet3
            // 
            this.elifUygunHastaneDataSet3.DataSetName = "ElifUygunHastaneDataSet3";
            this.elifUygunHastaneDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorlarBindingSource
            // 
            this.doktorlarBindingSource.DataMember = "Doktorlar";
            this.doktorlarBindingSource.DataSource = this.elifUygunHastaneDataSet3;
            // 
            // doktorlarTableAdapter
            // 
            this.doktorlarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn1,
            this.doctornameDataGridViewTextBoxColumn,
            this.doctorsnameDataGridViewTextBoxColumn,
            this.doctortcDataGridViewTextBoxColumn,
            this.doctortitleDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.doktorlarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(28, 310);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(782, 162);
            this.dataGridView2.TabIndex = 11;
            // 
            // ıdDataGridViewTextBoxColumn1
            // 
            this.ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            this.ıdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // doctornameDataGridViewTextBoxColumn
            // 
            this.doctornameDataGridViewTextBoxColumn.DataPropertyName = "doctorname";
            this.doctornameDataGridViewTextBoxColumn.HeaderText = "doctorname";
            this.doctornameDataGridViewTextBoxColumn.Name = "doctornameDataGridViewTextBoxColumn";
            // 
            // doctorsnameDataGridViewTextBoxColumn
            // 
            this.doctorsnameDataGridViewTextBoxColumn.DataPropertyName = "doctorsname";
            this.doctorsnameDataGridViewTextBoxColumn.HeaderText = "doctorsname";
            this.doctorsnameDataGridViewTextBoxColumn.Name = "doctorsnameDataGridViewTextBoxColumn";
            // 
            // doctortcDataGridViewTextBoxColumn
            // 
            this.doctortcDataGridViewTextBoxColumn.DataPropertyName = "doctortc";
            this.doctortcDataGridViewTextBoxColumn.HeaderText = "doctortc";
            this.doctortcDataGridViewTextBoxColumn.Name = "doctortcDataGridViewTextBoxColumn";
            // 
            // doctortitleDataGridViewTextBoxColumn
            // 
            this.doctortitleDataGridViewTextBoxColumn.DataPropertyName = "doctortitle";
            this.doctortitleDataGridViewTextBoxColumn.HeaderText = "doctortitle";
            this.doctortitleDataGridViewTextBoxColumn.Name = "doctortitleDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(838, 447);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "ADMİN PANELE DÖN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminRandevuDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1007, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminRandevuDoktor";
            this.Text = "AdminRandevuDoktor";
            this.Load += new System.EventHandler(this.AdminRandevuDoktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elifUygunHastaneDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elifUygunHastaneDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ElifUygunHastaneDataSet2 elifUygunHastaneDataSet2;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private ElifUygunHastaneDataSet2TableAdapters.RandevularTableAdapter randevularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastasoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastatcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevutarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIdDataGridViewTextBoxColumn;
        private ElifUygunHastaneDataSet3 elifUygunHastaneDataSet3;
        private System.Windows.Forms.BindingSource doktorlarBindingSource;
        private ElifUygunHastaneDataSet3TableAdapters.DoktorlarTableAdapter doktorlarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctortcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctortitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}
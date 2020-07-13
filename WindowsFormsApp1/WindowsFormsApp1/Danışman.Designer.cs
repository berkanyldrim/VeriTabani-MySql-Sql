namespace WindowsFormsApp1
{
    partial class Danışman
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.danısmanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsaglarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danışmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odev3DataSet5 = new WindowsFormsApp1.odev3DataSet5();
            this.odev3DataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odev3DataSet3 = new WindowsFormsApp1.odev3DataSet3();
            this.danışmanTableAdapter = new WindowsFormsApp1.odev3DataSet5TableAdapters.DanışmanTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danışmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev3DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev3DataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev3DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİLER";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(710, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 26);
            this.button4.TabIndex = 16;
            this.button4.Text = "ARAMA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "GÜNCELLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "d_saglar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "danısman_id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.danısmanidDataGridViewTextBoxColumn,
            this.dsaglarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.danışmanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 240);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // danısmanidDataGridViewTextBoxColumn
            // 
            this.danısmanidDataGridViewTextBoxColumn.DataPropertyName = "danısman_id";
            this.danısmanidDataGridViewTextBoxColumn.HeaderText = "danısman_id";
            this.danısmanidDataGridViewTextBoxColumn.Name = "danısmanidDataGridViewTextBoxColumn";
            // 
            // dsaglarDataGridViewTextBoxColumn
            // 
            this.dsaglarDataGridViewTextBoxColumn.DataPropertyName = "d_saglar";
            this.dsaglarDataGridViewTextBoxColumn.HeaderText = "d_saglar";
            this.dsaglarDataGridViewTextBoxColumn.Name = "dsaglarDataGridViewTextBoxColumn";
            // 
            // danışmanBindingSource
            // 
            this.danışmanBindingSource.DataMember = "Danışman";
            this.danışmanBindingSource.DataSource = this.odev3DataSet5;
            // 
            // odev3DataSet5
            // 
            this.odev3DataSet5.DataSetName = "odev3DataSet5";
            this.odev3DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odev3DataSet3BindingSource
            // 
            this.odev3DataSet3BindingSource.DataSource = this.odev3DataSet3;
            this.odev3DataSet3BindingSource.Position = 0;
            // 
            // odev3DataSet3
            // 
            this.odev3DataSet3.DataSetName = "odev3DataSet3";
            this.odev3DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danışmanTableAdapter
            // 
            this.danışmanTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Aranacak Danısman ID:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(514, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 20);
            this.textBox3.TabIndex = 18;
            // 
            // Danışman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Danışman";
            this.Text = "Danışman";
            this.Load += new System.EventHandler(this.Danışman_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danışmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev3DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev3DataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev3DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource odev3DataSet3BindingSource;
        private odev3DataSet3 odev3DataSet3;
        private odev3DataSet5 odev3DataSet5;
        private System.Windows.Forms.BindingSource danışmanBindingSource;
        private odev3DataSet5TableAdapters.DanışmanTableAdapter danışmanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn danısmanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsaglarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}
namespace Form_kebab.MenuForm
{
    partial class FormCooking
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.блюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDataKebabDataSet1 = new Form_kebab.BaseDataKebabDataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.готовыеБлюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDataKebabDataSet2 = new Form_kebab.BaseDataKebabDataSet2();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.названиеDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рецептBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDataKebabDataSet3 = new Form_kebab.BaseDataKebabDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.рецептTableAdapter = new Form_kebab.BaseDataKebabDataSet3TableAdapters.РецептTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.блюдаTableAdapter = new Form_kebab.BaseDataKebabDataSet1TableAdapters.БлюдаTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.готовые_БлюдаTableAdapter = new Form_kebab.BaseDataKebabDataSet2TableAdapters.Готовые_БлюдаTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataKebabDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.готовыеБлюдаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataKebabDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataKebabDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.блюдаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(149, 138);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // блюдаBindingSource
            // 
            this.блюдаBindingSource.DataMember = "Блюда";
            this.блюдаBindingSource.DataSource = this.baseDataKebabDataSet1;
            // 
            // baseDataKebabDataSet1
            // 
            this.baseDataKebabDataSet1.DataSetName = "BaseDataKebabDataSet1";
            this.baseDataKebabDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.готовыеБлюдаBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(183, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(150, 138);
            this.dataGridView2.TabIndex = 1;
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            // 
            // готовыеБлюдаBindingSource
            // 
            this.готовыеБлюдаBindingSource.DataMember = "Готовые Блюда";
            this.готовыеБлюдаBindingSource.DataSource = this.baseDataKebabDataSet2;
            // 
            // baseDataKebabDataSet2
            // 
            this.baseDataKebabDataSet2.DataSetName = "BaseDataKebabDataSet2";
            this.baseDataKebabDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеDataGridViewTextBoxColumn2,
            this.продуктыDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.рецептBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 211);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(330, 138);
            this.dataGridView3.TabIndex = 2;
            // 
            // названиеDataGridViewTextBoxColumn2
            // 
            this.названиеDataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn2.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn2.Name = "названиеDataGridViewTextBoxColumn2";
            // 
            // продуктыDataGridViewTextBoxColumn
            // 
            this.продуктыDataGridViewTextBoxColumn.DataPropertyName = "Продукты";
            this.продуктыDataGridViewTextBoxColumn.HeaderText = "Продукты";
            this.продуктыDataGridViewTextBoxColumn.Name = "продуктыDataGridViewTextBoxColumn";
            // 
            // рецептBindingSource
            // 
            this.рецептBindingSource.DataMember = "Рецепт";
            this.рецептBindingSource.DataSource = this.baseDataKebabDataSet3;
            // 
            // baseDataKebabDataSet3
            // 
            this.baseDataKebabDataSet3.DataSetName = "BaseDataKebabDataSet3";
            this.baseDataKebabDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Блюдо";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Готовые блюда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Рецепт блюд";
            // 
            // рецептTableAdapter
            // 
            this.рецептTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить блюдо";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // блюдаTableAdapter
            // 
            this.блюдаTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Списать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(507, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Приготовить блюдо";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // готовые_БлюдаTableAdapter
            // 
            this.готовые_БлюдаTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(507, 170);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Рецепт";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormCooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 361);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCooking";
            this.Text = "FormCooking";
            this.Load += new System.EventHandler(this.FormCooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataKebabDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.готовыеБлюдаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataKebabDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataKebabDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public BaseDataKebabDataSet1 baseDataKebabDataSet1;
        private System.Windows.Forms.BindingSource блюдаBindingSource;
        public BaseDataKebabDataSet1TableAdapters.БлюдаTableAdapter блюдаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        public BaseDataKebabDataSet3 baseDataKebabDataSet3;
        private System.Windows.Forms.BindingSource рецептBindingSource;
        private BaseDataKebabDataSet3TableAdapters.РецептTableAdapter рецептTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn продуктыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private BaseDataKebabDataSet2 baseDataKebabDataSet2;
        private BaseDataKebabDataSet2TableAdapters.Готовые_БлюдаTableAdapter готовые_БлюдаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource готовыеБлюдаBindingSource;
        private System.Windows.Forms.Button button6;
    }
}
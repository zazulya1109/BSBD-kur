namespace DriverSchoool
{
    partial class FormRB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRB));
            this.driverSchoolDataSet = new DriverSchoool.driverSchoolDataSet();
            this.учебный_отделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учебный_отделTableAdapter = new DriverSchoool.driverSchoolDataSetTableAdapters.Учебный_отделTableAdapter();
            this.tableAdapterManager = new DriverSchoool.driverSchoolDataSetTableAdapters.TableAdapterManager();
            this.учебный_отделBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.учебный_отделDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.driverSchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_отделBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_отделBindingNavigator)).BeginInit();
            this.учебный_отделBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_отделDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // driverSchoolDataSet
            // 
            this.driverSchoolDataSet.DataSetName = "driverSchoolDataSet";
            this.driverSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учебный_отделBindingSource
            // 
            this.учебный_отделBindingSource.DataMember = "Учебный_отдел";
            this.учебный_отделBindingSource.DataSource = this.driverSchoolDataSet;
            // 
            // учебный_отделTableAdapter
            // 
            this.учебный_отделTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DriverSchoool.driverSchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппаTableAdapter = null;
            this.tableAdapterManager.ЗаявлениеTableAdapter = null;
            this.tableAdapterManager.Учебный_отделTableAdapter = this.учебный_отделTableAdapter;
            this.tableAdapterManager.УченикTableAdapter = null;
            // 
            // учебный_отделBindingNavigator
            // 
            this.учебный_отделBindingNavigator.AddNewItem = null;
            this.учебный_отделBindingNavigator.BindingSource = this.учебный_отделBindingSource;
            this.учебный_отделBindingNavigator.CountItem = null;
            this.учебный_отделBindingNavigator.DeleteItem = null;
            this.учебный_отделBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.учебный_отделBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.учебный_отделBindingNavigator.MoveFirstItem = null;
            this.учебный_отделBindingNavigator.MoveLastItem = null;
            this.учебный_отделBindingNavigator.MoveNextItem = null;
            this.учебный_отделBindingNavigator.MovePreviousItem = null;
            this.учебный_отделBindingNavigator.Name = "учебный_отделBindingNavigator";
            this.учебный_отделBindingNavigator.PositionItem = null;
            this.учебный_отделBindingNavigator.Size = new System.Drawing.Size(875, 25);
            this.учебный_отделBindingNavigator.TabIndex = 0;
            this.учебный_отделBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // учебный_отделDataGridView
            // 
            this.учебный_отделDataGridView.AutoGenerateColumns = false;
            this.учебный_отделDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.учебный_отделDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.учебный_отделDataGridView.DataSource = this.учебный_отделBindingSource;
            this.учебный_отделDataGridView.Location = new System.Drawing.Point(12, 37);
            this.учебный_отделDataGridView.Name = "учебный_отделDataGridView";
            this.учебный_отделDataGridView.Size = new System.Drawing.Size(852, 401);
            this.учебный_отделDataGridView.TabIndex = 1;
            this.учебный_отделDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.учебный_отделDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_Работник";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_Работник";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn5.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn6.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Возраст";
            this.dataGridViewTextBoxColumn7.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn9.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(188, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Фильтр";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::DriverSchoool.Properties.Resources.icons8_поиск_128;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Поиск";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FormRB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.учебный_отделDataGridView);
            this.Controls.Add(this.учебный_отделBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRB";
            this.Text = "Список работников";
            this.Load += new System.EventHandler(this.FormRB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverSchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_отделBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_отделBindingNavigator)).EndInit();
            this.учебный_отделBindingNavigator.ResumeLayout(false);
            this.учебный_отделBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_отделDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private driverSchoolDataSet driverSchoolDataSet;
        private System.Windows.Forms.BindingSource учебный_отделBindingSource;
        private driverSchoolDataSetTableAdapters.Учебный_отделTableAdapter учебный_отделTableAdapter;
        private driverSchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator учебный_отделBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.DataGridView учебный_отделDataGridView;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
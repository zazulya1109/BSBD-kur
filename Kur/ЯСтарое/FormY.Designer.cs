namespace DriverSchoool
{
    partial class FormY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormY));
            this.driverSchoolDataSet = new DriverSchoool.driverSchoolDataSet();
            this.ученикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ученикTableAdapter = new DriverSchoool.driverSchoolDataSetTableAdapters.УченикTableAdapter();
            this.tableAdapterManager = new DriverSchoool.driverSchoolDataSetTableAdapters.TableAdapterManager();
            this.ученикBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ученикDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.driverSchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикBindingNavigator)).BeginInit();
            this.ученикBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ученикDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // driverSchoolDataSet
            // 
            this.driverSchoolDataSet.DataSetName = "driverSchoolDataSet";
            this.driverSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ученикBindingSource
            // 
            this.ученикBindingSource.DataMember = "Ученик";
            this.ученикBindingSource.DataSource = this.driverSchoolDataSet;
            // 
            // ученикTableAdapter
            // 
            this.ученикTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DriverSchoool.driverSchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппаTableAdapter = null;
            this.tableAdapterManager.ЗаявлениеTableAdapter = null;
            this.tableAdapterManager.Учебный_отделTableAdapter = null;
            this.tableAdapterManager.УченикTableAdapter = this.ученикTableAdapter;
            // 
            // ученикBindingNavigator
            // 
            this.ученикBindingNavigator.AddNewItem = null;
            this.ученикBindingNavigator.BindingSource = this.ученикBindingSource;
            this.ученикBindingNavigator.CountItem = null;
            this.ученикBindingNavigator.DeleteItem = null;
            this.ученикBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.ученикBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ученикBindingNavigator.MoveFirstItem = null;
            this.ученикBindingNavigator.MoveLastItem = null;
            this.ученикBindingNavigator.MoveNextItem = null;
            this.ученикBindingNavigator.MovePreviousItem = null;
            this.ученикBindingNavigator.Name = "ученикBindingNavigator";
            this.ученикBindingNavigator.PositionItem = null;
            this.ученикBindingNavigator.Size = new System.Drawing.Size(877, 25);
            this.ученикBindingNavigator.TabIndex = 0;
            this.ученикBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ученикDataGridView
            // 
            this.ученикDataGridView.AutoGenerateColumns = false;
            this.ученикDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ученикDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.ученикDataGridView.DataSource = this.ученикBindingSource;
            this.ученикDataGridView.Location = new System.Drawing.Point(12, 28);
            this.ученикDataGridView.Name = "ученикDataGridView";
            this.ученикDataGridView.Size = new System.Drawing.Size(853, 464);
            this.ученикDataGridView.TabIndex = 1;
            this.ученикDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ученикDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_Ученика";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_Ученика";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn5.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Возраст";
            this.dataGridViewTextBoxColumn6.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn9.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn10.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
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
            this.checkBox1.Location = new System.Drawing.Point(185, 5);
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
            // FormY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 504);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ученикDataGridView);
            this.Controls.Add(this.ученикBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormY";
            this.Text = "Список учеников";
            this.Load += new System.EventHandler(this.FormY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverSchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикBindingNavigator)).EndInit();
            this.ученикBindingNavigator.ResumeLayout(false);
            this.ученикBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ученикDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private driverSchoolDataSet driverSchoolDataSet;
        private System.Windows.Forms.BindingSource ученикBindingSource;
        private driverSchoolDataSetTableAdapters.УченикTableAdapter ученикTableAdapter;
        private driverSchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ученикBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView ученикDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
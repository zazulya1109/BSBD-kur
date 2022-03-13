namespace DriverSchoool.общага
{
    partial class DNob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNob));
            this.ne_nadoDataSet = new DriverSchoool.ne_nadoDataSet();
            this.общежитиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.общежитиеTableAdapter = new DriverSchoool.ne_nadoDataSetTableAdapters.ОбщежитиеTableAdapter();
            this.tableAdapterManager = new DriverSchoool.ne_nadoDataSetTableAdapters.TableAdapterManager();
            this.общежитиеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.общежитиеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.общежитиеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ne_nadoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеBindingNavigator)).BeginInit();
            this.общежитиеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ne_nadoDataSet
            // 
            this.ne_nadoDataSet.DataSetName = "ne_nadoDataSet";
            this.ne_nadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // общежитиеBindingSource
            // 
            this.общежитиеBindingSource.DataMember = "Общежитие";
            this.общежитиеBindingSource.DataSource = this.ne_nadoDataSet;
            // 
            // общежитиеTableAdapter
            // 
            this.общежитиеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DriverSchoool.ne_nadoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Заселенный_студентTableAdapter = null;
            this.tableAdapterManager.ЗаявлениеTableAdapter = null;
            this.tableAdapterManager.КомнатаTableAdapter = null;
            this.tableAdapterManager.ОбщежитиеTableAdapter = this.общежитиеTableAdapter;
            this.tableAdapterManager.РаспоряжениеTableAdapter = null;
            this.tableAdapterManager.СтудентTableAdapter = null;
            // 
            // общежитиеBindingNavigator
            // 
            this.общежитиеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.общежитиеBindingNavigator.BindingSource = this.общежитиеBindingSource;
            this.общежитиеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.общежитиеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.общежитиеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.общежитиеBindingNavigatorSaveItem});
            this.общежитиеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.общежитиеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.общежитиеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.общежитиеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.общежитиеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.общежитиеBindingNavigator.Name = "общежитиеBindingNavigator";
            this.общежитиеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.общежитиеBindingNavigator.Size = new System.Drawing.Size(331, 25);
            this.общежитиеBindingNavigator.TabIndex = 0;
            this.общежитиеBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // общежитиеBindingNavigatorSaveItem
            // 
            this.общежитиеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.общежитиеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("общежитиеBindingNavigatorSaveItem.Image")));
            this.общежитиеBindingNavigatorSaveItem.Name = "общежитиеBindingNavigatorSaveItem";
            this.общежитиеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.общежитиеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.общежитиеBindingNavigatorSaveItem.Click += new System.EventHandler(this.общежитиеBindingNavigatorSaveItem_Click);
            // 
            // общежитиеDataGridView
            // 
            this.общежитиеDataGridView.AutoGenerateColumns = false;
            this.общежитиеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.общежитиеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.общежитиеDataGridView.DataSource = this.общежитиеBindingSource;
            this.общежитиеDataGridView.Location = new System.Drawing.Point(12, 48);
            this.общежитиеDataGridView.Name = "общежитиеDataGridView";
            this.общежитиеDataGridView.Size = new System.Drawing.Size(243, 171);
            this.общежитиеDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Общежитие";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Общежитие";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn2.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // DNob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 231);
            this.Controls.Add(this.общежитиеDataGridView);
            this.Controls.Add(this.общежитиеBindingNavigator);
            this.Name = "DNob";
            this.Text = "Данные общежития";
            this.Load += new System.EventHandler(this.DNob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ne_nadoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеBindingNavigator)).EndInit();
            this.общежитиеBindingNavigator.ResumeLayout(false);
            this.общежитиеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ne_nadoDataSet ne_nadoDataSet;
        private System.Windows.Forms.BindingSource общежитиеBindingSource;
        private ne_nadoDataSetTableAdapters.ОбщежитиеTableAdapter общежитиеTableAdapter;
        private ne_nadoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator общежитиеBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton общежитиеBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView общежитиеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
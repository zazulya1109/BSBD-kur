namespace DriverSchoool.Распоряжение
{
    partial class DNRaspore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNRaspore));
            this.ne_nadoDataSet = new DriverSchoool.ne_nadoDataSet();
            this.распоряжениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.распоряжениеTableAdapter = new DriverSchoool.ne_nadoDataSetTableAdapters.РаспоряжениеTableAdapter();
            this.tableAdapterManager = new DriverSchoool.ne_nadoDataSetTableAdapters.TableAdapterManager();
            this.распоряжениеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.распоряжениеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.распоряжениеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ne_nadoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.распоряжениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.распоряжениеBindingNavigator)).BeginInit();
            this.распоряжениеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.распоряжениеDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ne_nadoDataSet
            // 
            this.ne_nadoDataSet.DataSetName = "ne_nadoDataSet";
            this.ne_nadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // распоряжениеBindingSource
            // 
            this.распоряжениеBindingSource.DataMember = "Распоряжение";
            this.распоряжениеBindingSource.DataSource = this.ne_nadoDataSet;
            // 
            // распоряжениеTableAdapter
            // 
            this.распоряжениеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DriverSchoool.ne_nadoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Заселенный_студентTableAdapter = null;
            this.tableAdapterManager.ЗаявлениеTableAdapter = null;
            this.tableAdapterManager.КомнатаTableAdapter = null;
            this.tableAdapterManager.ОбщежитиеTableAdapter = null;
            this.tableAdapterManager.РаспоряжениеTableAdapter = this.распоряжениеTableAdapter;
            this.tableAdapterManager.СтудентTableAdapter = null;
            // 
            // распоряжениеBindingNavigator
            // 
            this.распоряжениеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.распоряжениеBindingNavigator.BindingSource = this.распоряжениеBindingSource;
            this.распоряжениеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.распоряжениеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.распоряжениеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.распоряжениеBindingNavigatorSaveItem});
            this.распоряжениеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.распоряжениеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.распоряжениеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.распоряжениеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.распоряжениеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.распоряжениеBindingNavigator.Name = "распоряжениеBindingNavigator";
            this.распоряжениеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.распоряжениеBindingNavigator.Size = new System.Drawing.Size(572, 25);
            this.распоряжениеBindingNavigator.TabIndex = 0;
            this.распоряжениеBindingNavigator.Text = "bindingNavigator1";
            this.распоряжениеBindingNavigator.RefreshItems += new System.EventHandler(this.распоряжениеBindingNavigator_RefreshItems);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // распоряжениеBindingNavigatorSaveItem
            // 
            this.распоряжениеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.распоряжениеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("распоряжениеBindingNavigatorSaveItem.Image")));
            this.распоряжениеBindingNavigatorSaveItem.Name = "распоряжениеBindingNavigatorSaveItem";
            this.распоряжениеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.распоряжениеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.распоряжениеBindingNavigatorSaveItem.Click += new System.EventHandler(this.распоряжениеBindingNavigatorSaveItem_Click);
            // 
            // распоряжениеDataGridView
            // 
            this.распоряжениеDataGridView.AutoGenerateColumns = false;
            this.распоряжениеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.распоряжениеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.распоряжениеDataGridView.DataSource = this.распоряжениеBindingSource;
            this.распоряжениеDataGridView.Location = new System.Drawing.Point(0, 28);
            this.распоряжениеDataGridView.Name = "распоряжениеDataGridView";
            this.распоряжениеDataGridView.Size = new System.Drawing.Size(544, 307);
            this.распоряжениеDataGridView.TabIndex = 1;
            this.распоряжениеDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.распоряжениеDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Распоряжение";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Распоряжение";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Заявление";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Заявление";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_заселения";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_заселения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата_выселения";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата_выселения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // DNRaspore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.распоряжениеDataGridView);
            this.Controls.Add(this.распоряжениеBindingNavigator);
            this.Name = "DNRaspore";
            this.Text = "Распоряжение";
            this.Load += new System.EventHandler(this.DNRaspore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ne_nadoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.распоряжениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.распоряжениеBindingNavigator)).EndInit();
            this.распоряжениеBindingNavigator.ResumeLayout(false);
            this.распоряжениеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.распоряжениеDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ne_nadoDataSet ne_nadoDataSet;
        private System.Windows.Forms.BindingSource распоряжениеBindingSource;
        private ne_nadoDataSetTableAdapters.РаспоряжениеTableAdapter распоряжениеTableAdapter;
        private ne_nadoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator распоряжениеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton распоряжениеBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView распоряжениеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
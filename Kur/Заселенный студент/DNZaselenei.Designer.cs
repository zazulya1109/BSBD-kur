namespace DriverSchoool.Заселенный_студент
{
    partial class DNZaselenei
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
            System.Windows.Forms.Label id_СтудентLabel;
            System.Windows.Forms.Label id_РаспоряжениеLabel;
            System.Windows.Forms.Label id_КомнатаLabel;
            System.Windows.Forms.Label заселенный_студентLabel;
            System.Windows.Forms.Label фИОLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNZaselenei));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.распоряжениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ne_nadoDataSet = new DriverSchoool.ne_nadoDataSet();
            this.заселенный_студентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заселенный_студентTableAdapter = new DriverSchoool.ne_nadoDataSetTableAdapters.Заселенный_студентTableAdapter();
            this.tableAdapterManager = new DriverSchoool.ne_nadoDataSetTableAdapters.TableAdapterManager();
            this.распоряжениеTableAdapter = new DriverSchoool.ne_nadoDataSetTableAdapters.РаспоряжениеTableAdapter();
            this.заселенный_студентBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.заселенный_студентBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_СтудентTextBox = new System.Windows.Forms.TextBox();
            this.id_РаспоряжениеTextBox = new System.Windows.Forms.TextBox();
            this.id_КомнатаTextBox = new System.Windows.Forms.TextBox();
            this.заселенный_студентCheckBox = new System.Windows.Forms.CheckBox();
            this.фИОLabel1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.заселенный_студентDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            id_СтудентLabel = new System.Windows.Forms.Label();
            id_РаспоряжениеLabel = new System.Windows.Forms.Label();
            id_КомнатаLabel = new System.Windows.Forms.Label();
            заселенный_студентLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.распоряжениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ne_nadoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заселенный_студентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заселенный_студентBindingNavigator)).BeginInit();
            this.заселенный_студентBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заселенный_студентDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_СтудентLabel
            // 
            id_СтудентLabel.AutoSize = true;
            id_СтудентLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_СтудентLabel.Location = new System.Drawing.Point(31, 48);
            id_СтудентLabel.Name = "id_СтудентLabel";
            id_СтудентLabel.Size = new System.Drawing.Size(108, 23);
            id_СтудентLabel.TabIndex = 2;
            id_СтудентLabel.Text = "Id Студент:";
            // 
            // id_РаспоряжениеLabel
            // 
            id_РаспоряжениеLabel.AutoSize = true;
            id_РаспоряжениеLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_РаспоряжениеLabel.Location = new System.Drawing.Point(31, 86);
            id_РаспоряжениеLabel.Name = "id_РаспоряжениеLabel";
            id_РаспоряжениеLabel.Size = new System.Drawing.Size(163, 23);
            id_РаспоряжениеLabel.TabIndex = 4;
            id_РаспоряжениеLabel.Text = "Id Распоряжение:";
            // 
            // id_КомнатаLabel
            // 
            id_КомнатаLabel.AutoSize = true;
            id_КомнатаLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_КомнатаLabel.Location = new System.Drawing.Point(31, 124);
            id_КомнатаLabel.Name = "id_КомнатаLabel";
            id_КомнатаLabel.Size = new System.Drawing.Size(111, 23);
            id_КомнатаLabel.TabIndex = 6;
            id_КомнатаLabel.Text = "Id Комната:";
            // 
            // заселенный_студентLabel
            // 
            заселенный_студентLabel.AutoSize = true;
            заселенный_студентLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            заселенный_студентLabel.Location = new System.Drawing.Point(31, 164);
            заселенный_студентLabel.Name = "заселенный_студентLabel";
            заселенный_студентLabel.Size = new System.Drawing.Size(191, 23);
            заселенный_студентLabel.TabIndex = 8;
            заселенный_студентLabel.Text = "Заселенный студент:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.Location = new System.Drawing.Point(458, 71);
            фИОLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(48, 23);
            фИОLabel.TabIndex = 14;
            фИОLabel.Text = "ФИ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.заселенный_студентDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(35, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные ";
            // 
            // распоряжениеBindingSource
            // 
            this.распоряжениеBindingSource.DataMember = "Распоряжение";
            this.распоряжениеBindingSource.DataSource = this.ne_nadoDataSet;
            // 
            // ne_nadoDataSet
            // 
            this.ne_nadoDataSet.DataSetName = "ne_nadoDataSet";
            this.ne_nadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заселенный_студентBindingSource
            // 
            this.заселенный_студентBindingSource.DataMember = "Заселенный студент";
            this.заселенный_студентBindingSource.DataSource = this.ne_nadoDataSet;
            // 
            // заселенный_студентTableAdapter
            // 
            this.заселенный_студентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DriverSchoool.ne_nadoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Заселенный_студентTableAdapter = this.заселенный_студентTableAdapter;
            this.tableAdapterManager.ЗаявлениеTableAdapter = null;
            this.tableAdapterManager.КомнатаTableAdapter = null;
            this.tableAdapterManager.ОбщежитиеTableAdapter = null;
            this.tableAdapterManager.РаспоряжениеTableAdapter = this.распоряжениеTableAdapter;
            this.tableAdapterManager.СтудентTableAdapter = null;
            // 
            // распоряжениеTableAdapter
            // 
            this.распоряжениеTableAdapter.ClearBeforeFill = true;
            // 
            // заселенный_студентBindingNavigator
            // 
            this.заселенный_студентBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заселенный_студентBindingNavigator.BindingSource = this.заселенный_студентBindingSource;
            this.заселенный_студентBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заселенный_студентBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заселенный_студентBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заселенный_студентBindingNavigatorSaveItem});
            this.заселенный_студентBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заселенный_студентBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заселенный_студентBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заселенный_студентBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заселенный_студентBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заселенный_студентBindingNavigator.Name = "заселенный_студентBindingNavigator";
            this.заселенный_студентBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заселенный_студентBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.заселенный_студентBindingNavigator.TabIndex = 1;
            this.заселенный_студентBindingNavigator.Text = "bindingNavigator1";
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
            // заселенный_студентBindingNavigatorSaveItem
            // 
            this.заселенный_студентBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заселенный_студентBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заселенный_студентBindingNavigatorSaveItem.Image")));
            this.заселенный_студентBindingNavigatorSaveItem.Name = "заселенный_студентBindingNavigatorSaveItem";
            this.заселенный_студентBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заселенный_студентBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заселенный_студентBindingNavigatorSaveItem.Click += new System.EventHandler(this.заселенный_студентBindingNavigatorSaveItem_Click);
            // 
            // id_СтудентTextBox
            // 
            this.id_СтудентTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заселенный_студентBindingSource, "Id_Студент", true));
            this.id_СтудентTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_СтудентTextBox.Location = new System.Drawing.Point(267, 48);
            this.id_СтудентTextBox.Name = "id_СтудентTextBox";
            this.id_СтудентTextBox.Size = new System.Drawing.Size(160, 32);
            this.id_СтудентTextBox.TabIndex = 3;
            // 
            // id_РаспоряжениеTextBox
            // 
            this.id_РаспоряжениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заселенный_студентBindingSource, "Id_Распоряжение", true));
            this.id_РаспоряжениеTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_РаспоряжениеTextBox.Location = new System.Drawing.Point(267, 86);
            this.id_РаспоряжениеTextBox.Name = "id_РаспоряжениеTextBox";
            this.id_РаспоряжениеTextBox.Size = new System.Drawing.Size(160, 32);
            this.id_РаспоряжениеTextBox.TabIndex = 5;
            // 
            // id_КомнатаTextBox
            // 
            this.id_КомнатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заселенный_студентBindingSource, "Id_Комната", true));
            this.id_КомнатаTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_КомнатаTextBox.Location = new System.Drawing.Point(267, 124);
            this.id_КомнатаTextBox.Name = "id_КомнатаTextBox";
            this.id_КомнатаTextBox.Size = new System.Drawing.Size(160, 32);
            this.id_КомнатаTextBox.TabIndex = 7;
            // 
            // заселенный_студентCheckBox
            // 
            this.заселенный_студентCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.заселенный_студентBindingSource, "Заселенный_студент", true));
            this.заселенный_студентCheckBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.заселенный_студентCheckBox.Location = new System.Drawing.Point(267, 162);
            this.заселенный_студентCheckBox.Name = "заселенный_студентCheckBox";
            this.заселенный_студентCheckBox.Size = new System.Drawing.Size(160, 24);
            this.заселенный_студентCheckBox.TabIndex = 9;
            this.заселенный_студентCheckBox.Text = "Да";
            this.заселенный_студентCheckBox.UseVisualStyleBackColor = true;
            // 
            // фИОLabel1
            // 
            this.фИОLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИОLabel1.Location = new System.Drawing.Point(524, 71);
            this.фИОLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.фИОLabel1.Name = "фИОLabel1";
            this.фИОLabel1.Size = new System.Drawing.Size(221, 19);
            this.фИОLabel1.TabIndex = 15;
            this.фИОLabel1.Text = "1 Зазуля Анастасия ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(628, 144);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "Заявление ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(462, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Студент ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // заселенный_студентDataGridView
            // 
            this.заселенный_студентDataGridView.AutoGenerateColumns = false;
            this.заселенный_студентDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заселенный_студентDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.заселенный_студентDataGridView.DataSource = this.заселенный_студентBindingSource;
            this.заселенный_студентDataGridView.Location = new System.Drawing.Point(0, 19);
            this.заселенный_студентDataGridView.Name = "заселенный_студентDataGridView";
            this.заселенный_студентDataGridView.Size = new System.Drawing.Size(592, 220);
            this.заселенный_студентDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Студент";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Студент";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Распоряжение";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Распоряжение";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Комната";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Комната";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Заселенный_студент";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Заселенный_студент";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // DNZaselenei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОLabel1);
            this.Controls.Add(id_СтудентLabel);
            this.Controls.Add(this.id_СтудентTextBox);
            this.Controls.Add(id_РаспоряжениеLabel);
            this.Controls.Add(this.id_РаспоряжениеTextBox);
            this.Controls.Add(id_КомнатаLabel);
            this.Controls.Add(this.id_КомнатаTextBox);
            this.Controls.Add(заселенный_студентLabel);
            this.Controls.Add(this.заселенный_студентCheckBox);
            this.Controls.Add(this.заселенный_студентBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "DNZaselenei";
            this.Text = "DNZaselenei";
            this.Load += new System.EventHandler(this.DNZaselenei_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.распоряжениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ne_nadoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заселенный_студентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заселенный_студентBindingNavigator)).EndInit();
            this.заселенный_студентBindingNavigator.ResumeLayout(false);
            this.заселенный_студентBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заселенный_студентDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ne_nadoDataSet ne_nadoDataSet;
        private System.Windows.Forms.BindingSource заселенный_студентBindingSource;
        private ne_nadoDataSetTableAdapters.Заселенный_студентTableAdapter заселенный_студентTableAdapter;
        private ne_nadoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заселенный_студентBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заселенный_студентBindingNavigatorSaveItem;
        private ne_nadoDataSetTableAdapters.РаспоряжениеTableAdapter распоряжениеTableAdapter;
        private System.Windows.Forms.TextBox id_СтудентTextBox;
        private System.Windows.Forms.TextBox id_РаспоряжениеTextBox;
        private System.Windows.Forms.TextBox id_КомнатаTextBox;
        private System.Windows.Forms.CheckBox заселенный_студентCheckBox;
        private System.Windows.Forms.BindingSource распоряжениеBindingSource;
        private System.Windows.Forms.Label фИОLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView заселенный_студентDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}
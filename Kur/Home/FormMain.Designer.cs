namespace DriverSchoool
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чтотоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.важнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеСтудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распоряженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заселенныйСтудентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеОЗаявленияхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеООбщежитияхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.чтотоToolStripMenuItem,
            this.важнаяИнформацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.оПрограммеToolStripMenuItem.Image = global::DriverSchoool.Properties.Resources._12;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе ";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.выйтиToolStripMenuItem.Image = global::DriverSchoool.Properties.Resources._7;
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти ";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click_1);
            // 
            // чтотоToolStripMenuItem
            // 
            this.чтотоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентToolStripMenuItem,
            this.заявлениеToolStripMenuItem,
            this.операторToolStripMenuItem});
            this.чтотоToolStripMenuItem.Name = "чтотоToolStripMenuItem";
            this.чтотоToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.чтотоToolStripMenuItem.Text = "Редактировать";
            // 
            // студентToolStripMenuItem
            // 
            this.студентToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.студентToolStripMenuItem.Image = global::DriverSchoool.Properties.Resources._4;
            this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.студентToolStripMenuItem.Text = "Запросы по данным";
            this.студентToolStripMenuItem.Click += new System.EventHandler(this.студентToolStripMenuItem_Click);
            // 
            // заявлениеToolStripMenuItem
            // 
            this.заявлениеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.заявлениеToolStripMenuItem.Image = global::DriverSchoool.Properties.Resources._5;
            this.заявлениеToolStripMenuItem.Name = "заявлениеToolStripMenuItem";
            this.заявлениеToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.заявлениеToolStripMenuItem.Text = "Изменение данных";
            this.заявлениеToolStripMenuItem.Click += new System.EventHandler(this.заявлениеToolStripMenuItem_Click);
            // 
            // операторToolStripMenuItem
            // 
            this.операторToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.операторToolStripMenuItem.BackgroundImage = global::DriverSchoool.Properties.Resources._6;
            this.операторToolStripMenuItem.Name = "операторToolStripMenuItem";
            this.операторToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.операторToolStripMenuItem.Text = "Операторы";
            this.операторToolStripMenuItem.Click += new System.EventHandler(this.операторToolStripMenuItem_Click);
            // 
            // важнаяИнформацияToolStripMenuItem
            // 
            this.важнаяИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеСтудентовToolStripMenuItem,
            this.распоряженияToolStripMenuItem,
            this.заселенныйСтудентToolStripMenuItem,
            this.данныеОЗаявленияхToolStripMenuItem,
            this.данныеООбщежитияхToolStripMenuItem});
            this.важнаяИнформацияToolStripMenuItem.Name = "важнаяИнформацияToolStripMenuItem";
            this.важнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.важнаяИнформацияToolStripMenuItem.Text = "Таблицы";
            // 
            // данныеСтудентовToolStripMenuItem
            // 
            this.данныеСтудентовToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.данныеСтудентовToolStripMenuItem.Image = global::DriverSchoool.Properties.Resources._4;
            this.данныеСтудентовToolStripMenuItem.Name = "данныеСтудентовToolStripMenuItem";
            this.данныеСтудентовToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.данныеСтудентовToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.данныеСтудентовToolStripMenuItem.Text = "Данные студентов";
            this.данныеСтудентовToolStripMenuItem.Click += new System.EventHandler(this.данныеСтудентовToolStripMenuItem_Click);
            // 
            // распоряженияToolStripMenuItem
            // 
            this.распоряженияToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.распоряженияToolStripMenuItem.Image = global::DriverSchoool.Properties.Resources._6;
            this.распоряженияToolStripMenuItem.Name = "распоряженияToolStripMenuItem";
            this.распоряженияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.распоряженияToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.распоряженияToolStripMenuItem.Text = "Список распоряжений";
            this.распоряженияToolStripMenuItem.Click += new System.EventHandler(this.распоряженияToolStripMenuItem_Click);
            // 
            // заселенныйСтудентToolStripMenuItem
            // 
            this.заселенныйСтудентToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.заселенныйСтудентToolStripMenuItem.Image = global::DriverSchoool.Properties.Resources._10;
            this.заселенныйСтудентToolStripMenuItem.Name = "заселенныйСтудентToolStripMenuItem";
            this.заселенныйСтудентToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D0)));
            this.заселенныйСтудентToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.заселенныйСтудентToolStripMenuItem.Text = "Данные о комнате";
            this.заселенныйСтудентToolStripMenuItem.Click += new System.EventHandler(this.заселенныйСтудентToolStripMenuItem_Click);
            // 
            // данныеОЗаявленияхToolStripMenuItem
            // 
            this.данныеОЗаявленияхToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.данныеОЗаявленияхToolStripMenuItem.Image = global::DriverSchoool.Properties.Resources._5;
            this.данныеОЗаявленияхToolStripMenuItem.Name = "данныеОЗаявленияхToolStripMenuItem";
            this.данныеОЗаявленияхToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.данныеОЗаявленияхToolStripMenuItem.Text = "Данные о заявлениях";
            this.данныеОЗаявленияхToolStripMenuItem.Click += new System.EventHandler(this.данныеОЗаявленияхToolStripMenuItem_Click);
            // 
            // данныеООбщежитияхToolStripMenuItem
            // 
            this.данныеООбщежитияхToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.данныеООбщежитияхToolStripMenuItem.Image = global::DriverSchoool.Properties.Resources._9;
            this.данныеООбщежитияхToolStripMenuItem.Name = "данныеООбщежитияхToolStripMenuItem";
            this.данныеООбщежитияхToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.данныеООбщежитияхToolStripMenuItem.Text = "Данные о общежитиях";
            this.данныеООбщежитияхToolStripMenuItem.Click += new System.EventHandler(this.данныеООбщежитияхToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(143, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вы зашли под именем \"Администратор\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(251, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добро пожаловать! ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DriverSchoool.Properties.Resources._2557;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(777, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Автошкола";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чтотоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem важнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеСтудентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem распоряженияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заселенныйСтудентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеОЗаявленияхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеООбщежитияхToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem операторToolStripMenuItem;
    }
}


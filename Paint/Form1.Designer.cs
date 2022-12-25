namespace Paint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.CheckBox();
            this.Drag_and_Drop = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Rhomb = new System.Windows.Forms.Button();
            this.Oval = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Thickness = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentColor = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьJPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thickness)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Fill);
            this.panel1.Controls.Add(this.Drag_and_Drop);
            this.panel1.Controls.Add(this.Triangle);
            this.panel1.Controls.Add(this.Rhomb);
            this.panel1.Controls.Add(this.Oval);
            this.panel1.Controls.Add(this.Rectangle);
            this.panel1.Controls.Add(this.Thickness);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CurrentColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 616);
            this.panel1.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(12, 356);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(104, 23);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Fill
            // 
            this.Fill.AutoSize = true;
            this.Fill.Location = new System.Drawing.Point(12, 58);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(69, 17);
            this.Fill.TabIndex = 12;
            this.Fill.Text = "Заливка";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.CheckedChanged += new System.EventHandler(this.Fill_CheckedChanged);
            // 
            // Drag_and_Drop
            // 
            this.Drag_and_Drop.Location = new System.Drawing.Point(12, 317);
            this.Drag_and_Drop.Name = "Drag_and_Drop";
            this.Drag_and_Drop.Size = new System.Drawing.Size(104, 23);
            this.Drag_and_Drop.TabIndex = 11;
            this.Drag_and_Drop.Text = "Перетащить";
            this.Drag_and_Drop.UseVisualStyleBackColor = true;
            this.Drag_and_Drop.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(12, 274);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(104, 23);
            this.Triangle.TabIndex = 10;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Rhomb
            // 
            this.Rhomb.Location = new System.Drawing.Point(12, 234);
            this.Rhomb.Name = "Rhomb";
            this.Rhomb.Size = new System.Drawing.Size(104, 23);
            this.Rhomb.TabIndex = 9;
            this.Rhomb.Text = "Ромб";
            this.Rhomb.UseVisualStyleBackColor = true;
            this.Rhomb.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Oval
            // 
            this.Oval.Location = new System.Drawing.Point(12, 196);
            this.Oval.Name = "Oval";
            this.Oval.Size = new System.Drawing.Size(104, 23);
            this.Oval.TabIndex = 8;
            this.Oval.Text = "Овал";
            this.Oval.UseVisualStyleBackColor = true;
            this.Oval.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Rectangle.FlatAppearance.BorderSize = 5;
            this.Rectangle.Location = new System.Drawing.Point(12, 158);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(104, 23);
            this.Rectangle.TabIndex = 7;
            this.Rectangle.Text = "Прямоугольник";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Thickness
            // 
            this.Thickness.Location = new System.Drawing.Point(12, 107);
            this.Thickness.Maximum = 100;
            this.Thickness.Minimum = 1;
            this.Thickness.Name = "Thickness";
            this.Thickness.Size = new System.Drawing.Size(104, 45);
            this.Thickness.TabIndex = 6;
            this.Thickness.Value = 1;
            this.Thickness.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Thickness_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цвет";
            // 
            // CurrentColor
            // 
            this.CurrentColor.BackColor = System.Drawing.Color.Black;
            this.CurrentColor.Location = new System.Drawing.Point(74, 20);
            this.CurrentColor.Name = "CurrentColor";
            this.CurrentColor.Size = new System.Drawing.Size(23, 20);
            this.CurrentColor.TabIndex = 4;
            this.CurrentColor.Click += new System.EventHandler(this.CurrentColor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1285, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьXMLToolStripMenuItem,
            this.сохранитьJPGToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьXMLToolStripMenuItem
            // 
            this.сохранитьXMLToolStripMenuItem.Name = "сохранитьXMLToolStripMenuItem";
            this.сохранитьXMLToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сохранитьXMLToolStripMenuItem.Text = "Сохранить XML";
            this.сохранитьXMLToolStripMenuItem.Click += new System.EventHandler(this.сохранитьXMLToolStripMenuItem_Click);
            // 
            // сохранитьJPGToolStripMenuItem
            // 
            this.сохранитьJPGToolStripMenuItem.Name = "сохранитьJPGToolStripMenuItem";
            this.сохранитьJPGToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сохранитьJPGToolStripMenuItem.Text = "Сохранить JPG";
            this.сохранитьJPGToolStripMenuItem.Click += new System.EventHandler(this.сохранитьJPGToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(128, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 616);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1157, 616);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thickness)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьJPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel CurrentColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Thickness;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Rhomb;
        private System.Windows.Forms.Button Oval;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Drag_and_Drop;
        private System.Windows.Forms.CheckBox Fill;
        private System.Windows.Forms.Button Clear;
    }
}


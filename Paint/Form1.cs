using Paint.Figure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {

        //DataDrawingFigure dataDrawing = new DataDrawingFigure();
        DataPaint paint = new DataPaint();
        DataFigure dataFigure;
        Bitmap pic;
        Bitmap pic1;
        Graphics g;
        Graphics g1;

        public Form1()
        {
            dataFigure = new DataFigure();
            InitializeComponent();
            pic = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pic1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pic);
            g.Clear(Color.White);
            g1 = Graphics.FromImage(pic1);


        }

       

        private void сохранитьJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null) //если в pictureBox есть изображение
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.jpg)|*.jpg|Image Files(*.png)|*.PNG";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.Contains(".jpg"))
            {
                pic = (Bitmap)System.Drawing.Image.FromFile(openFileDialog1.FileName);
                g = Graphics.FromImage(pic);
                pictureBox1.Image = pic;
            }
            else if (openFileDialog1.FileName.Contains(".xml"))
            {
                g.Clear(Color.Transparent);
                dataFigure.deSerializeXML();
                dataFigure.draw_all_figure(g);
                pictureBox1.Image = pic;
            }

        }

    

        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                switch (paint.mode)
                {
                    case "Rectangle":
                        g1.Clear(Color.Transparent);
                        g1.DrawImage(pic, 0, 0);
                        Figure.Rectangle rectangle = new Figure.Rectangle(paint, new Point(e.X, e.Y));
                        rectangle.draw(g1);
                        pictureBox1.Image = pic1;
                        break;
                    case "Triangle":
                        g1.Clear(Color.Transparent);
                        g1.DrawImage(pic, 0, 0);
                        Triangle triangle = new Triangle(paint, new Point(e.X, e.Y));
                        triangle.draw(g1);
                        pictureBox1.Image = pic1;
                        break;
                    case "Oval":
                        g1.Clear(Color.Transparent);
                        g1.DrawImage(pic, 0, 0);
                        Oval oval = new Oval(paint, new Point(e.X, e.Y));
                        oval.draw(g1);
                        pictureBox1.Image = pic1;
                        break;
                    case "Rhomb":
                        g1.Clear(Color.Transparent);
                        g1.DrawImage(pic, 0, 0);
                        Rhomb rhomb = new Rhomb(paint, new Point(e.X, e.Y));
                        rhomb.draw(g1);
                        pictureBox1.Image = pic1;
                        break;
                    case "Drag_and_Drop":
                        if (dataFigure.moving_figure != null)
                        { 
                            g1.Clear(Color.Transparent);
                            g1.DrawImage(pic, 0, 0);
                            dataFigure.moving_figure.move(g1, paint, new Point(e.X, e.Y));
                            pictureBox1.Image = pic1;
                        }
                        
                        break;

                }


            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                paint.click = new Point(e.X, e.Y);
                if (paint.mode == "Drag_and_Drop")
                {
                    dataFigure.search_figure(g, paint.click);
                    dataFigure.draw_pic_without_figure(g);
                }
            }
        }

        private void Thickness_MouseUp(object sender, MouseEventArgs e)
        {
            paint.pen.Width = Thickness.Value;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (paint.mode)
            {
                case "Rectangle":
                    Figure.Rectangle rectangle = new Figure.Rectangle(paint, new Point(e.X, e.Y));
                    rectangle.draw(g);
                    pictureBox1.Image = pic;
                    dataFigure.figures.Insert(0, rectangle);
                    break;
                case "Triangle":
                    Triangle triangle = new Triangle(paint, new Point(e.X, e.Y));
                    triangle.draw(g);
                    pictureBox1.Image = pic;
                    dataFigure.figures.Insert(0, triangle);
                    break;
                case "Oval":
                    Oval oval = new Oval(paint, new Point(e.X, e.Y));
                    oval.draw(g);
                    pictureBox1.Image = pic;
                    dataFigure.figures.Insert(0, oval);
                    break;
                case "Rhomb":
                    Rhomb rhomb = new Rhomb(paint, new Point(e.X, e.Y));
                    rhomb.draw(g);
                    pictureBox1.Image = pic;
                    dataFigure.figures.Insert(0, rhomb);
                    break;
               case "Drag_and_Drop":
                    if (dataFigure.moving_figure != null)
                    { 
                        dataFigure.moving_figure.draw(g);
                        dataFigure.figures.Insert(0, dataFigure.moving_figure);
                        dataFigure.figures.RemoveAt(dataFigure.figures.LastIndexOf(dataFigure.moving_figure));
                        pictureBox1.Image = pic;
                    }
                    break;
                    


            }
        }



        private void CurrentColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { 
                CurrentColor.BackColor = colorDialog1.Color;
                paint.pen.Color = CurrentColor.BackColor;
            }
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            switch (button.Name)
            {
                case "Rectangle":
                    paint.mode = "Rectangle";
                    break;
                case "Oval":
                    paint.mode = "Oval";
                    break;
                case "Triangle":
                    paint.mode = "Triangle";
                    break;
                case "Rhomb":
                    paint.mode = "Rhomb";
                    break;
                case "Drag_and_Drop":
                    paint.mode = "Drag_and_Drop";
                    break;
            }
            
        }

        private void Fill_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked) paint.filling = true;
            else paint.filling = false;

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            dataFigure.figures.Clear();
            g.Clear(Color.Transparent);
            pictureBox1.Image = pic;
        }

        private void сохранитьXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataFigure.SerializeXML();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}

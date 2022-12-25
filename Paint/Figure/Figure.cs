using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Paint.Figure
{
    [Serializable]
    abstract public class Figure
    {
        public DataDrawingFigure figure;
        public Point start_location;
        public Point end_location;
        
        public Figure() { }
        public Figure(DataPaint paint, Point end_location)
        {
            figure = new DataDrawingFigure();
            figure.color = paint.pen.Color.ToArgb();
            figure.width =  paint.pen.Width;
            figure.filling = paint.filling;
            figure.figure = paint.mode;
            this.start_location = new Point(paint.click.X, paint.click.Y);
            this.end_location = end_location; 
           
        }

        public abstract void draw(Graphics g);
        public void move(Graphics g, DataPaint paint, Point new_location) 
        {
            start_location = new Point(start_location.X + (new_location.X - paint.click.X), start_location.Y + (new_location.Y - paint.click.Y));
            end_location = new Point(end_location.X + (new_location.X - paint.click.X), end_location.Y + (new_location.Y - paint.click.Y));
            paint.click = new_location;
            draw(g);
        }


    }
}

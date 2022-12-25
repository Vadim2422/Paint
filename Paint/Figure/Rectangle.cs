using System;
using System.Drawing;
using System.Xml.Serialization;

namespace Paint.Figure
{
    [XmlInclude(typeof(Rectangle))]
    public class Rectangle : Figure
    {
        public Rectangle(DataPaint data ,Point end_location) : base(data, end_location) {}
        public Rectangle() {}
        public override void draw(Graphics g)
        {
            int start_x = start_location.X;
            int start_y = start_location.Y;
            if (start_location.X > end_location.X) start_x = end_location.X;
            if (start_location.Y > end_location.Y) start_y = end_location.Y;
            if (figure.filling) g.FillRectangle(new SolidBrush(Color.FromArgb(figure.color)), start_x, start_y, Math.Abs(start_location.X - end_location.X), Math.Abs(start_location.Y - end_location.Y));
            else
                g.DrawRectangle(new Pen(Color.FromArgb(figure.color), figure.width), start_x, start_y, Math.Abs(start_location.X - end_location.X), Math.Abs(start_location.Y - end_location.Y));
            
        }

    }
}

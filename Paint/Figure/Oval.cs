using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Paint.Figure
{
    public class Oval : Figure
    {
        public Oval(DataPaint data, Point end_location) : base(data, end_location){}

        public Oval() {}
        public override void draw(Graphics g)
        {
            if (figure.filling) g.FillEllipse(new SolidBrush(Color.FromArgb(figure.color)), start_location.X, start_location.Y, end_location.X - start_location.X, end_location.Y - start_location.Y);
            else
                g.DrawEllipse(new Pen(Color.FromArgb(figure.color), figure.width), start_location.X, start_location.Y, end_location.X - start_location.X, end_location.Y - start_location.Y);
        }

    }
}

using System.Drawing;

namespace Paint.Figure
{
    public class Rhomb : Figure
    {
        public Rhomb(DataPaint data, Point end_location) : base(data, end_location)
        {
        }
        public Rhomb() { }  
        public override void draw(Graphics g)
        {
            Point one = new Point(start_location.X + (end_location.X - start_location.X)/2, start_location.Y);
            Point two = new Point(end_location.X, start_location.Y + (end_location.Y - start_location.Y)/2);
            Point three = new Point(start_location.X + (end_location.X - start_location.X) / 2, end_location.Y);
            Point four = new Point(start_location.X, start_location.Y + (end_location.Y - start_location.Y) / 2);
            Point[] points = { one, two, three, four };
            if (figure.filling) g.FillPolygon(new SolidBrush(Color.FromArgb(figure.color)), points);
            else
                g.DrawPolygon(new Pen(Color.FromArgb(figure.color), figure.width), points);
        }

    }
}

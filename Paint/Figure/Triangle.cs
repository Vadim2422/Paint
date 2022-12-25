using System.Drawing;


namespace Paint.Figure
{
    public class Triangle : Figure
    {
        public Triangle(DataPaint data, Point end_location) : base(data, end_location)
        {
        }
        public Triangle() {}   

        public override void draw(Graphics g)
        {
            Point one = new Point(start_location.X + (end_location.X - start_location.X)/2, start_location.Y);
            Point two = new Point(start_location.X, end_location.Y);
            Point three = new Point(end_location.X, end_location.Y);
            Point[] points = {one, two ,three};
            if (figure.filling) g.FillPolygon(new SolidBrush(Color.FromArgb(figure.color)), points);
            else 
                g.DrawPolygon(new Pen(Color.FromArgb(figure.color), figure.width), points);
        }

    }
}

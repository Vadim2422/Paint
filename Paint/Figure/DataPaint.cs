using System.Drawing;

namespace Paint.Figure
{
    public class DataPaint
    {
        public string mode = "Rectangle";
        public Point click;
        public bool filling = false;
        public Pen pen = new Pen(Color.Black, 1);
         
    }
}

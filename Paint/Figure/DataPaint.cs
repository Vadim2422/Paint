using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

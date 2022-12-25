using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Figure
{
    [Serializable]
    public class DataDrawingFigure
    {

       
        //public Pen pen = new Pen(Color.Black, 1);
        public int color =  0;
        public float width =  1;
        public bool filling = false;
        public string figure = "Rectangle";
    
       public DataDrawingFigure() { }   
    }
}

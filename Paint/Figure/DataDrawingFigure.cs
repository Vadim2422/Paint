using System;

namespace Paint.Figure
{
    [Serializable]
    public class DataDrawingFigure
    {
        public int color =  0;
        public float width =  1;
        public bool filling = false;
        public string figure = "Rectangle";
    
       public DataDrawingFigure() { }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;

namespace Paint.Figure
{
    [Serializable]
    [XmlInclude(typeof(Figure))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Oval))]
    [XmlInclude(typeof(Triangle))]
    [XmlInclude(typeof(Rhomb))]
    public class DataFigure
    {
        
        public List<Figure> figures = new List<Figure> { };

        [XmlIgnore]
        public Figure moving_figure;


        public void search_figure(Graphics g, Point click)
        {
            moving_figure = null;
            foreach (Figure f in figures)
            {
                
                if (f.start_location.X < f.end_location.X)
                {
                    if (!(click.X >= f.start_location.X && click.X <= f.end_location.X))
                    {
                        continue;
                    }



                }

                if (f.start_location.Y < f.end_location.Y)
                {
                    if (!(click.Y >= f.start_location.Y && click.Y <= f.end_location.Y))
                    {
                        continue;
                    }

                }

                if (f.start_location.X > f.end_location.X)
                {
                    if (!(click.X >= f.end_location.X && click.X <= f.start_location.X))
                    {
                        continue;
                    }



                }

                if (f.start_location.Y > f.end_location.Y)
                {
                    if (!(click.Y >= f.end_location.Y && click.Y <= f.start_location.Y))
                    {
                        continue;
                    }

                }
                moving_figure = f;
                return;


            }

        }
        public void draw_all_figure(Graphics g)
        {
            g.Clear(Color.Transparent);
            foreach (Figure figure in figures)
            {
                if (moving_figure != figure)
                {
                    figure.draw(g);
                }
            }
        }
        public void draw_pic_without_figure(Graphics g)
        {
            g.Clear(Color.Transparent);
            foreach (Figure figure in figures)
            {
                if (moving_figure != figure)
                {
                    figure.draw(g);
                }
            }
        }

        public void SerializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(DataFigure));

            using (FileStream fs = new FileStream("C:\\Users\\breev\\source\\repos\\Paint\\Paint\\Figure.xml", FileMode.Create)) 
            {
                xml.Serialize(fs, this);
            }
        }
        public void deSerializeXML()
        {
            figures.Clear();
            using (FileStream fs = new FileStream("C:\\Users\\breev\\source\\repos\\Paint\\Paint\\Figure.xml", FileMode.Open))
            {
                XmlSerializer xml = new XmlSerializer(typeof(DataFigure));
                DataFigure figure_tmp = xml.Deserialize(fs) as DataFigure;
                figures = figure_tmp.figures;
            }
        }


    }
}

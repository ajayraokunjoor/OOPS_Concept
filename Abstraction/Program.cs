using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();
            circle.Select();
            circle.Copy();

            var rectangle = new Rectangle();
            rectangle.Draw();
            rectangle.Select();
            rectangle.Copy();
            var triangle = new Triangle();
            rectangle.Draw();
            rectangle.Select();
            rectangle.Copy();

            var shapes = new List<Shape>();

            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(triangle);


            //Ploymorphism
            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}

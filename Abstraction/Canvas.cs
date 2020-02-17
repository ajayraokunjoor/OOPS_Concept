using System.Collections.Generic;

namespace Abstraction
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
#if badcode
            foreach (var shape in shapes)
            {
                switch (shape.ShapeType)
                {
                    case ShapeType.Circle:
                        System.Console.WriteLine("Draw a circle");
                        break;
                    case ShapeType.Rectangle:
                        System.Console.WriteLine("Draw a rectangle");
                        break;
                    default:
                        break;
                }
            }
#endif
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}

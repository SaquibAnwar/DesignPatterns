using System.Collections.Generic;

namespace DesignPatterns
{
    public class ShapeObjectFactory
    {
        Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public int TotalObjectsCreated
        {
            get{ return shapes.Count; }
        }

        public IShape GetShape(string shapeName)
        {
            IShape shape = null;
            if(shapes.ContainsKey(shapeName))
            {
                shape = shapes[shapeName];
            }
            else
            {
                switch (shapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        shapes.Add("Rectangle", shape);
                        break;
                    case "Circle":
                        shape = new Circle();
                        shapes.Add("Circle", shape);
                        break;
                    default:
                        throw new System.Exception("Factory cannot create the object spexcified");
                }
            }

            return shape;
        }
    }
}
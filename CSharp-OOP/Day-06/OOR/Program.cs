#region Lab Assignmets

//1- Composition vs. Association 
//on class Point, line,rect,circle,tri

//2- inheritance,protected ,overriding
//on geoshape,rect,sq,sqv2,cir,tri
#endregion

using System.Drawing;

namespace OOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Composition Examples
            //Line l1 = new Line();
            //Console.WriteLine(l1.Print());
            //Console.WriteLine("--------------------");
            //Line l2 = new Line(1, 2, 3, 4);
            //Console.WriteLine(l2.Print());

            //Console.WriteLine();
            //CompTriangle tri1 = new CompTriangle();
            //CompTriangle tri2 = new CompTriangle(1,1,2,2,3,3);
            #endregion

            #region Aggregation(Association) Examples
            //AggRectangle rect1 = new AggRectangle();

            //Console.WriteLine();
            //Point p1 = new Point(2, 4);
            //Point p2 = new Point(3, 5);
            //AggRectangle rect2 = new AggRectangle(p1, p2);

            //// Removing Dependancy
            //rect2.UpperLeft = null;
            //rect2.LowerRight = null;
            #endregion

            #region Testing Inheritance
            //// Reactangle
            //Rectangle rect = new Rectangle(5, 6);
            //Console.WriteLine($"The area of the Rectangle with dimentions ({rect.Dim1}) × ({rect.Dim2}) = {rect.CalcArea()}\n");

            //// Square
            //Square sqr = new Square(2.5);
            //Console.WriteLine($"The area of the Square with side ({sqr.Dim1}) is = {sqr.CalcArea()}\n");

            //// Triangle
            //Triangle tri = new Triangle(8, 6.5);
            //Console.WriteLine($"The area of the Triangle with base ({tri.Dim1}) and height ({tri.Dim2}) is = {tri.CalcArea()}\n");

            ////Circle
            //Circle crcl = new Circle(5);
            //Console.WriteLine($"The area of the Circle with raduis ({crcl.Dim1}) is = {crcl.CalcArea()}\n");
            #endregion
        }
    }
}

#region Lab Assignments
//1- try early vs late binding on
//////parent , child ,subchild
///
///2- try SumOfAreas with 2 versions
///class geoshape and its child
////abstract class
////abstract method
#endregion

namespace Early_Late_Binding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Early/Static Binding Example
            //Console.WriteLine("Early/Static Binding:");
            //Parent p1 = new Child();
            //Parent p2 = new SubChild();
            //Child ch1 = new SubChild();

            //Console.WriteLine(p1.Show());
            //Console.WriteLine(p2.Show());
            //Console.WriteLine(ch1.Show());
            #endregion
            #region Late/Dynamic Binding Examples
            //Console.WriteLine("\nLate/Dynamic Binding:");
            //Parent p3 = new Child();
            //Parent p4 = new SubChild();
            //Child ch2 = new SubChild();

            //Console.WriteLine(p3.Print());
            //Console.WriteLine(p4.Print());
            //Console.WriteLine(ch2.Print());
            #endregion

            #region Sum of Areas
            //// Without Open Close Principle
            //Triangle[] tris =
            //{
            //    new Triangle{ Dim1 = 5, Dim2 = 6 },
            //    new Triangle{ Dim1 = 1, Dim2 = 2 },
            //    new Triangle{ Dim1 = 3, Dim2 = 4 }
            //};

            //Circle[] crcls =
            //{
            //    new Circle(5),
            //    new Circle(4)
            //};

            //Console.WriteLine($"Total Areas Sum = {Utility.CalcAreasV1(tris, crcls)}");

            //// With Open Close Principle
            //Rectangle rect1 = new Rectangle
            //{
            //    Dim1 = 5,
            //    Dim2 = 3
            //};

            //// Can filled in any order
            //Geoshape[] oldShapes = { tris[0], crcls[1], tris[1], tris[2], crcls[0] };
            //Geoshape[] newShapes = { tris[0], crcls[1], tris[1], rect1, tris[2], crcls[0] };

            //Console.WriteLine($"Total Areas Sum  = {Utility.CalcAreasV2(oldShapes)}");
            //Console.WriteLine($"Total Areas Sum  = {Utility.CalcAreasV2(newShapes)}");
            #endregion
        }
    }
}

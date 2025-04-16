namespace Lab
{
    #region Assignment
    /*
    TRY ALL WHAT YOU HAVE TAKEN IN THE LECTURES

    -Using ILDASM to view your IL output
    -Using Dotfuscator to protect your code

    1. Design 3D Point Class and Include the basic Constructor(s)

    2. Override the ToString Function to produce this output
        Point3D P = new Point3D(10, 10, 10);
        Console.WriteLine(Point3D.ToString());
      • Point Coordinates:   (10, 10, 10)

    3. Read from the User the Coordinates for 2 point P1, P2
       (Parse , Convert )

    4. Try to use == 
        If (P1 ==P2)
        Does it work properly? 
        Try to override the Equals Function (from base Object)

    5. Define an array of points
    */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(2, 5, 3);
            Console.WriteLine(p1.ToString());

            Console.WriteLine("Enter The Point Coordinates (X, Y, Z) Respectively: ");
            int x = int.Parse(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            Point3D p2 = new Point3D(x, y, z);
            Console.WriteLine(p2.ToString());
            Console.WriteLine("----------------------");

            Console.WriteLine("Before overriding Equals()");
            if (p1 == p2) // Won't work properly
                Console.WriteLine("IS EQUAL!");
            else
                Console.WriteLine("IS NOT EQUAL!");

            Console.WriteLine("----------------------");
            Console.WriteLine("After overriding Equals()");
            if (p1.Equals(p2))
                Console.WriteLine("IS EQUAL!");
            else
                Console.WriteLine("IS NOT EQUAL!");

            Point3D[] points = new Point3D[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = new Point3D(5,10, 10);
            points[3] = new Point3D(12,5, 3);
        }
    }
}

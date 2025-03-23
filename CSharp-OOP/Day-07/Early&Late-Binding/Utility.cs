namespace Early_Late_Binding
{
    class Utility
    {
        public static double CalcAreasV1(Triangle[] triangles, Circle[] circles, Rectangle[] rectangles)
        {
            double sum = 0;
            for (int i = 0; i < triangles.Length; i++)
            {
                sum += triangles[i].CalcArea();
            }
            for (int i = 0; i < circles.Length; i++)
            {
                sum += circles[i].CalcArea();
            }
            for (int i = 0; i < rectangles.Length; i++)
            {
                sum += rectangles[i].CalcArea();
            }
            return sum;
        }
        public static double CalcAreasV1(Triangle[] triangles, Circle[] circles)
        {
            double sum = 0;
            for (int i = 0; i < triangles.Length; i++)
            {
                sum += triangles[i].CalcArea();
            }
            for (int i = 0; i < circles.Length; i++)
            {
                sum += circles[i].CalcArea();
            }
            return sum;
        } // Then create functions for all cases

        // OR: usint Open Close Principle
        public static double CalcAreasV2(Geoshape[] geoshapes)
        {
            double sum = 0;
            for (int i = 0; i < geoshapes.Length; i++)
            {
                sum += geoshapes[i].CalcArea();
            }
            return sum;
        }
    }
}

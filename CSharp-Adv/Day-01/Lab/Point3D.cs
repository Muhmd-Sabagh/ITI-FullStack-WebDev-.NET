namespace Lab
{
    class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x = 0, int y = 0, int z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        // Override Equals()
        public override bool Equals(object? obj)
        {
            Point3D p = (Point3D)obj;
            return (X == p.X && Y == p.Y && Z == p.Z);
        }
    }
}

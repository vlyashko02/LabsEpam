using System;

namespace lab7.BL
{
    public class Vector3
    {
        private readonly double x;
        private readonly double y;
        private readonly double z;

        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Length() => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

        public (double, double, double) GetVector => (x, y, z);

        public static Vector3 operator +(Vector3 vector1, Vector3 vector2) => 
            new Vector3(vector1.x + vector2.x, vector1.y + vector2.y, vector1.z + vector2.z);

        public static Vector3 operator *(Vector3 vector, double number) =>
            new Vector3(vector.x * number, vector.y * number, vector.z * number);

        public static double operator *(Vector3 vector1, Vector3 vector2) =>
            vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z;

        public static Vector3 VectorProduct(Vector3 vector1, Vector3 vector2) =>
            new Vector3((vector1.y * vector2.z) - (vector2.y * vector1.z), 
                -(((vector1.x * vector2.z) - (vector2.x * vector1.z))), 
                (vector1.x * vector2.y) - (vector2.x * vector1.y));

        public static double MixedProduct(Vector3 vector1, Vector3 vector2, Vector3 vector3) =>
                (vector1.x * vector2.y * vector3.z + vector2.x * vector3.y * vector1.z + vector1.y * vector2.z * vector3.x) - 
                (vector1.z * vector2.y * vector3.x + vector1.x * vector2.z * vector3.y + vector1.y * vector2.x * vector3.z);

        public bool CompareTo(Vector3 vector)
        {
            if (x == vector.x && y == vector.y && z == vector.z)
                return true;
            else
                return false;
        }

        public override string ToString() => $"({x},{y},{z})";
    }
}

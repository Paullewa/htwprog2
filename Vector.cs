namespace Klassendiagramme
{
     public class Vector : PointVectorBase
    {

        public static Vector XDir { get {
                return new Vector(new Point(1, 0, 0));
            } 
        }
    

        public static Vector YDir { get {
                return new Vector(new Point(0, 1, 0));
            }
        }


        public static Vector ZDir { get {
                return new Vector(new Point(0, 0, 1));
            }}


        public double Length { get; set; }


        public Vector (int x, int y, int z) : this(new Point(x, y, z))
        {
        }

        public Vector(Point point) 
        {
            this.X = point.X;
            this.Y = point.Y;
            this.Z = point.Z;
            this.Length = this.BaseLength();
        }

        public Vector()
        {
            
        }


        public Vector Add(params Vector[] vecs)
        {
            Vector vector = new Vector();
            foreach (Vector v in vecs) 
            {
                vector.X += v.X;
                vector.Y += v.Y;
                vector.Z += v.Z;
            }
            return vector;
        }

        public void AddToMe(params Vector[] vecs)
        {
            foreach (Vector v in vecs)
            {
                this.X += v.X;
                this.Y += v.Y;
                this.Z += v.Z;
            }      
        }

        public Vector MultiplyBy(double fac) 
        {
            Vector vector = new Vector();
            vector.X = this.X * fac;
            vector.Y = this.Y * fac;
            vector.Z = this.Z * fac;
            return vector;
        }
   
        public void MultiplyMeBy(double fac) 
        {
            this.X *= fac;
            this.Y *= fac;
            this.Z *= fac;
        }
           
        public double DotProduct(Vector v2)
        {  
            return this.X * v2.X + this.Y * v2.Y + this.Z * v2.Z;
        }

        public Vector CrossProduct(Vector v2)
        {
            Vector vector = new Vector();
            vector.X = this.Y * v2.Z - this.Z * v2.Y;
            vector.Y = this.Z * v2.X - this.X * v2.Z;
            vector.Z = this.X * v2.Y - this.Y * v2.X;
            return vector;
        }

        public Vector Normalize() 
        {
            Vector vector = new Vector();
            vector.X = Vector.XDir.X;
            vector.Y = Vector.YDir.Y;
            vector.Z = Vector.ZDir.Z;
            return  vector;
        }


        public void NormalizeMe()
        {
            this.X = Vector.XDir.X;
            this.Y = Vector.YDir.Y;
            this.Z = Vector.ZDir.Z;
        }

        public string ToString() 
        {
            return null;
        }

        public int GetHashCode() 
        {
            return 0;
        }
    }
}

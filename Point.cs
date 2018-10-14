namespace Klassendiagramme
{
    public class Point : PointVectorBase
    {

        public static Point Origin { get {
                return new Point();   
            }
        }

        public Point()
        {

        }

        public Point(int X, int Y, int Z) 
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }


        public Point Add(Vector vec)
        {
            Point point = new Point();
            point.X = Origin.X + vec.X;
            point.Y = Origin.Y + vec.Y;
            point.Z = Origin.Z + vec.Z;
            return point;
        }


        public void AddToMe(PointVectorBase pointVec)
        {
            Origin.X += pointVec.X;
            Origin.Y += pointVec.Y;
            Origin.Z += pointVec.Z;
        }

        public Vector AsVector()
        {
            
            return new Vector(this);
        }

        public double DistanceTo(Point Point2)
        {
            return this.BaseDistanceTo(Point2);
        }


        public string ToString()
        {
            return null;
        }
        public bool Equals()
        {
            return false;
        }

        public int GetHashCode() 
        {
            return 0;    
        }

    }
}
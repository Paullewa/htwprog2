using  System;
namespace Klassendiagramme
{
    public class PointVectorBase
    {

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static double Tolerance { get; } = 1e-6;


        public PointVectorBase() : this(0,0,0)
        {}


        public PointVectorBase(double X, double Y, double Z) {
            this.X = X;
            this.Y = Y;
            this.Z = Z; 
        }


        protected double BaseLength() 
        {
            return BaseDistanceTo(this);
        }

        protected double BaseDistanceTo(PointVectorBase pvb)
        {
            return Math.Sqrt(this.X * pvb.X + this.Y * pvb.Y + this.Z * pvb.Z);
        }

        protected void AddToThis(params PointVectorBase [] pvbs) 
        {
            foreach (PointVectorBase pvb in pvbs) 
            {
                this.X += pvb.X;
                this.Y += pvb.Y;
                this.Z += pvb.Z;
            }
             
        }

       
    }
}

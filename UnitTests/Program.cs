using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests
{

    class Conus
    {

        

        private double radius,heigth;

        public double Radius 
        {
            get { return radius;  }
            set { radius = value; }
        }

        public double Heigth
        {
            get { return heigth; }
            set { heigth = value; }
        }

       
        public double GetVolume()
        {

            return  radius *radius *Math.PI* heigth/3;
        }

        public double GetException()
        {
            if (radius <= 0 || heigth <= 0 )
                return -1;
            else
                return GetVolume();
        
        }


        public Conus(double radius, double heigth)
        {
            Radius = radius;
            Heigth = heigth;
            
        }
      
      
    }

    class Program
    {
        static void Main(string[] args)
        {
           Conus box = new Conus(2,3);
           Console.WriteLine(box.GetVolume());
           Console.ReadLine();
        }
    }
}

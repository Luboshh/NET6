using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Point
    {

        public Point(string X, string Y)
        {
            SouradniceX = X;
            SouradniceY = Y;
           
        }

        public string SouradniceX { get; set; }

        public string SouradniceY { get; set; }

        public string GetFullGPS()
        {
            return SouradniceX + " " + SouradniceY;
        }
    }
}

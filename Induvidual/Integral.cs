using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LibIntegral
{
    public class Integral
    {
        public string Formula { get; set; }
        public double Xmax { get; set; }
        public double Xmin { get; set; }
        public double Dx { get; set; }
        public double LeftRectangle { get; set; }
        public double RightRectangle { get; set; }
        public double Trap { get; set; }
        public double Simpson { get; set; }
        public Integral(string formula, double xmax, double xmin, double dx, double leftRectangle, double rightRectangle, double trap,  double simpson)
        {
            Formula = formula;
            Xmin = xmin;
            Xmax = xmax;
            Dx = dx;
            LeftRectangle = leftRectangle;
            RightRectangle = rightRectangle;
            Trap = trap;
            Simpson = simpson;
        }
        public Integral()
        {
            
        }
    }
}

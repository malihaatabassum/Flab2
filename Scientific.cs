using System;
using System.Collections.Generic;
using System.Text;

namespace Flab2
{
  
        class Scientific : IScientific
        {

            public int Root(a)
            {
                int root = Math.Sqrt(a);
                return root;
            }

            public int AtoB(a, b)
            {
                int atob = Convert.ToInt32(Math.Pow(a, b));
                return atob;
            }
        }
    }


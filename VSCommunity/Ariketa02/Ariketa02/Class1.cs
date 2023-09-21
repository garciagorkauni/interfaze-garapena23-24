using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa02
{
    internal class Eragiketa
    {
        public int a
        {
            get; set;
        }
        public int b
        {
            get; set;
        }
        public int c
        {
            get; set;
        }
        public int d
        {
            get; set;
        }

        public void eragiketaKalkulatu()
        {
            String formula = "(a+2b+3c+4d)/4";
            Array karaktereak = formula.Split("");
            for (int i = 0; i < karaktereak.Length; i++)
            {
                switch (karaktereak[i])
                {
                    case a:
                        // code block
                        break;
                    case y:
                        // code block
                        break;
                    default:
                        // code block
                        break;
                }

            }
        }
    }
}

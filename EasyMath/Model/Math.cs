using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath.Model
{
    public class Math
    {
        public static decimal Somar(decimal firstvalue, decimal secondvalue)
        {
            return firstvalue + secondvalue;
        }

        public static decimal Subtrair(decimal firstvalue, decimal secondvalue)
        {
            return firstvalue - secondvalue;
        }

        public static decimal Multiplicacao(decimal firstvalue, decimal secondvalue)
        {
            return firstvalue * secondvalue;
        }

        public static decimal Divisao(decimal firstvalue, decimal secondvalue)
        {
            return firstvalue / secondvalue;
        }
    }
}

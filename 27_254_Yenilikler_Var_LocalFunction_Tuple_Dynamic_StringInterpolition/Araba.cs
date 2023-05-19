using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_254_Yenilikler_Var_LocalFunction_Tuple_Dynamic_StringInterpolition
{
    public class Araba
    {
        private string plaka;
        public string Plaka
        {
            get
            {
                return this.plaka;
            }
            set
            {
                this.plaka = value;
            }
        }
        public string Marka { get; set; }
        public Araba()
        {
            
        }
    }
}

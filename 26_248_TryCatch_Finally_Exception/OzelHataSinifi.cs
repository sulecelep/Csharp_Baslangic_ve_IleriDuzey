using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_248_TryCatch_Finally_Exception
{
    public class OzelHataSinifi:Exception
    {
        public OzelHataSinifi()
        {
            Console.WriteLine("Özel hata sınıfı oluştu");
        }
    }
}

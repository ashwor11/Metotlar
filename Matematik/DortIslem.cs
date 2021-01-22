using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Matematik
{
    class DortIslem
    {
        public void Toplama(params int [] sayilar)
        {
            Console.WriteLine(sayilar.Sum()); 
        }
    }
}

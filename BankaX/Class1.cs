using System;
using System.Collections.Generic;
using System.Text;

namespace BankaX
{
    class Class1
    {
        public void Pitaj()
        {
            if(this is Class2)
            {
                Console.WriteLine("TRUE");
            }
          else
                Console.WriteLine("FALSE");

        }
    }
}

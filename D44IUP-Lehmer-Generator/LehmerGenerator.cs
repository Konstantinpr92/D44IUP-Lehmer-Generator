using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D44IUP_Lehmer_Generator
{
   public class LehmerGenerator
    {
        uint A, B, C;
        decimal Xi = 12345M;
        //констуктор, с параметрами по-умолчанию    
        public LehmerGenerator(uint A = 1103515245, uint B = 12345, uint C = 2147483648, decimal Xi = 12345M)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.Xi = Xi;
        }

        //метод возращает число из интервала [0, 1). 
        public decimal Lemer()
        {
            Xi = (A * Xi + B) % C;
            return Xi / C;
        }
        //метод возращает целое число число из интервала [0, 99]. 
        public int LemerN(int min = 0, int max = 100)
        {
            return (int)((max - min) * Lemer() + min);
        }

    }
}

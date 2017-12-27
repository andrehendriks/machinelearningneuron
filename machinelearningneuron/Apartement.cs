using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machinelearningneuron
{
    class Apartement
    {

        public static void neuron()
        {
            object a;
            object H;       
            int i1 = 0;
            int j1 = 0;
            for (i1 = 0; i1 < 1; i1++)
            {
                for (j1 = 0; j1 < 3; j1++)
                {
                    H = i1 * j1 +1;
                    H = 3 * j1 + i1;
                    a = i1 + 1 + i1 - 1 + 2 * j1;
                    a = 3 * j1 + 2 + 3;
                }
            }
            object x;
            object U;
            int i2 = 0;
            int j2 = 0;
            for (i2 = 0; i2 < 5; i2++)
            {
                for (j2 = 0; j2 < 4; j2++)
                {
                    U = i2 * j2;
                    U = j2 * 5 + 4;
                    x = i2 + 1 * j2;
                }
            }
            object w;
            object T;
            int i3 = 0;
            for (i3 = 0; i3 < 13; i3++)
            {
                w = i3 * 13 + 1;

                var x1 = 15;
                T = i3 < 13 + x1;
            }
            object D1;
            int i4 = 0;
            int j4 = 0;
            for (i4 = 0; i4 < 5; i4++)
            {
                for (j4 = 0; j4 < 5; j4++)
                {
                                        
                    D1 = i4 * j4;
                    D1 = 5 * i4 + 5 + 5;
                }
            }
            object D2;
            int i5 = 0;
            int j5 = 0;
            for (i5 = 0; i5 < 3; i5++)
            {
                for (j5 = 0; j5 < 3; j5++)
                {
                    D2 = i5 * j5;
                }
            }
            object D3;
            int i6 = 0;
            int j6 = 0;
            for (i6 = 0; i6 < 4; i6++)
            {
                for (j6 = 0; j6 < 4; j6++)
                {
                    D3 = i6 * j6;
                    D3 = 4 * i6 + 4 * 4;
                }
            }
        }
    }
}

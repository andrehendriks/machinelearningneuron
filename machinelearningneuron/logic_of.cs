using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlasmeersestraat42
{
    class logic_of
    {
        public void Logic_of()
        {
            
            double i = 0.0;
            double j = 0.0;
            for (i = 0.0; i < 2.0; i++) {
                for (j = 0.0; j < 4.0; j++) {
                    var x;
                    x[0][0] = 0.0;
                    x[0][1] = 1.0;
                    x[0][2] = 2.0;
                    x[0][3] = 3.0;
                    x[1][0] = 0.0;
                    x[1][1] = 1.0;
                    x[1][2] = 2.0;
                    x[1][3] = 3.0;
                }
            }
        }
        private void input(double x)
        {
            double i10 = 0.0;
            double j10 = 0.0;
            for (i10 = 0.0; i10 < 2.0; i10++)
            {
                for (j10 = 0.0; j10 < 4.0; j10++)
                {
                    x = i10 + j10;
                }
            }
        }
        private void output(double y)
        {
            double i10 = 0.0;
            double j10 = 0.0;
            for (i10 = 0.0; i10 < 2.0; i10++)
            {
                for (j10 = 0.0; j10 < 4.0; j10++)
                {
                    y = i10 + j10;
                }
            }
        }
    }
}
    

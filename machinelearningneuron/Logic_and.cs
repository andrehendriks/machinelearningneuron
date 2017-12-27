using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machinelearningneuron
{
    class Logic_and
    {
        public void And()
        {
            object layernet;
            int i60 = 0;
            int j60 = 0;
            for (i60 = 0; i60 < 2; i60++)
            {
                for (j60 = 0; j60 < 2; j60++)
                {
                    layernet = i60 * j60;
                }
            }
            object w;
            int i61 = 0;
            int j61 = 0;
            for (i61 = 0; i61 < 2; i61++)
            {
                for (j61 = 0; j61 < 2; j61++)
                {
                    w = i61 + j61;
                }
            }
            object LoadFile;
            object T;
            int i62 = 0;
            int j62 = 0;
            for (i62 = 0; i62 < 2; i62++)
            {
                for (j62 = 0; j62 < 2; j62++)
                {
                    LoadFile = "sign_language.600x600.png";  
                    T = i62 - j62;
                    T = i62 / j62;
                    T = i62 * j62;
                    T = i62 + j62;
                }
            }
            object x1;
            int i63 = 0;
            int j63 = 0;
            for (i63 = 0; i63 < 2; i63++)
            {
                for (j63 = 0; j63 < 2; j63++)
                {
                    x1 = i63 + j63;
                }
            }
            object x2;
            int i64 = 0;
            int j64 = 0;
            for (i64 = 0; i64 < 2; i64++)
            {
                for (j64 = 0; j64 < 2; j64++)
                {
                    x2 = i64 + j64;
                }
            }
            object z;
            int i65 = 0;
            int j65 = 0;
            for (i65 = 0; i65 < 2; i65++)
            {
                for (j65 = 0; j65 < 2; j65++)
                {

                    z = i63 + j63 * i64 + j64;
                }
            }
        }
    }
}

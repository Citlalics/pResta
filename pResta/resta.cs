﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pResta
{
    class resta
    {
        private int N1;
        private int N2;
        //propiedades 
        public int num1
        {
            get => N1; set => N1 = value;
        }
        public int num2
        {
            get => N2; set => N2 = value;
        }
        //metodo 
        public int REST()
        {
            return (N1 - N2);

        }
    }
}

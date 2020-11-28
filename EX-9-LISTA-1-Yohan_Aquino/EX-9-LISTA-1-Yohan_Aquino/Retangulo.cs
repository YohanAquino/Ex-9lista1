using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_9_LISTA_1_Yohan_Aquino
{
    class Retangulo
    {
        private double b;
        private double h;
        private double a;

        public void setBase(double x)
        {
            b = x;
        }

        public void setAltura(double x)
        {
            h = x;
        }
        public void calcularArea()
        {
            a = b * h;
        }
        public double getArea()
        {
            return a;
        }

        public string getTamanho() 
        {
            if (a>100) 
            {
                return "terreno grande";
            }
            else 
            {
                return "terreno pequeno";
            }
        }
    }
}

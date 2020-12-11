using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_9_LISTA_1_Yohan_Aquino
{
    class Retangulo
    {
        #region atributos
        private double basE;
        private double altura;
        private double area;
        #endregion;

        #region construtor

        public Retangulo() 
        {
            basE = 0;
            altura = 0;
        }

        public Retangulo(double basE,double altura)
        {
            this.basE = basE;
            this.altura = altura;
        }
        #endregion;

        #region metodos set e gets
        public void setBase(double basE)
        {
            this.basE = basE;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public double getArea()
        {
            return area;
        }

        public string getTamanho() 
        {
            if (area>100) 
            {
                return "terreno grande";
            }
            else 
            {
                return "terreno pequeno";
            }
        }
        #endregion;

        #region metodos funcionais
        public void calcularArea()
        {
            area = basE * altura;
        }
        #endregion;
    }
}

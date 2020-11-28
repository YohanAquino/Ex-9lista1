using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_9_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10. Calcular e exibir a área de um retângulo, a partir dos valores da base e altura que serão
digitados. Se a área for maior que 100, exibir a mensagem “Terreno grande”, caso contrário, exibir
a mensagem “Terreno pequeno”. */
            Retangulo ret = new Retangulo();

            Console.Write("Informe a base do retângulo: ");
            ret.setBase(double.Parse(Console.ReadLine()));

            Console.Write("Informe a altura do retângulo: ");
            ret.setAltura(double.Parse(Console.ReadLine()));

            ret.calcularArea();

            Console.WriteLine("O retângulo tem uma área igual a {0} e pelo padrão um {1} .", ret.getArea(), ret.getTamanho());
            Console.ReadKey();

        }
    }
}

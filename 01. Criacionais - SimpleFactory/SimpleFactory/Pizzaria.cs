using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Pizzaria
    {
        public static void SolicitaPizza()
        {
            Console.WriteLine("********* Pizzaria *********");
            Console.WriteLine("Informe a Pizza (C)alabresa ou (M)ussarela: \n");
            var tipoPizza = Console.ReadLine().ToUpper();

            try
            {
                Pizza pizza = PizzaSimpleFactory.CriaPizza(tipoPizza);
                pizza.Preparar();
                pizza.Assar(10);
                pizza.Embalar();
                Console.WriteLine("Pizza concluída!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}

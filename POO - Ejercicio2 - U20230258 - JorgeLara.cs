using System;

namespace Lab1_tarea1_ejercicio2_U20230258
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personalizar personalizar = new Personalizar();
            personalizar.Name = "Perseo";
            personalizar.Buy();


            Semi dios = new Semi();

            Console.WriteLine("Ingrese el radio del semi: ");
            int radius = int.Parse(Console.ReadLine());

            dios.Radius = radius;
            dios.CalculateArea();


            Dios Zeus = new Dios();
            Dios Ares = new Dios();

            Ares = null;
            GC.Collect();


            Palabras.DisplayMessage("Perseo (en griego antiguo, Περσεύς) es un semidiós de la mitología griega, hijo de Zeus y de la mortal Dánae y esposo de Andrómeda. La tradición le atribuía la fundación de Micenas.");
        }

    }
}

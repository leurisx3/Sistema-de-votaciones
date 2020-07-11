using System;

namespace Sistema_de_votaciones
{
    class Program
    {   
        static void Main(string[] args)
        {
           //Creando random y variable con valor de 1001

            Random aleatory = new Random();
            int n1 = 1001;

            //Consiguiendo votos y dividiendo votos entre los 4 candidatos.

            int[] votos = new int[4];
            for (int i = 0; i != votos.Length; i++)
            {
                votos[i] = aleatory.Next(0, n1); ;
                n1 = n1 - votos[i];
            }

            //Consiguiendo porcentaje de los votos de cada candidato

            double[] porciento = new double[4];
            for (int i = 0; i != porciento.Length; i++)
            {
                porciento[i] = Convert.ToDouble(votos[i]);
                porciento[i] = (porciento[i] * 100) / 1000;
            }

            //Colocandolos en orden descendente

            ReverseIntegerArray(votos);
            ReverseDoubleArray(porciento);

            //Mostrando resultados

            Console.WriteLine("Fundado el 9 de septiembre de 2014, Partido Revolucionario Moderno (PRM)");
            NombreCandidato("PRM", "Luis Abinadel");
            Console.WriteLine($"Sus votos fueron: {votos[0]} su porcentaje fue de: {porciento[0]}%");
            SeparaTexto();

            Console.WriteLine("Fundado el 15 de diciembre de 1973, Partido de la Liberacion Dominicana (PLD)");
            NombreCandidato("PLD", "Gonzalo Castillo");
            Console.WriteLine($"Sus votos fueron: {votos[1]} su porcentaje fue de: {porciento[1]}%");
            SeparaTexto();

            Console.WriteLine("Fundado el 20 agosto de 1900, Partido Reformista Social Cristiano (PRSC)");
            NombreCandidato("PRSC", "Leonel Fernandez");
            Console.WriteLine($"Sus votos fueron: {votos[2]} su porcentaje fue de: {porciento[2]}%");
            SeparaTexto();

            Console.WriteLine("Fundado el 20 de febrero de 2011, Alianza Pais (ALPAIS)");
            NombreCandidato("ALPAIS", "Guillermo Moreno");
            Console.WriteLine($"Sus votos fueron: {votos[3]} su porcentaje fue de: {porciento[3]}%");
        }
        static void NombreCandidato(string partido, string nombre)
        {
            Console.WriteLine($"({partido}) {nombre} aspira a: (PRESIDENTE)");
        }

       static void SeparaTexto()
        {
            Console.WriteLine("");
        }

        static void ReverseIntegerArray(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Array.Sort(num);
                Array.Reverse(num);
            }
        }

        static void ReverseDoubleArray(double[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Array.Sort(num);
                Array.Reverse(num);
            }
        }
    }
}
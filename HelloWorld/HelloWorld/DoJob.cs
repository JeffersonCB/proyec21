using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Trabajo
    {
        public void Realicelo()
        {
            Jugar();
           
        }

        public void Jugar()
        {
            var laClase = new Veintiuno.Naipe.Acciones.Barajar();
            var elMaso = laClase.DemeNuevoMaso();

            int jugador1 = 0;
            Console.WriteLine(string.Format("el jugador uno lleva : " + jugador1 + "\n Desea continuar? \n"));

            bool salida = false;
            while (salida == false)
            {

                Console.Write("1º) Dame carta\n" + " " + "2º) Basta\n" + "3º) Salir\n");
            Console.Write("Seleccione una opción: ");

                
                switch (Console.Read())
                {
                    case '1':
                        if (jugador1 > 21)
                        {
                            Console.WriteLine(string.Format("\n *********perdio********"));
                            break;
                        }
                        else
                        {
                            var laCarta = elMaso.DemeCartaDeEncima();
                            Console.WriteLine(string.Format("\nLa carta es {0} de {1}", laCarta.Numero, laCarta.ElPalo.ToString()));
                            Console.Write("\n dar otra carta\n");

                            jugador1 = jugador1 + laCarta.Valor;
                            Console.WriteLine(string.Format("el jugador uno lleva : " + jugador1 + "\n Desea continuar? \n"));
                            break;
                        }
                    case '2':
                        Console.Write("basta");
                        // Continuar lógica y extraer métodos //
                        break;

                    case '3':
                        Console.Write("         Saliendo...");
                        salida = true;
                        break;

                }
                Console.ReadKey();
                Console.ReadLine();
            }
           

        }
    }
}
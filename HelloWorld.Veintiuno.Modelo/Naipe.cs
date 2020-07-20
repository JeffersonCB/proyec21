using System;
using System.Security.Authentication.ExtendedProtection;
using System.Xml;

namespace HelloWorld.Veintiuno.Modelo
{
    public class Naipe
    {
        private int _contador = 0;

        
        
        private Carta[] Barajar(Carta[] elMaso)
        {
            for (int a = 0; a < 100; a++)
            { 
            //List<T> arr = input;
            //List<T> arrDes = new List<T>();

            //Random randNum = new Random();
            //while (arr.Count > 0)
            //{
            //    int val = randNum.Next(0, arr.Count - 1);
            //    arrDes.Add(arr[val]);
            //    arr.RemoveAt(val);
            //}

            //return arrDes;

            Random rand = new Random();
            //Carta[] MasoFinal = new Carta[52];

            int n = rand.Next(elMaso.Length);
            var movimiento = elMaso[n];
                String cambio = elMaso[0].Numero;
                Palo cambio2 = elMaso[0].ElPalo;
                int cambio3 = elMaso[0].Valor;
                elMaso[0].ElPalo = movimiento.ElPalo;
            elMaso[0].Valor = movimiento.Valor;
            elMaso[0].Numero = movimiento.Numero;

                elMaso[n].Valor =cambio3;
                elMaso[n].ElPalo = cambio2;
                elMaso[n].Numero = cambio;

                


                //Console.WriteLine(movimiento.ElPalo + movimiento.Numero);
                //for (int i = 0; i < elMaso.Length; i++)
                ////{ 
                //    Console.WriteLine(elMaso[i].ElPalo + " -_-_- " + elMaso[i].Numero + " -_-_- ");
                //if (elMaso[i].Valor==0) { 

                //}
                //else
                //{
                //    MasoFinal[i] = elMaso[i];

                //}
                /*Console.WriteLine(MasoFinal[i].ElPalo + " -_-_- " + MasoFinal[i].Numero + " -_-_- ");*/

                //}

                //for (int i = 0; i < MasoFinal.Length; i++) { 
                //    Console.WriteLine(MasoFinal[i].ElPalo + " -_-_- " + MasoFinal[i].Numero + " -_-_- " );
                //}
            }
            return elMaso;
        }

        public Carta DemeCartaDeEncima()
        {
            
            return elMaso[_contador++];
        }

        private void CrearCartasDelPalo (ref int contador, ref Carta[] elResultado, Palo elPalo)
        {
            elResultado[contador++] = new Carta("A", elPalo);
            for (int i = 2; i <= 10; i++)
            {
                elResultado[contador++] = new Carta(i, elPalo);
            }
            elResultado[contador++] = new Carta("J", elPalo);
            elResultado[contador++] = new Carta("Q", elPalo);
            elResultado[contador++] = new Carta("K", elPalo);
        }

        private Carta[] _elMaso = new Carta[52];

        public Carta[] elMaso
        {
            get { return _elMaso; }
            set {  }
        }
        public Naipe()
        {
            Carta[] elResultado = new Carta[52];
            int contador = 0;
            CrearCartasDelPalo(ref contador, ref elResultado, Palo.Corazones);
            CrearCartasDelPalo(ref contador, ref elResultado, Palo.Espadas);
            CrearCartasDelPalo(ref contador, ref elResultado, Palo.Diamantes);
            CrearCartasDelPalo(ref contador, ref elResultado, Palo.Treboles);
            /*
             elResultado[contador++] = new Carta("A", Palo.Corazones);
             for (int i = 2; i < 10; i++)
             {
                 elResultado[contador++] = new Carta(i, Palo.Corazones);
             }
             elResultado[contador++] = new Carta("J", Palo.Corazones);
             elResultado[contador++] = new Carta("Q", Palo.Corazones);
             elResultado[contador++] = new Carta("K", Palo.Corazones);

             elResultado[contador++] = new Carta("A", Palo.Espadas);
             for (int i = 2; i < 10; i++)
             {
                 elResultado[contador++] = new Carta(i, Palo.Espadas);
             }
             elResultado[contador++] = new Carta("J", Palo.Espadas);
             elResultado[contador++] = new Carta("Q", Palo.Espadas);
             elResultado[contador++] = new Carta("K", Palo.Espadas);

             elResultado[contador++] = new Carta("A", Palo.Treboles);
             for (int i = 2; i < 10; i++)
             {
                 elResultado[contador++] = new Carta(i, Palo.Treboles);
             }
             elResultado[contador++] = new Carta("J", Palo.Treboles);
             elResultado[contador++] = new Carta("Q", Palo.Treboles);
             elResultado[contador++] = new Carta("K", Palo.Treboles);

             elResultado[contador++] = new Carta("A", Palo.Diamantes);
             for (int i = 2; i < 10; i++)
             {
                 elResultado[contador++] = new Carta(i, Palo.Diamantes);
             }
             elResultado[contador++] = new Carta("J", Palo.Diamantes);
             elResultado[contador++] = new Carta("Q", Palo.Diamantes);
             elResultado[contador++] = new Carta("K", Palo.Diamantes);
             */
            elResultado.CopyTo(elMaso, 0);
            elMaso = Barajar(elMaso);
            //for (int i = 0; i < elMaso.Length; i++)
            //{

            //    Console.WriteLine(elMaso[i].ElPalo + " -_-_- " + elMaso[i].Numero + " -_-_- " + elMaso[i].Valor);
            //}

        }

    }
}

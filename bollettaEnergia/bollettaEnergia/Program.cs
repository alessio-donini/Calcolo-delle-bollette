using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bollettaEnergia
{
    class Program
    {
        class stufaElettrica
        {
            public double rendimento;
            public double costoSistema;
            public stufaElettrica(double rendimento, double costoSistema)
            {
                this.rendimento = rendimento;
                this.costoSistema = costoSistema;
            }
            public double Costo(double consumo)//calcolo per trovare il costo della bolletta (0.3 è il costo della corrente)
            {
                return (consumo / rendimento) * 0.3 + costoSistema;
            }

        }

        class pompaEconomica
        {
            public double rendimento;
            public double costoSistema;
            public pompaEconomica(double rendimento, double costoSistema)
            {
                this.rendimento = rendimento;
                this.costoSistema = costoSistema;
            }
            public double Costo(double consumo)//calcolo per trovare il costo della bolletta (0.3 è il costo della corrente)
            {
                return (consumo / rendimento) * 0.3 + costoSistema;
            }

        }

        class pompaBuona
        {
            public double rendimento;
            public double costoSistema;
            public pompaBuona(double rendimento, double costoSistema)
            {
                this.rendimento = rendimento;
                this.costoSistema = costoSistema;
            }
            public double Costo(double consumo)//calcolo per trovare il costo della bolletta (0.3 è il costo della corrente)
            {
                return (consumo / rendimento) * 0.3 + costoSistema;
            }

        }



        class caldaiaTradizzionale 
        {
            public double rendimento;
            public double costoSistema;
            public caldaiaTradizzionale(double rendimento, double costoSistema)
            {
                this.rendimento = rendimento;
                this.costoSistema = costoSistema;
            }
            public double Costo(double consumo)//calcolo per trovare il costo della bolletta(1.05 è il costo arrotondato del gas)
            {
                return (consumo / rendimento) * 1.05 + costoSistema;
            }

        }
        class caldaiaCondensazione
        {
            public double rendimento;
            public double costoSistema;
            public caldaiaCondensazione(double rendimento, double costoSistema)
            {
                this.rendimento = rendimento;
                this.costoSistema = costoSistema;
            }
            public double Costo(double consumo)//calcolo per trovare il costo della bolletta(1.05 è il costo arrotondato del gas)
            {
                return (consumo / rendimento) * 1.05 + costoSistema;
            }

        }
      
        static void Main(string[] args)
        {
            int scelta = 0;
            double consumoCorrente=0;
            double consumoGas = 0;
            double bollettaStufa, bollettaCaldaiaC, bollettaCaldaiaT, bollettaPompaEconomica, bollettaPompaBuona = 0;
            
            stufaElettrica stufa = new stufaElettrica(1,213); //1 stà a sgnificare il rendimento della sufa e 213 il costo extra
            caldaiaCondensazione caldaiaC = new caldaiaCondensazione(1, 213);
            caldaiaTradizzionale caldaiaT = new caldaiaTradizzionale(0.9, 213);
            pompaEconomica pompaE = new pompaEconomica(2.8, 1213);//2.8 è il rendimento della pompa economica, mentre il 1213 è il costo di 1000 euro di installazione + 213 di spese extra
            pompaBuona pompaB = new pompaBuona(3.6, 3213);//3.6 è il rendimento della pompa buona, mentre il 3213 è il costo di 3000 euro di installazione + 213 do spese extra
            
                Console.WriteLine("Scegli il metodo ri riscaldamento che ti aggrada di più: \n" +
                              "Premi 1 se preferisci il riscaldamento con il gas\n" +
                              "Premi 2 se preferisci il riscaldamento con l'energia elettrica\n");


            scelta = Convert.ToInt32(Console.ReadLine());

            switch (scelta) // Assegnazione metodo di riscaldamento tramite la variabile scelta
            {
                case 1:
                       
                       
                        Console.WriteLine("Inserisci quanti SMC di gas hai consumato per riscaldarti:\n");
                    consumoGas = Convert.ToDouble(Console.ReadLine());
                    consumoCorrente = consumoGas / 10.7;//serve per convertire il consumo della corrente in consumo del gas
                    bollettaCaldaiaC = caldaiaC.Costo(consumoGas);
                    bollettaStufa = stufa.Costo(consumoCorrente);
                    bollettaCaldaiaT = caldaiaT.Costo(consumoGas);
                    bollettaPompaBuona = pompaB.Costo(consumoCorrente);
                    bollettaPompaEconomica = pompaE.Costo(consumoCorrente);
                    Console.WriteLine("\nIl costo della bolletta con una caldaia a condensazione è: {0} euro.\n", bollettaCaldaiaC);
                    Console.WriteLine("Il costo della bolletta con una caldaia tradizionale è : {0} euro. \n ", bollettaCaldaiaT);
                    Console.WriteLine("Il costo della bolletta con una stufa è: {0} euro. \n", bollettaStufa);
                    Console.WriteLine("Il costo della bolletta con una pompa di calore economica è: {0} euro.\n ", bollettaPompaEconomica);
                    Console.WriteLine("Il costo della bolletta con una pompa di calore di buon livello è: {0} euro.\n ", bollettaPompaBuona);
                    break;
               
                case 2:
                   
                        
                        Console.WriteLine("Inserisci quanti Kwh di corrente elettrica hai consumato per il riscaldamento:\n");
                    consumoCorrente = Convert.ToDouble(Console.ReadLine());
                    consumoGas = consumoCorrente * 10.7;// serve per convertire il consumo del gas in cosumo della corrente
                    bollettaCaldaiaC = caldaiaC.Costo(consumoGas);
                    bollettaStufa = stufa.Costo(consumoCorrente);
                    bollettaCaldaiaT = caldaiaT.Costo(consumoGas);
                    bollettaPompaBuona = pompaB.Costo(consumoCorrente);
                    bollettaPompaEconomica = pompaE.Costo(consumoCorrente);
                    Console.WriteLine("\nIl costo della bolletta con una caldaia Tradizzionale è: {0} euro.\n", bollettaCaldaiaT);
                    Console.WriteLine("Il costo della bolletta con una stufa è : {0} euro. \n ", bollettaStufa);
                    Console.WriteLine("Il costo della bolletta con una caldaia a condensazione è: {0} euro. \n", bollettaCaldaiaC);
                    Console.WriteLine("Il costo della bolletta con una pompa di calore economica è: {0} euro.\n ", bollettaPompaEconomica);
                    Console.WriteLine("Il costo della bolletta con una pompa di calore di buon livello è: {0} euro.\n ", bollettaPompaBuona);
                    break;
            }
            Console.ReadKey();
        }
    }
}

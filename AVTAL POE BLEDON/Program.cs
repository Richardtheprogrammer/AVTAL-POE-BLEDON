using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;


namespace AVTAL_POE_BLEDON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PATH OF EXILE AVTAL MED MONGO";
            MENU();
        }
        static void MENU()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("välj din meny");
            Console.WriteLine("1)REGLER");
            Console.WriteLine("2)AVTAL");
            Console.WriteLine("3)PRISER");
            Console.WriteLine("4)UNDERSKRIFT");

            
            ConsoleKeyInfo meniselection;
            meniselection = Console.ReadKey(true);

            switch (meniselection.KeyChar)
            {

                case '1':
                    Console.WriteLine("REGLER");
                    Console.WriteLine("JA JAG HAR NÅGRA ENKLA REGLER SOM DU BÖR FÖLJA FÖR GÖRA DET ROLIGT FÖR OSS BÅDA 2");
                    Console.WriteLine("REGEL NUMMER 1");
                    Console.WriteLine("ANVÄND LEGENDARY SÅ MYCKET DU BARA KAN PGA DU DÖR SÄLLAN DÅ OCH DU GÖR MER DPS");
                    Console.WriteLine("OM DET SKULLE VARRA SÅ ATT DU INTE KAN DÅ MEDDELA MIG I GOD TID FÖRE TACK");
                    Console.WriteLine("ORSAKEN ÄR ATT JAG PLANNERAR IN VAD SOM SKA GÖRAS DAG EFTER DAG SÅ BLIR KLAR");
                    Console.WriteLine("I GOD TID SÅ DRF JAG BER DIG MEDDELA MIG I GOD TID OM EJ KAN ELLER OM DU VILL KÖRA SENARE");
                    Console.WriteLine("SEN OCKSÅ ATT DÖDA TILLSAMMANS DÅ MENAR JAG ATT DU INTE BARA STICKER IVÄG UTAN VI KÖR TSM");
                    Console.WriteLine("JAG ACCEPTERAR AVTALET OCH LOVAR OCH FÖLJA ORDERS OCH MEDDELAR I GOD TID");
                    Console.ReadKey();
                    Console.Clear();
                    MENU();
                    break;


                case '2':
                    Console.WriteLine("AVTAL");
                    Console.WriteLine("AVTALET GÄLLER BARA ATT DU FÖLJER REGLERNA THAT´S ALL");
                    Console.ReadKey();
                    Console.Clear();
                    MENU();
                    break;

                case '3':
                    Console.WriteLine("PRISER");
                    Console.WriteLine("DET KOSTAR INGET OFC MEN OM DET FINNS GEAR DU BEHÖVER DÅ TA IT SÅ CP DYRA ITEMS BARA ANNARS HAR DU BRO PRIS VI KAN DISKUTERA OM DET");
                    Console.ReadKey();
                    Console.Clear();
                    MENU();
                    break;

                case '4':
                    Console.WriteLine("TA EN SKÄRMKLIPP PÅ DETTA SÅ ÄR DET SOM DIN UNDERSKRIFT/MONGO");
                    Console.WriteLine("UNDERSKRIFT");
                    Console.WriteLine("JAG");
                    Console.WriteLine("ACCEPTERAR");
                    Console.WriteLine("AVTALET");
                    Console.WriteLine("MED");
                    Console.WriteLine("MONGO");
                    Console.WriteLine("OCH");
                    Console.WriteLine("VILL");
                    Console.WriteLine("SPELA/LEVLA");
                    Console.WriteLine("MED HONOM");
                    Console.ReadKey();
                    Console.Clear();
                    MENU();
                    break;





            }
        }
    }
}

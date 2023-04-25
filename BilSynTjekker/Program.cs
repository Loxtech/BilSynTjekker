// TypeGrouping Branch

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using BilSynTjekker;

namespace BilSynTjekker;

class MainClass
{
    public static void Main(string[] args)
    {
        //// De to mulig biler med farbriksfej oprettet som "Bil" objekter
        //Bil Fiat = new Bil("Fiat", "Punto", 2010, "");
        //Bil Alfa = new Bil("Alfa Romeo", "Giulia", 2019, "");

        //// Samme to biler indsat i et array for at kunne måle brugerindput imod dem
        //Bil[] fejlbiler = new Bil[2];
        //fejlbiler[0] = Fiat;
        //fejlbiler[1] = Alfa;

        //// Flag som sørge for at do while loop bliver ved med at køre indtil brugeren vælger nej til at "Søge igen"
        //bool flag = true;
        //// do while loop som hele programmet udfoldes inden i
        //do
        //{
        //    // De fire parameter for brugerindput initialiseret
        //    string? Mærke = "";
        //    string? Model = "";
        //    int Årgang;
        //    string? SidstSynet = "";

        //    // Her spørg programmet brugeren om de tilsvarende oplysninger omkring bilen og de indlæses i variablerne
        //    Console.WriteLine("- x - Bil Syns Tjekker - x -\n");
        //    Console.Write("Indput venligst bilens Mærke: ");
        //    Mærke = Console.ReadLine();
        //    Console.Write("Indput venligst bilens Model: ");
        //    Model = Console.ReadLine();
        //    Console.Write("Indput venligst bilens Årgang: ");
        //    Årgang = Convert.ToInt32(Console.ReadLine());

        //    // Loop til fejltjekning af om brugenen indtaster dato på den bestemte måde (Her vil jeg have at de indtaster den spredt med et "."
        //    bool TjekTegn = true;
        //    do
        //    {
        //        // Hvis den senere metode "TjekTegn" kommer tilbage som false vil do while loopet køre igen og denne fejlbesked vil blive udskrevet
        //        if (TjekTegn == false)
        //        {
        //            Console.WriteLine("Fejl, indput dato delt op af \".\"");
        //        }

        //        Console.Write("Indput venligst bilens sidste synet dato(Brug \".\" til at opdele dag, måned og år): ");
        //        SidstSynet = Console.ReadLine();
        //        // Metode til at tjekke om dato er skrevet rigtigt
        //        TjekTegn = Udregninger.TjekTegn(SidstSynet);
        //    } while (TjekTegn == false);

        //    // Metode til at indtaste og udregne om bilen
        //    // Udregninger.DatoSplit(SidstSynet, Årgang);

        //    // Oprettelse af brugerindput som "Bil" objekt
        //    Bil bil = new Bil(Mærke, Model, Årgang, SidstSynet);

        //    // For-loop til at gennemtjekke array for mulige ligheder til brugens indput
        //    for (int i = 0; i < fejlbiler.Length; i++)
        //    {
        //        // Hvis det indputtet mærke, model samt årgang matcher med info fra array vil programmet gå ind i denne if sætning
        //        if (fejlbiler[i].mærke == bil.mærke && fejlbiler[i].model == bil.model && fejlbiler[i].årgang <= bil.årgang)
        //        {
        //            // I forhold til hvilke informationer der matchede vil den relevante af nedenstående to fejlbeskeder blive udskrevet.
        //            if (bil.mærke == Alfa.mærke)
        //            {
        //                Console.WriteLine("Bilen har følgende fabriksfejl: Udstødning ");
        //            }
        //            else if (bil.mærke == Fiat.mærke)
        //            {
        //                Console.WriteLine("Bilen har følgende fabriksfejl: Styretøjet ");
        //            }
        //        } // Hvis indtastede informationer ikke matcher med noget info fra array vil programmet i stedet fortsætte her.
        //        else
        //        {
        //            // Metoden "Udregninger.DatoSplit" tager de relevante parameter ind (SidstSynet og Årgang) og udregner om bilen skal til syn eller ej. 
        //            // Der er taget højde for om bilen er mere end 5 år gammel og efterfølgende om bilen har været til syn inden for de sidste to år 
        //            bool SynTjek = Udregninger.DatoSplit(SidstSynet, Årgang);

        //            // If sætning til udskriving af resultat om bilens skal til syn eller ej
        //            if (SynTjek == true)
        //            {
        //                Console.WriteLine("Bilen skal til syn");
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Bilen skal ikke synes");
        //                break;
        //            }
        //        }
        //    }

        //    // Søg igen funktion så brugeren ikke skal genåbne programmet hver gang
        //    Console.WriteLine("Vil du søge igen? [y/n]");
        //    // Initialisere variablen FejlTjek
        //    bool FejlTjek;
        //    do
        //    {
        //        // Tager brugerens indput og laver det "ToLower" 
        //        string Igen = Console.ReadLine().ToLower();
        //        // Metode til at tjekke om brugerens indput enten er Y eller N
        //        FejlTjek = Udregninger.FejlTjek(Igen);
        //        // If sætning til at få programmet til at reagere på den ønskede måde til brugerens indput
        //        if (FejlTjek == false)
        //        {
        //            Console.WriteLine("Indput venligst y for Ja eller n for Nej");
        //        }
        //        else if (Igen == "y")
        //        {
        //            Console.Clear();
        //        }
        //        else if (Igen == "n")
        //        {
        //            flag = false;
        //        }
        //    } while (FejlTjek == false);


        //} while (flag == true);

        // ------------------------------------------------
        // Arrays
        string[] bilmærker = new string[] { "Fiat", "Toyota", "Kia" };

        foreach (var item in bilmærker)
        {
            Console.WriteLine($"Fra array loop {item}");
        }

        // 2D Array
        Console.WriteLine("\n2D Array");

        string[,] bilmærker2D = new string[,] {
        {"Toyota", "Mazda", "Nissan"},
        {"Audi", "BMV", "Mercedes"}
        };

        // 2D Array
        Console.WriteLine("\nJagged Array");
        string[][] jArraybilmærker = new string[][] {
            new string[] {"Toyota", "Mazda", "Nissan", "Suzuki"},
            new string[] {"Audi", "BMV", "Mercedes"}
        };

        int firstDimension = bilmærker2D.GetUpperBound(0);
        int secondDimension = bilmærker2D.GetUpperBound(1);

        for (int i = 0; i <= firstDimension; i++)
        {
            for (int j = 0; j <= secondDimension; j++)
            {
                string res = bilmærker2D[i, j];
                Console.WriteLine($"Loop 2D array value: {res}");
            }
        }
        // 3D Array
        Console.WriteLine("\n3D Array");
        string[,,] bilmærker3D = new string[,,] 
        {
            { 
                {"Toyota", "Mazda", "Nissan"}, 
                {"Audi", "BMV", "Mercedes"} 
            },
            { 
                {"Suzuki", "Yamaha", "Kawasaki"}, 
                {"Harley", "Boss", "ARCH"} 
            }
        };

        firstDimension = bilmærker3D.GetUpperBound(0);
        secondDimension = bilmærker3D.GetUpperBound(1);
        int thirdDimension = bilmærker3D.GetUpperBound(2);

        for (int i = 0; i <= firstDimension; i++)
        {
            for (int j = 0; j <= secondDimension; j++)
            {
                for (int h = 0; h <= thirdDimension; h++)
                {
                    string res = bilmærker3D[i, j, h];
                    Console.WriteLine($"Loop 3D array value: {res}");
                }
                
            }
        }


        Console.WriteLine("\nList");
        List<string> lst1 = new List<string>();
        List<string> lst2 = new List<string>();

        List<List<String>> lstBilmærker2D = new List<List<string>>()
                {
                    new List<string>() { "Toyota", "Mazda", "Nissan" },
                    new List<string>() { "Audi", "BMV", "Mercedes" }

                };
        lstBilmærker2D.Add(lst1);
        lstBilmærker2D.Add(lst2);


        Console.WriteLine($"Bilmærke fra 2d Array: {bilmærker2D[0, 2]} {bilmærker2D[1, 2]}");
        Console.WriteLine($"Bilmærke fra List i List: {lstBilmærker2D[0][2]} {lstBilmærker2D[1][2]}");


        Console.WriteLine("\nDateTime format change eksempel 1");
        DateTime aDate = new DateTime(1971, 2, 23);

        aDate.ToString("dd/MM/yyyy");
        Console.WriteLine(aDate);


        Console.WriteLine("\nDateTime format change eksempel 2");
        string indputDato = "02.23.1971";
        string[] datoSplit = indputDato.Split('.');
        string dag = datoSplit[0];
        string måned = datoSplit[1];
        string år = datoSplit[2];
        string dato = måned + "/" + dag + "-" + år;
        Console.WriteLine(dato);


        var datetime = new DateTime(2017, 8, 24);
        Console.WriteLine(datetime.ToString("d"));
        Console.ReadKey();


    }

    
}

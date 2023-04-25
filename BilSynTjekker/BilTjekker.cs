using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilSynTjekker;

/// <summary>
/// Bil klassen som objekt, den har fire parameter som skal udfyldes vil oprettelse af ny Bil
/// </summary>
internal class Bil
{
    public string? mærke;
    public string? model;
    public int årgang;
    public string? sidstSynet;
    public Bil(string? Mærke, string? Model, int Årgang, string? SidstSynet)
    {
        mærke = Mærke;
        model = Model;
        årgang = Årgang;
        sidstSynet = SidstSynet;
    }
}

/// <summary>
/// Struct klassen til at have alle metoder der laver en eller anden slags udregning med parameter taget fra Program.cs
/// </summary>
internal struct Udregninger
{
    // DatoSplit metoden bruges til at udregne mængden af tid siden bilen har været til syn og om den skal igen.
    public static bool DatoSplit(string? indputDato, int årgang)
    {
        // Først splittes indputDato til dag, måned og år.
        string[] datoSplit = indputDato.Split('.');
        string dag = datoSplit[0];
        string måned = datoSplit[1];
        string år = datoSplit[2];

        // Herefter sammles de igen i det format som DateTime Datatypen forstår, "dt1" bliver variablen for den indtastet dato mens "dt2" bliver den aktuelle dag idag, variiablen "detteÅr" tager så info omkring årstallet fra "dt2"
        string dato = måned + "/" + dag + "/" + år;
        DateTime dt1 = DateTime.Parse(dato);
        DateTime dt2 = DateTime.Now;
        string detteÅr = dt2.Year.ToString();

        // De bilver begge brugt til at udregne forskellen mellem datoerne og mellem årstal individuelt
        var datoForskel = dt2.Subtract(dt1);
        int årForskel = Convert.ToInt32(detteÅr) - årgang;

        // Hvis "årForskel" er 5 eller mere vil programmet gå ind i følgende if sætning, da det betyder at bilen er mere end fem år gammel
        // Herefter bruges "datoForskel" til at tjekke om bilen har været til syn inde for de sidste to år (730 dage) og den korrekte bool værdi returneres til programmet
        if (årForskel >= 5)
        {
            if (datoForskel.Days >= 730)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    // TjekTegn metoden bruges til at tjekke om indtastet dato skrives på den bestemte måde jeg vil have, altså opdelt af "."
    public static bool TjekTegn(string x)
    {
        // En Try catch bruges til at tjekke om den indtastet dato kan splittes op ved brug af ".", hvis den kan returneres "true", hvis ikke returneres "false"
        try
        {
            string[] datoSplit = x.Split('.');
            string dag = datoSplit[0];
            string måned = datoSplit[1];
            string år = datoSplit[2];
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    // FejlTjek metoden bruges bare til at sikre at bruges indput til om det vil søge igen konkret er "y" eller "n" ellers returneres "false" og metoden køres igen
    public static bool FejlTjek(string x)
    {
        if (x == "y" || x == "n")
        {
            return true;
        }
        return false;
    }
}

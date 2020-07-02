using System;
using TRSFBrewery;
using static System.Console;


namespace TRSFBrewerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StyleCatalog style = new StyleCatalog();
            BreweriesCatalog breweriesCatalog = new BreweriesCatalog();
            BeerCatalog beerCatalog = new BeerCatalog();

            var stylescsv = @"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\ExerciseTRSF\BrewerySite\Files\styles.csv";
            var beerscleanedcsv = @"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\ExerciseTRSF\BrewerySite\Files\beers-cleaned.csv";
            var breweriescsv = @"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\ExerciseTRSF\BrewerySite\Files\breweries.csv";

           /* var s = style.getListStyles(stylescsv);
            foreach (var item in s)
            {
                Console.WriteLine(item.Id);
            }
            WriteLine("R-----------");
*/
            var d = breweriesCatalog.getListBreweries(breweriescsv);
            foreach (var item in d)
            {
                Console.WriteLine(item.City);
            }
            WriteLine("R-----------");
            
            /*
            var f = beerCatalog.SetListBeer(beerscleanedcsv);
            foreach (var item in f)
            {
                Console.WriteLine(item.abv);
            }
            WriteLine("R-----------");*/



        }
    }
}

using System;
using System.Collections.Generic;


namespace TRSFBrewery
{
    public class BeerCatalog : Loader
    {


        /// <summary>
        /// Transforma una la lineas en objetos 
        /// </summary>
        private Beer Parse(String[] Item)
        {
            Beer beer = new Beer();

            try
            {
                if (Item.Length >= 10)
                {
                    beer.Category = "null";
                    beer.StyleName = Item[2];
                    beer.Description = Item[9];
                    beer.GlassType = "null";
                    beer.Country = "null";
                    beer.abv = Item[5];
                    beer.ibu = Item[6];
                    beer.srm = Item[7];
                    beer.upc = Item[8];
                }
                return beer;
            }
            catch(Exception e)
            {
                return null;
            }


        }
        /// <summary>
        /// crea cuna lista Beer
        /// </summary>
        /// <param name="phatOfBre"></param>
        /// <returns></returns>

        public List<Beer> SetListBeer(String phatOfBre)
        {
            List<Beer> beers = new List<Beer> { };
            var beer = load(phatOfBre);
            foreach (var item in beer)
            {
                var Item = item.Split(',');

                beers.Add(Parse(Item));

            }
            return beers;
        }
    }

}
using System;
using System.Collections.Generic;


namespace TRSFBrewery
{
    public class BeerCatalog : Loader
    {
        /// <summary>
        /// Transforma una la lineas en objetos 
        /// </summary>
        private Beer Parse(String Item)
        {
            Beer beer = new Beer();

            try
            {
                var item = Item.Split(',');
                if (item.Length >= 10)
                {
                    beer.Category = "null";
                    beer.StyleName = item[2];
                    beer.Description = item[9];
                    beer.GlassType = "null";
                    beer.Country = "null";
                    beer.abv = item[5];
                    beer.ibu = item[6];
                    beer.srm = item[7];
                    beer.upc = item[8];
                }
                return beer;
            }
            catch (Exception e)
            {
                return null;
            }


        }
        /// <summary>
        /// crea cuna lista de tipo Beer
        /// </summary>
        /// <param name="phatOfBre"></param>
        /// <returns></returns>

        public List<Beer> SetListBeer(String phatOfBre)
        {
            List<Beer> beers = new List<Beer> { };
            var beer = load(phatOfBre);
            foreach (var item in beer)
            {

                var linetrue = Parse(item);
                if (linetrue != null)
                    beers.Add(linetrue);

            }
            return beers;
        }
    }

}
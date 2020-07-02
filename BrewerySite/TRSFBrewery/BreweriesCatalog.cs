using System;
using System.Collections.Generic;

namespace TRSFBrewery
{
    public class BreweriesCatalog : Loader
    {
        /// <summary>
        /// Transforma una la lineas en objetos 
        /// </summary>
        private Brewery Parse(String Item)
        {
            Brewery brewery = new Brewery();
            if (Item != "")
            {
                var item = Item.Split(',');
                if (item.Length >= 12)
                {
                    brewery.Name = item[1];
                    brewery.Address = item[2];
                    brewery.City = item[4];
                    brewery.State = item[5];
                    brewery.ZipCode = item[6];
                    brewery.Country = item[7];
                    brewery.Phone = item[8];
                    brewery.WebSitie = item[9];
                    brewery.Decription = item[11];
                }
            }

            return brewery;
        }
        /// <summary>
        /// Crea la lista del Breweries
        /// </summary>
        /// <param name="phatOfBreweries"></param>
        /// <returns></returns>
        public List<Brewery> getListBreweries(String phatOfBreweries)
        {
            List<Brewery> listBreweies = new List<Brewery> { };
            String[] rowBre_ = load(phatOfBreweries);
            foreach (var item in rowBre_)
            {
                listBreweies.Add(Parse(item));
            }

            return listBreweies;
        }
    }
}
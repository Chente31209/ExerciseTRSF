using System;
using System.Collections.Generic;

namespace TRSFBrewery
{
    public class StyleCatalog : Loader
    {

        /// <summary>
        /// Transforma una la lineas en objetos 
        /// </summary>
        private Style Parse(String Item)
        {
            Style style = new Style();
            if (Item != "")
            {
                var fields = Item.Split(',');
                if (fields.Length >= 3)
                {
                    style.Id =/*int.Parse(Item[0]);*/fields[0];
                    style.NameStyle = fields[3];
                }
            }
            return style;
        }

        /// <summary>
        /// llena la lista de estilos con los datos del archivo estilo 
        /// </summary>   
        public List<Style> getListStyles(String phatofstyles)
        {
            List<Style> Styles = new List<Style> { };
            String[] rowsStyles = load(phatofstyles);
            foreach (var item in rowsStyles)
            {
                Styles.Add(Parse(item));
            }

            return Styles;

        }
    }
}
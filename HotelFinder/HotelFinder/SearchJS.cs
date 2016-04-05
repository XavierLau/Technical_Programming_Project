using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelFinder
{
    /// <summary>
    /// Contains a single method that starts a google places search for hotels.
    /// </summary>
    static class SearchJS
    {
        /// <summary>
        /// Search used to find the bounds of a given city within a country.
        /// </summary>
        /// <param name="webBrowser">the webbrowser</param>
        /// <param name="city">the city to find bounds for</param>
        /// <param name="country">the country which the city is located in</param>
        public static void SearchCityBounds(WebBrowser webBrowser, string city, string country)
        {
            //return the value of the variable from within the javascript code
            object[] returnGeocoder = { "geocoder;" };
            //return the value of the variable from within the javascript code
            object[] returnMap = { "map;" };
            //calls the javascript eval function that parses string data into javascript code
            object geocoder = webBrowser.Document.InvokeScript("eval", returnGeocoder);
            //calls the javascript eval function that parses string data into javascript code
            object map = webBrowser.Document.InvokeScript("eval", returnMap);
            //parameters that are passed into the geocodeAddress javascript function
            object[] javascriptParam = { city, country, geocoder, map };
            webBrowser.Document.InvokeScript("geocodeAddress", javascriptParam);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterString
{
    //The solution is implemented as extension method because it is straight forward solution and 
    //should belong to the filtering pattern
    //If solution have to be implemented in  List<T> when T is a string than
    //The logic below have to be moved in separate method and developer needs to create one more extension method
    //for List<T>
    public static class FilterString
    {
        //The Extension Method to filter string array
        public static string Filter(this string[] str, string filter)
        {
            //Validatre null or empty
            if (filter == null || filter?.Trim()?.Length == 0)
            {
                throw new ArgumentNullException("Filter string is null or emptiy");
            }

            //Validate string length and letters only
            if (filter.Length < 6 || filter.Length > 6 || !filter.All((item) => char.IsLetter(item)))
            {
                throw new ArgumentException("String must be 6 letters long and letters only");
            }

            string startItem = string.Empty;
            string endItem = string.Empty;
            string compItem = string.Empty;

            //Search requested filter string in the string array
            foreach(var item in str)
            {
                if (item.Length < 6)
                {
                    //Test beginning of the filter
                    if (filter.StartsWith(item))
                    {
                        startItem = item;
                        continue;
                    }
                
                    //Test end of the filter
                    if (filter.EndsWith(item))
                    {
                        endItem = item;
                        continue;
                    }
                }
            else
                {
                    //Test if filter found
                    if (item.Equals(filter))
                    {
                        compItem = item;
                    }
                }
            }

            //If both parts of the filter exists and the filter has been found return filtered word otherway null
            return filter == compItem && filter == string.Format("{0}{1}", startItem, endItem) ? compItem : null;
        }
    }
}

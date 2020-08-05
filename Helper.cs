using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork3
{
    public static class Helper
    {
        public static string GetElementsString<T>(this List<T> list)
        {
            string result = "";
            
            for (int i = 0; i < list.Count; i++)
            {
                result += list[i].ToString();
                if (i < list.Count-1)
                {
                    result +=", ";
                }
            }
            result += ".";
            return result;
        }
        
        public static string ConditionalWhere<T>(this IEnumerable<T> collection, bool isOnlyEven, Func<T,bool> condition)
        {
            string result = "";
            if (isOnlyEven) 
            {
                var selectedItems = collection.Where(condition);
                foreach (var item in selectedItems)
                {
                    result += item.ToString() + ", ";
                }
            }
            else
            {
                foreach (var item in collection)
                {
                    result += item.ToString() + ", ";
                }
            }

           
            return result;
        }
    
    
    }
}

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
            //result += ".";
            return result;
        }
        
        public static List<T> ConditionalWhere<T>(this IEnumerable<T> collection, bool isOnlyEven, Func<T,bool> condition)
        {
            var result = new List<T>();
            if (isOnlyEven) 
            {
                var selectedItems = collection.Where(condition);
                foreach (var item in selectedItems)
                    result.Add(item);
            }
            else
            {
                result = (List<T>)collection;
            }
            
            //string str = "";
            //for (int i = 0; i < result.Count; i++)
            //{
            //    str += result[i];
            //    if (i < result.Count - 1)
            //    {
            //        str += ", ";
            //    }
            //}
            //Console.WriteLine(str);
            return result;
        }
    
    
    }
}

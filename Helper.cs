using System;
using System.Collections.Generic;


namespace HomeWork3
{
    public static class Helper
    {
        public static string GetElementsString(this List<int> list)
        {
            string str = "";
            foreach (var item in list)
            {
                str += $"{item} ,";  
            }
            return str;
        }
    }
}

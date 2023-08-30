using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAddRemove
{
    internal static class ArrayHelper
    {
        public static string[] Add(ref string[] arr, string name)
        {
            
            Array.Resize(ref arr, arr.Length + 1);
            arr[^1] = name;
            return arr;
        }
        public static string[] Remove(ref string[] arr, string value)
        {
            int num = Array.IndexOf(arr, value);
            if (num < 0) return arr;

            for (int i = num; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }

            Array.Resize(ref arr, arr.Length - 1);

            return arr;
        }
    }
}

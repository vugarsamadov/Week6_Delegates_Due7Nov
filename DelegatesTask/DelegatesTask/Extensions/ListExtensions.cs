using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTask.Extensions
{
    internal static class ListExtensions
    {
        public static void Dump<T>(this List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($">> {item}");
            }
        }
        public static void Dump<T>(this List<T> list, string prompt)
        {
            Console.WriteLine(prompt);
            Dump(list);
        }
    }
}

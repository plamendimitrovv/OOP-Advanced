using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.CustomListSorter
{
   public class Sorter<T>
        where T: IComparable<T>
    {
   public static CustomList<T> Sort(CustomList<T> list)
        {
            var sortedList = list
                .GetList()
                .OrderBy(x => x)
                .ToList();

            return new CustomList<T>(sortedList);
        }

    }
}

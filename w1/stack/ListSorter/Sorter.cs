using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSorter
{
    public class Sorter
    {
        public void Sort(string commaSeparatedString)
        {
            var elements = commaSeparatedString.Split(',').Select(x => int.Parse(x));

        }

        public override string ToString()
        {
            return string.Empty;
        }
    }
}

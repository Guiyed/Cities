using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class AreaComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return -Convert.ToInt32((x.Area - y.Area)*100);
        }
    }
}

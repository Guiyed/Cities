using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class StateComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return string.Compare(x.State, y.State);
        }    
    }
}

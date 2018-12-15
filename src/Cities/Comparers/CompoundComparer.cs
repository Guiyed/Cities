using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class CompoundComparer : IComparer<City>
    {
        public IList<IComparer<City>> Comparers = new List<IComparer<City>>();

        public int Compare(City x, City y)
        {
            //This method should use each of the comparers in Comparers in order.You'll first use Comparer[0] to compare x and y.
            //You only need to move on to the next comparer if the first comparer returns 0. For example, if you're comparing cities 
            //by state and then by population, when comparing St. Louis and New York, you don't need to compare population.
            //You know that St.Louis comes before New York because "Missouri" comes before "New York". 
            //However, when comparing St.Louis and Kansas City, you would need to compare population, since the cities are in the same state.
            //We suggest using a while loop to do this.
            int i = 0;
            
            if (Comparers[i].Compare(x, y) == 0)
            {
                while (Comparers[i].Compare(x, y) == 0)
                {
                    i++;   
                    if (i > Comparers.Count-1)
                    {
                        //index out of bounds because we found another exact match and no more comparers
                        i--;
                        break;
                    }
                }
            }


            return Comparers[i].Compare(x, y);
        }

    }
}

using System;
using System.Collections.Generic;

namespace arvSak
{
    class Databas
    {
        List<Sak> saks = new List<Sak>();

        public void Add(String name, String creator, DiskType type)
        {
            if(type == DiskType.DVD)
            {
                saks.Add(new DVD(name, creator));
            }
            else if (type == DiskType.CD)
            {
                saks.Add(new CD(name, creator));
            }
        }

        public void Print()
        {
            for (int i = 0; i < saks.Count; i++)
            {
                Console.Write(saks[i].ToString());
            }
            /*
                    can also use a foreach
             
             foreach(Sak saak in saks)
             {
                Console.Write(saks[i].ToString());
             }

             */
        }
    }
}

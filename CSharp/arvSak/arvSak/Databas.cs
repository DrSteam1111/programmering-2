using System;
using System.Collections.Generic;
using System.Text;

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

        public void SkrivUt()
        {
            for (int i = 0; i < saks.Count; i++)
            {
                Console.Write(saks[i].ToString());
            }
        }
    }
}

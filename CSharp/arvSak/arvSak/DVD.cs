using System;
using System.Collections.Generic;
using System.Text;

namespace arvSak
{
    class DVD : Sak
    {
        public DVD(String name, String regisor)
        {
            title = name;
            creator = regisor;
            type = DiskType.DVD;
        }
    }
}

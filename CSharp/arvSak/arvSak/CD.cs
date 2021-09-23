using System;
using System.Collections.Generic;
using System.Text;

namespace arvSak
{
    class CD : Sak
    {

        public CD(String name, String artist)
        {
            title = name;
            creator = artist;
            type = DiskType.CD;
        }
    }
}

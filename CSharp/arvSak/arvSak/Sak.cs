using System;
using System.Collections.Generic;
using System.Text;

namespace arvSak
{
    class Sak
    {
        public String title;
        public String creator;
        public DiskType type;

        public Sak()
        {
            title = "Unknown";
            creator = "Unknown";
            type = DiskType.NONE;
        }
    }
}

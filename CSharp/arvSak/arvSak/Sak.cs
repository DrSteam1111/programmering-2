using System;
using System.Collections.Generic;
using System.Text;

namespace arvSak
{
    abstract class Sak
    {
        protected String title;
        protected String creator;
        protected DiskType type;

        public Sak()
        {
            title = "Unknown";
            creator = "Unknown";
            type = DiskType.NONE;
        }
    }
}

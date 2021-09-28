using System;

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

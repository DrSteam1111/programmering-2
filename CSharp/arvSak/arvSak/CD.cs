using System;

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

        public override String ToString()
        {
            return type.ToString() + ", Name: " + title + "\n" + "Artist: " + creator + "\n\n";
        }
    }
}

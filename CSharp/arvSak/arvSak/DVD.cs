using System;

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
        
        public override String ToString()
        {
            return type.ToString() + ", Name: " + title + "\n" + "Regissör: " + creator + "\n\n";
        }
    }
}

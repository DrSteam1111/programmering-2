using System;
using System.Diagnostics.CodeAnalysis;

namespace DrillWpfFordon
{
    class Vehicle : IComparable<Vehicle>
    {
        // registratoin number
        private String regNummer;
        // owner
        private String carOwner;

        // konstruktor tar registeringsnummer som parameter
        // bara registreringsnummer
        public Vehicle(string regNummer)
        {
            this.regNummer = regNummer;
        }

        // property för att läsa registreringsnummer
        public String RegNummer
        {
            get => regNummer;
        }
        // property för att läsa och sätta ägare
        public String CarOwner
        {
            get => carOwner;
            set => carOwner = value;
        }

        public int CompareTo([AllowNull] Vehicle other)
        {
            if (other == null)
            {
                return -1;
            }
            else
            {
                return String.Compare(this.CarOwner, other.CarOwner);
            }
        }

        public override string ToString()
        {
            string append = "\nOwner: Unknown";
            if (!string.IsNullOrEmpty(carOwner))
                append = "\nOwner: " + carOwner;
            return "\n\nRegistration Number: " + regNummer + append;
        }

    }
}

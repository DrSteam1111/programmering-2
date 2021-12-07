using System;
using System.Collections.Generic;

namespace ParkingMachineConsole
{
    /// <summary>
    /// An object of the class ParkingMachine represents a parking machine.
    /// 
    /// Insert money first. 
    /// 
    /// Then buy a ticket or select cancel to refund.
    /// </summary>
    public class ParkingMachine
    {

        // There is two places to save money.
        // Total in the machine, from all finnished purchases.
        private int total;

        // Total for the current customer.
        private int currentTotal;

        // Cost to park.
        private int costPerHour;

        public int CurrentTotal { get { return currentTotal; } }

        public int Total { get { return total; } }

        public ParkingMachine()
        {
            total = 0;
            currentTotal = 0;
            costPerHour = 20;
        }

        public void InsertMoney(int v)
        {
            if (v >= 0)
            {
                currentTotal = currentTotal + v;
            }
        }

        public int Cancel()
        {
            int r = currentTotal;
            currentTotal = 0;
            return r;
        }

        public string BuyTicket()
        {
            List<int> time = new List<int> { 0, 0, 0 };
            total = currentTotal + total;
            currentTotal = 0;

            int usableTotal = total;
            for (int i = (costPerHour * 24); i <= usableTotal; i = i + (costPerHour * 24))
            {
                time[0] = time[0] + 1;
            }
            usableTotal = usableTotal - (time[0] * (costPerHour * 24));
            for (int i = costPerHour; i <= usableTotal; i = i + costPerHour)
            {
                time[1] = time[1] + 1;
            }
            usableTotal = usableTotal - (time[1] * costPerHour);
            for (int i = (costPerHour / 4); i <= usableTotal; i = i + (costPerHour / 4))
            {
                time[2] = time[2] + 15;
            }

            return "Parking ticket valid for:" + Environment.NewLine +
                time[0] + " days" + Environment.NewLine +
                time[1] + " hours" + Environment.NewLine +
                time[2] + " minutes";
        }
    }
}

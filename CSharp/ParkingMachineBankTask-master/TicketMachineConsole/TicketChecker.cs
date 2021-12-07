using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class TicketChecker
    {
        public bool isValid(Ticket ticket)
        {
            DateTime time = ticket.GetValidTo();
            if (time <= DateTime.Now)
                return true;
            return false;
        }
    }
}

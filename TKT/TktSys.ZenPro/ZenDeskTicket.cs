using System;

namespace TktSys.ZenPro
{
    public class ZenDeskTicket
    {
        public Guid TicketNumber { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

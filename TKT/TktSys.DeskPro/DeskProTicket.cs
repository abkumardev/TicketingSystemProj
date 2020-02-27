using System;
using TktSys.Business.Entities;

namespace TktSys.DeskPro
{
    public class DeskProTicket
    {
        public Guid TicketId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime DateCreated { get; set; }
        public StatusEnum TicketStatus { get; set; }
        //public List<Task> Tasks { get; set; }
        //public TicketSystemTypeEnum TicketSystemType { get; set; }
    }
}

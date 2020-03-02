using System;
using System.Collections.Generic;
using System.Text;
using TktSys.Business.Entities;
using TktSys.Utility.Common;

namespace TktSys.DeskPro
{
    public class DeskProService : ITicketService
    {
        private readonly TicketSystemTypeEnum ticketType = TicketSystemTypeEnum.DeskPro;
        public Guid TicketId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime DateCreated { get; set; }
        public StatusEnum TicketStatus { get; set; }
        public TicketSystemTypeEnum TicketType
        {
            get
            {
                return this.ticketType;
            }
        }
        DeskProService deskProTicket;
        public Guid CreateTicket(Request request)
        {
            Guid requestId = Guid.Empty;
            deskProTicket = new DeskProService();
            deskProTicket.EmployeeId = request.RequestResourceId;
            deskProTicket.DateCreated = request.CreatedDate;
            deskProTicket.TicketStatus = request.Status;
            GenericRepository<DeskProService> genericCRUD = new GenericRepository<DeskProService>();
            return genericCRUD.Post(deskProTicket, "deskProAPIUrl");
        }
    }
}

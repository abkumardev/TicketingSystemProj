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
        public TicketSystemTypeEnum TicketType
        {
            get
            {
                return this.ticketType;
            }
        }
        DeskProTicket deskProTicket;
        public Guid CreateTicket(Request request)
        {
            Guid requestId = Guid.Empty;
            deskProTicket = new DeskProTicket();
            deskProTicket.EmployeeId = request.RequestResourceId;
            deskProTicket.DateCreated = request.CreatedDate;
            deskProTicket.TicketStatus = request.Status;
            GenericRepository<DeskProTicket> genericCRUD = new GenericRepository<DeskProTicket>();
            return genericCRUD.Post(deskProTicket, "deskProAPIUrl");
        }
    }
}

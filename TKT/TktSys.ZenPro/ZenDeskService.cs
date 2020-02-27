using System;
using System.Collections.Generic;
using System.Text;
using TktSys.Business.Entities;
using TktSys.Utility.Common;

namespace TktSys.ZenPro
{
    public class ZenDeskService : ITicketService
    {
        private readonly TicketSystemTypeEnum ticketType = TicketSystemTypeEnum.ZenDesk;
        public TicketSystemTypeEnum TicketType
        {
            get
            {
                return this.ticketType;
            }
        }
        ZenDeskTicket zenDeskTicket;
        public Guid CreateTicket(Request request)
        {
            Guid requestId = Guid.Empty;
            zenDeskTicket = new ZenDeskTicket();
            zenDeskTicket.EmployeeId = request.RequestResourceId;
            zenDeskTicket.CreatedOn = request.CreatedDate;
            GenericRepository<ZenDeskTicket> genericCRUD = new GenericRepository<ZenDeskTicket>();
            return genericCRUD.Post(zenDeskTicket, "ZenDeskAPIUrl");
        }
    }
}

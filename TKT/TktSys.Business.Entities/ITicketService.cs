using System;
using System.Collections.Generic;
using System.Text;

namespace TktSys.Business.Entities
{
    public interface ITicketService
    {
        TicketSystemTypeEnum TicketType { get; }
        Guid CreateTicket(Request request);
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace TktSys.Business.Entities
{
    public interface ITicketService
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(PropertyName = "ticketSystemType")]
        TicketSystemTypeEnum TicketType { get; }
        Guid CreateTicket(Request request);
    }
}

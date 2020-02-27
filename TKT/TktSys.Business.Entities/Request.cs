using System;
using System.Collections.Generic;
using System.Text;

namespace TktSys.Business.Entities
{
    public class Request
    {
        public Guid RequestUId { get; set; }
        public Guid RequestId { get; set; }
        public Guid RequestResourceId { get; set; }
        public string RequestCreator { get; set; }
        public DateTime CreatedDate { get; set; }
        public TicketSystemTypeEnum TicketSystemType { get; set; }
        public StatusEnum Status { get; set; }
        //public List<Task> Tasks { get; set; }
    }
}

using DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.DomainModels
{
    public class Client : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<ClientJob> ClientJobs { get; set; }
        public ICollection<ClientMessage> ClientMessage { get; set; }
        public ICollection<ClientGroup> ClientGroup { get; set; }
    }
}

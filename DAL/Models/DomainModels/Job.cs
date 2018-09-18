using DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.DomainModels
{
    public class Job : BaseEntity<int>
    {
        public string Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateComplete { get; set; }


        public ICollection<ClientJob> ClientJobs { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}

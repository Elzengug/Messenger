using DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.DomainModels
{
    public class Message : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public int JobId { get; set; }

        public ICollection<ClientMessage> ClientMessages { get; set; }
        public Job Job { get; set; }
    }
}

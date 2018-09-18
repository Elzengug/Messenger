using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Models.DomainModels
{
    public class ClientMessage
    {
        public DateTime Date { get; set; }
        public string State { get; set; }
        public int ClientId { get; set; }
        public int MessageId { get; set; }

        public Client Client { get; set; }
        public Message Messenge { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.DomainModels
{
    public class ClientJob
    {
        public int JobId { get; set; }
        public int ClientId { get; set; }

        public Client Client { get; set; }
        public Job Job { get; set; }
    }
}

using DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.DomainModels
{
    public class ClientGroup: BaseEntity<int>
    {
        public int GroupId { get; set; }
        public int ClientId { get; set; }

        public Group Group { get; set; }
        public Client Client { get; set; }
    }
}

using DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.DomainModels
{
    public class Group : BaseEntity<int>
    {
        public string Name { get; set; }

        public ICollection<ClientGroup> ClientGroups { get; set; }
    }
}

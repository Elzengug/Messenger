using DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.Authorization
{
    class User : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}

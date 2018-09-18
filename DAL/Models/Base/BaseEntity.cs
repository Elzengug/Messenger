using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.Base
{
        public abstract class BaseEntity<TKey>
        {
            public virtual TKey Id { get; set; }
        }
}

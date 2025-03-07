using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPark.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity() { }  

        public int Id { get; set; }
    }
}

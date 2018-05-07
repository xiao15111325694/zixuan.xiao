using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian
{
    public class Node : BaseEntity
    {
        public string NodeName { get; set; }
        public string Description { get; set; }
        public DateTime CreateOn { get; set; }
    }
}

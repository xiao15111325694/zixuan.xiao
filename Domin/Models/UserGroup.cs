using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domian
{
    public class UserGroup
    {
        public int ID { get; set; }

        public List<RoomGroup> Room { get; set; }
    }
}
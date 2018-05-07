using System;
using System.Collections.Generic;
using System.Text;

namespace Domian
{
    public class Paragraph:BaseEntity
    {
        public int NodeId { get; set; }
        public ParagraphNode Node { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public ParagraphType Type { get; set; }

        public DateTime CreateTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
    }
}

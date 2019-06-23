using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamTemplate.Models
{
    public class CardBody
    {
        public int Id { get; set; }
        public string MainTitle { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Icon { get; set; }
    }
}
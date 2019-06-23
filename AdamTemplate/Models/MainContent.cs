using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamTemplate.Models
{
    public class MainContent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int Date { get; set; }
        public string BigContent { get; set; }
    }
}
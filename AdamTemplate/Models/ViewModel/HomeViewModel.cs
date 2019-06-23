using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamTemplate.Models
{
    public class HomeViewModel
    {
        public ICollection<PhotoArea> PhotoAreas { get; set; }
        public ICollection<IconArea> IconAreas { get; set; }
        public MainContent MainContent { get; set; }

        public HeaderContent HeaderContent { get; set; }
        public ICollection<CardBody> cardBodies { get; set; }
    }
}
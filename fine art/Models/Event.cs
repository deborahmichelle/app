using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fine_art.Models
{
    public class @event
    {
        public int ID { get; set; }
        public string Events { get; set; }
        public int MyProperty { get; set; }
        public Student [] Students { get; set; }

        public Painting [] Paintings { get; set; }

        public Remarks [] RemarksOnPaintings { get; set; }
    }
}
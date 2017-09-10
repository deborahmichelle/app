using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fine_art.Models
{
    public class Remarks
    {
        public int ID { get; set; }
        public string Remarks { get; set; }
        public Staff [] RemarksOnPaintings { get; set; }
    }
}
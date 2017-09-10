using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fine_art.Models
{
    public class Painting
    {
        public int ID { get; set; }
        public string paintings { get; set; }
        public Student [] Students { get; set; }
        public Remarks [] Remarks { get; set; }

        
    }
}
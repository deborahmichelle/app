﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fine_art.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RemarksOnPainting { get; set; }
    }
}
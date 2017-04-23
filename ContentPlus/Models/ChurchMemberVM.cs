using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContentPlus.Models
{
    public class ChurchMemberVM
    {
        public int ID { get; set; }
        public int ChurchId { get; set; }
        public int PriestId { get; set; }
        public string PositionHeld { get; set; }
        public string Status { get; set; }
        public List<Church> Churches { get; set; }
        public List<Priest> Priests { get; set; }
    }
}
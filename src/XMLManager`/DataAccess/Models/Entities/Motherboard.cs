﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Motherboard
    {
        public int ID { get; set; }
        public string Alias { get; set; }
        public string Manufacturer { get; set; }
        public string Chipset { get; set; }
        public int Available { get; set; }
        public string Price { get; set; }
        public string SocketAlias { get; set; }

        public int? ProcessorID { get; set; }
        public virtual Processor Processor { get; set; }
        public int? VideoCardID { get; set; }
        public virtual VideoCard VideoCard { get; set; }
        public int? RamBoardID { get; set; }
        public virtual RamBoard RamBoard { get; set; }
        public int? HardDriveID { get; set; }
        public virtual HardDrive HardDrive { get; set; }
        public int? SocketID { get; set; }
        public virtual Socket Socket { get; set; }
    }
}

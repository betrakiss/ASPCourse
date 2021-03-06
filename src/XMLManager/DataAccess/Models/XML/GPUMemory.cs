﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    [Serializable]
    public class GPUMemory
    {
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlText]
        public string Amount { get; set; }
    }
}

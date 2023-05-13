﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PluginInterface
{
    public enum EndianEnum
    {
        [Display(Name = "无")] None = 0,
        [Display(Name = "大端")] BigEndian,
        [Display(Name = "小端")] LittleEndian,
        [Display(Name = "大端交换")] BigEndianSwap,
        [Display(Name = "小端交换")] LittleEndianSwap
    }
}

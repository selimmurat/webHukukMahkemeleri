﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class City:IEntity
    {
        public int Id { get; set; }
        public int city_code { get; set; }
        public string city_name { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public   class Book : IBaseEntity
    {
      public int ID { get; set; }
      public string Name { get; set; }
    }
}

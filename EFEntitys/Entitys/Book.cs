using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork
{
  public   class Book : BaseEntity
    {
      public int ID { get; set; }
      public string Name { get; set; }
    }
}

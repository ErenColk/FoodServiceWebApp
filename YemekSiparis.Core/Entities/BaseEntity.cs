﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparis.Core.Entities.Abstract;
using YemekSiparis.Core.Enums;

namespace YemekSiparis.Core.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get ; set ; }

        public Status Status { get; set; } 
        public DateTime CreatedDate { get ; set ; } 
        public DateTime ModifiedDate { get ; set ; }
        public DateTime DeletedDate { get ; set ; }
    }
}

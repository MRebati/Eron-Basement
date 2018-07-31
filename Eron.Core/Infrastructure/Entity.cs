﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eron.Core.Infrastructure
{
    public class Entity<TPrimaryKey>: IEntity
    {
        private TPrimaryKey Id { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintenance_tok4cz.Entitites
{
    public class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }

        }
}

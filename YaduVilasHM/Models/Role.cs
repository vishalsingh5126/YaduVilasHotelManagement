﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaduVilasHM.Models
{
    public class Role
    {
        public Role()
        {
            RoleId = 0;
            RoleName = "";
        }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}

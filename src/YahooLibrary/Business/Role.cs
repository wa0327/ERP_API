﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yahoo.DataAccess;

namespace Yahoo.Business
{
    /// <summary>
    /// 使用者角色。
    /// </summary>
    public class Role
    {
        private readonly RoleData data;

        internal Role(RoleData data)
        {
            this.data = data;
        }

        public string Name { get { return this.data.Name; } }

        public bool CanSelect { get { return this.data.CanSelect != null && this.data.CanSelect.Value; } }

        public bool CanInsert { get { return this.data.CanInsert != null && this.data.CanInsert.Value; } }

        public bool CanUpdate { get { return this.data.CanUpdate != null && this.data.CanUpdate.Value; } }

        public bool CanDelete { get { return this.data.CanDelete != null && this.data.CanDelete.Value; } }

        public bool CanParticular { get { return this.data.CanParticular != null && this.data.CanParticular.Value; } }
    }
}

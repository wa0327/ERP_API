﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yahoo.DataAccess;

namespace Yahoo.Business
{
    public class DefaultPrivilegeCollection : IPrivilegeCollection
    {
        private readonly IBusinessFactory factory;
        private readonly IUser user;

        public DefaultPrivilegeCollection(IBusinessFactory factory, IUser user)
        {
            this.factory = factory;
            this.user = user;
        }

        IEnumerator<IPrivilege> IEnumerable<IPrivilege>.GetEnumerator()
        {
            var dao = this.factory.GetPrivilegeDao();
            var data = dao.GetManyAsync(this.user.Id).Result;

            if (data == null)
            {
                data = new PrivilegeData[0];
            }

            return data.Select(o => CreatePrivilege(o)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var o = this as IEnumerable<IPrivilege>;
            return o.GetEnumerator();
        }

        void IPrivilegeCollection.Add(string url)
        {
            throw new NotImplementedException();
        }

        IPrivilege IPrivilegeCollection.Find(string url)
        {
            var dao = this.factory.GetPrivilegeDao();
            var data = dao.GetOneAsync(this.user.Id, url).Result;

            if (data == null)
            {
                return null;
            }

            return CreatePrivilege(data);
        }

        protected virtual IPrivilege CreatePrivilege(PrivilegeData data)
        {
            return new DefaultPrivilege(this.factory, this.user, data);
        }
    }
}

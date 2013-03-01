﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Yahoo.DataAccess.Common.Resources;
using System.Threading.Tasks;

namespace Yahoo.DataAccess.Common
{
    public class PrivilegeDao : CommonDao, IPrivilegeDao
    {
        public PrivilegeDao()
            : base("security")
        {
        }

        Task<IEnumerable<PrivilegeData>> IPrivilegeDao.GetManyAsync(int userId)
        {
            var task = Task.Factory.StartNew<IEnumerable<PrivilegeData>>(() =>
            {
                using (var connection = base.CreateConnection())
                {
                    using (var dbCommand = connection.CreateCommand())
                    {
                        dbCommand.CommandType = CommandType.Text;
                        dbCommand.CommandText = base.Resource.GetString("GetManyAsync_userId.sql");

                        var userIdParameter = dbCommand.CreateParameter();
                        userIdParameter.ParameterName = "@user_id";
                        userIdParameter.Value = userId;
                        dbCommand.Parameters.Add(userIdParameter);

                        using (var reader = dbCommand.ExecuteReader())
                        {
                            return reader.ToObjects(r => new PrivilegeData
                            {
                                Url = r.GetString(0),
                                Name = r.GetString(1),
                            });
                        }
                    }
                }
            });

            return task;
        }

        Task<PrivilegeData> IPrivilegeDao.GetOneAsync(int userId, string url)
        {
            throw new NotImplementedException();
        }
    }
}

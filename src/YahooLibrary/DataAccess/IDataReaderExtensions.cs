﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Yahoo.DataAccess
{
    internal static class IDataReaderExtensions
    {
        public static IEnumerable<T> ToObjects<T>(this IDataReader reader, Func<IDataReader, T> converter) where T : class
        {
            var list = new List<T>();

            while (reader.Read())
            {
                var o = converter(reader);
                list.Add(o);
            }

            return list;
        }

        public static T ToObject<T>(this IDataReader reader, Func<IDataReader, T> converter) where T : class
        {
            var enumerator = reader.ToObjects<T>(converter).GetEnumerator();

            if (enumerator.MoveNext())
            {
                return enumerator.Current;
            }

            return default(T);
        }
    }
}

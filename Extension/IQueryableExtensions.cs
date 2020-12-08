using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace doublebattery.Extension
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> ApplyOrdering<T>(this IQueryable<T> query, IQueryObject queryObject, Dictionary<string, Expression<Func<T, object>>> ColumnMaping)
        {
            if (string.IsNullOrWhiteSpace(queryObject.SortBy) || !ColumnMaping.ContainsKey(queryObject.SortBy))
                return query;

            if (queryObject.IsSortAssending)
                return query = query.OrderBy(ColumnMaping[queryObject.SortBy]);
            else
                return query = query.OrderByDescending(ColumnMaping[queryObject.SortBy]);

        }
    }
}
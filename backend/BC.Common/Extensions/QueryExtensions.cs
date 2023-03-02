using BC.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BC.Common.Extensions
{
    public static class QueryExtensions
    {

        public static IQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, string orderByProperty, bool desc, bool isThenBy = false)
        {
            string command = isThenBy ? (desc ? "ThenByDescending" : "ThenBy") : (desc ? "OrderByDescending" : "OrderBy");
            var type = typeof(TEntity);
            orderByProperty = orderByProperty.Substring(0, 1).ToUpper() + (orderByProperty.Length > 1 ? orderByProperty.Substring(1).ToLower() : "");
            var property = type.GetProperty(orderByProperty);
            var parameter = Expression.Parameter(type, "p");
            var propertyAccess = Expression.MakeMemberAccess(parameter, property!);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);
            var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { type, property.PropertyType },
                                          source.Expression, Expression.Quote(orderByExpression));
            return source.Provider.CreateQuery<TEntity>(resultExpression);
        }

        public static IQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, string sqlOrderByList)
        {
            var ordebyItems = sqlOrderByList.Trim().Split(',');
            IQueryable<TEntity> result = source;
            bool useThenBy = false;
            foreach (var item in ordebyItems)
            {
                var splt = item.Trim().Split(' ');
                result = result.OrderBy(splt[0].Trim(), (splt.Length > 1 && splt[1].Trim().ToLower() == "desc"), useThenBy);
                if (useThenBy)
                    useThenBy = true;
            }
            return result;
        }

    }
}

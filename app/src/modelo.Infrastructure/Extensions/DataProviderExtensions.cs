using System;
using System.Linq;
using System.Linq.Expressions;
using modelo.Domain.Entities.Base;

namespace modelo.Infrastructure.Extensions
{
    public static class DataProviderExtensions
    {
        public static IQueryable<TEntity> WhereIdEquals<TEntity, TKey>(this IQueryable<TEntity> source, Expression<Func<TEntity, TKey>> KeyExpression, TKey otherKeyValue)
         where TEntity : Entity<TKey>
        {
            var memberExpression = (MemberExpression)KeyExpression.Body;
            var parameter = Expression.Parameter(typeof(TEntity), "x");
            var property = Expression.Property(parameter, memberExpression.Member.Name);
            var equal = Expression.Equal(property, Expression.Constant(otherKeyValue));
            var lambda = Expression.Lambda<Func<TEntity, bool>>(equal, parameter);
            return source.Where(lambda);
        }
    }
}

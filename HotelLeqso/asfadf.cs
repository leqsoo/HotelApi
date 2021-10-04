using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi
{
    public class asfadf
    {
        public Task<IList<T>> Get(System.Linq.Expressions.Expression<Func<T, bool>> expression, List<string> include = null)
        {
            IEnumerable<T> query = _dbSet;
            if (include != null)
            {
                foreach (var includeProperty in include)
                {
                    query = query.Include(includeProperty);
                }
            }

            return query.AsNoTrakcing.ToList();
        }
    }
}

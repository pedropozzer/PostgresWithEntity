using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityOnPostgres2
{
    public abstract class Model<T>
    {
        public static IEnumerable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            var x = new MyQueryTranslator().Translate(expression);

            return null;

        }
    }
}

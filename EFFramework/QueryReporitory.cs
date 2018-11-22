using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFramework
{
    public class QueryReporitory
    {
        private BaseDbContext uw;
        public QueryReporitory(BaseDbContext context)
        {
            this.uw = context;
        }

        public List<TM> GetSqlQuery<TM>(string sql, params object[] parameters)
        {
            return this.uw.Database.SqlQuery<TM>(sql, parameters).ToList();
        }
    }
}

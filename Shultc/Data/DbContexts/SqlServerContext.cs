using Microsoft.EntityFrameworkCore;

namespace Shultc.Data.DbContexts
{
	public class SqlServerContext:DbContext
	{
		public SqlServerContext(DbContextOptions options) : base(options)
		{

		}
	}
}

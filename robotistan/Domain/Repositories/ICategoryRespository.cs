using robotistan.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace robotistan.Domain.Repositories
{
	public interface ICategoryRespository
	{
		Task<IEnumerable<Category>> ListAsync();
	}
}

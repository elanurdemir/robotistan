using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using robotistan.Domain.Models;

namespace robotistan.Domain.Services
{
	interface ICategoryService
	{
		Task<IEnumerable<Category>> ListAsync();
	}
}

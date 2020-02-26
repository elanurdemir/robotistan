using robotistan.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using robotistan.Domain.Services;
using robotistan.Domain.Repositories;

namespace robotistan.Domain.Services
{
	public class CategoryService : ICategoryService
	{
        private readonly ICategoryRespository _categoryRepository;

        public CategoryService(ICategoryRespository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}

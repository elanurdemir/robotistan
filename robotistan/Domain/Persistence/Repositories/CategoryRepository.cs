using Microsoft.EntityFrameworkCore;
using robotistan.Domain.Models;
using robotistan.Domain.Persistence.Contexts;
using robotistan.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace robotistan.Domain.Persistence.Repositories
{
	
        public class CategoryRepository : BaseRepository, ICategoryRespository
        {
            public CategoryRepository(AppDbContext context) : base(context)
            {
            }

            public async Task<IEnumerable<Category>> ListAsync()
            {
                return await _context.Categories.ToListAsync();
            }

            Task<IEnumerable<Category>> ICategoryRespository.ListAsync()
            {
                throw new NotImplementedException();
            }
        }

    }


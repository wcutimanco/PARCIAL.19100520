using Microsoft.EntityFrameworkCore;
using PARCIAL._19100520.DOMAIN.Core.Interfaces;
using PARCIAL._19100520.DOMAIN.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL._19100520.DOMAIN.Infrastructure.Repositories
{
    public class AutoPartsRepository : IAutoPartsRepository
    {
        private readonly Parcial202402CodigoDbContext _dbcontext;

        public AutoPartsRepository(Parcial202402CodigoDbContext context)
        {
            _dbcontext = context;
        }

        public async Task<IEnumerable<AutoParts>> GetAutoParts()
        {
            var autoparts = await _dbcontext.AutoParts.ToListAsync();
            return autoparts;
        }
        public async Task<int> Insert(AutoParts autoParts)
        {
            await _dbcontext.AutoParts.AddAsync(autoParts);
            int rows = await _dbcontext.SaveChangesAsync();
            return rows;
        }

        public async Task<bool> Update(AutoParts autoParts)
        {
            _dbcontext.AutoParts.Update(autoParts);
            int rows = await _dbcontext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var autoparts = await _dbcontext.AutoParts.FindAsync(id);
            if (autoparts == null) return false;
            int rows = await _dbcontext.SaveChangesAsync();
            return rows > 0;
        }



    }
}

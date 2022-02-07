using Foodorder.DataLayer;
using FoodOrder.Models;
using FoodOrder.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Services.Repository
{
    public class Kategoriyarepository : ICategoriyaInterface
    {
        private readonly AppDbContext _dbContext;

        public Kategoriyarepository(AppDbContext dbContext)
        {
            _dbContext=dbContext;
        }
        public Task<Kategoriya> AddKategoriya(Kategoriya kategoriya)
        {
            _dbContext.KategoriyaLar.Add(kategoriya);
            _dbContext.SaveChanges();
            return Task.FromResult(kategoriya);
        }

        public Task DeleteKategoriya(Guid id)
        {
            Kategoriya kategoriya = _dbContext.KategoriyaLar.FirstOrDefault(m => m.Id == id);
            _dbContext.Remove(kategoriya);
            return Task.FromResult(0);
        }

        public Task<Kategoriya> GetKategoriya(Guid id)
        {
            var res = _dbContext.KategoriyaLar
                        .Include(m => m.Id)
                        .FirstOrDefault(k => k.Id == id);

            return Task.FromResult(res);
        } 

        public Task<List<Kategoriya>> GetKategoriyalar(Guid id)
        => _dbContext.KategoriyaLar.ToListAsync();

        public Task<Kategoriya> UpdateKategoriya(Kategoriya kategoriya)
        {
            _dbContext.KategoriyaLar.Update(kategoriya);
            return Task.FromResult(kategoriya);
        }
    }
}

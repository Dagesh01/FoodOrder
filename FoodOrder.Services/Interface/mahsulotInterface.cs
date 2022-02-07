using Foodorder.DataLayer;
using FoodOrder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Services.Interface
{
    internal class mahsulotInterface : ImahsulotInterface
    {
        private readonly AppDbContext _dbContext;

        public mahsulotInterface(AppDbContext dbContext)
        {
            _dbContext=dbContext;
        }
        public Task DeleteMahsulot(Guid id)
        {
            Mahsulot mahsulot = _dbContext.Mahsulotlar.FirstOrDefault(m=> m.Id == id);
            _dbContext.Remove(mahsulot);
            return Task.FromResult(0);
        }

        public Task<Mahsulot> GetMahsulot(Guid id)
        =>_dbContext.Mahsulotlar.FirstOrDefaultAsync(m=>m.Id == id);

        public Task<List<Mahsulot>> GetMahsulotlar()
       =>_dbContext.Mahsulotlar.ToListAsync();

        public Task<Mahsulot> AddMahsulot(Mahsulot mahsulot)
        {
            _dbContext.Mahsulotlar.Add(mahsulot);
            _dbContext.SaveChanges();
            return Task.FromResult(mahsulot);
        }

        public Task<Mahsulot> UpdateMahsulot(Mahsulot mahsulot)
        {
            _dbContext.Mahsulotlar.Update(mahsulot);
            return Task.FromResult(mahsulot);
        }
    }
}

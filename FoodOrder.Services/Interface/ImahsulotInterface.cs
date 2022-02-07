using FoodOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Services.Interface
{
    public interface ImahsulotInterface
    {

        Task<List<Mahsulot>> GetMahsulotlar();
        Task<Mahsulot> GetMahsulot(Guid id);
        Task<Mahsulot> AddMahsulot(Mahsulot mahsulot);
        Task<Mahsulot> UpdateMahsulot(Mahsulot mahsulot);
        Task DeleteMahsulot(Guid id);
    }
}

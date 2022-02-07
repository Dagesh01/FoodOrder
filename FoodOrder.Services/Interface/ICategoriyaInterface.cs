using FoodOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Services.Interface
{
    public interface ICategoriyaInterface
    {
        Task<List<Kategoriya>> GetKategoriyalar(Guid id);
        Task<Kategoriya>GetKategoriya(Guid id);
        Task<Kategoriya>AddKategoriya(Kategoriya kategoriya);
        Task<Kategoriya> UpdateKategoriya(Kategoriya kategoriya);
        Task DeleteKategoriya(Guid id);
    }
}

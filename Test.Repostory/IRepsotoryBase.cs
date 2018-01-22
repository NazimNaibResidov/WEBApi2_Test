using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Repostory
{
   public interface IRepsotoryBase<T> where T:class
    {
        List<T> GetAllList();
      
        bool AddItem(T entity);
        bool Delete(T entity);
        bool UpDate(T entity);
        
    }
}

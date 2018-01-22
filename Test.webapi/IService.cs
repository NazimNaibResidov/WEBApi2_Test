using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.webapi
{
    public interface IService<DTO> where DTO:class
    {
        List<DTO> GetAllList();
      
        void AddItem(DTO entity);
        void Delete(DTO entity);
        bool UpDate(DTO entity);
    }
}
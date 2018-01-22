using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Test.webapi.Controllers
{
    using Entity.Models;
    using DTO;
    using Repostory;
    using Extansion;
    public class BaseController<Rep, Entity, DTO> : ApiController, IService<DTO>
        where Entity : class
        where Rep : BaseRepsotory<Entity>
        where DTO : class
    {
        private Rep repsotory;

        public Rep Repsotory
        {
            get
            {

                repsotory = repsotory ?? Activator.CreateInstance<Rep>();
                return repsotory;
            }
            set { repsotory = value; }
        }

       
        public void AddItem(DTO entity)
        {
            repsotory.AddItem(entity.Maping<Entity>());
        }

        public void Delete(DTO entity)
        {
            throw new NotImplementedException();
        }


        [HttpGet]
        public List<DTO> GetAllList()
        {
            return Repsotory.GetAllList().Select(x => x.Maping<DTO>()).ToList();
        }

    
      
        
        public bool UpDate(DTO entity)
        {
            throw new NotImplementedException();
        }

    }
}

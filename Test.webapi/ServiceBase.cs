using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.webapi
{
    using Entity.Models;
    using DTO;
    using Repostory;
    using Extansion;
    public class ServiceBase<Rep,Entity,DTO> : IService<DTO>
        where Entity:class
        where Rep:BaseRepsotory<Entity>
        where DTO:class
       
      
    {
        private Rep repsotory;

        public Rep Repsotory
        {
            get {

                repsotory = repsotory ?? Activator.CreateInstance<Rep>();
                return repsotory; }
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

       
        
        public List<DTO> GetAllList()
        {
           return Repsotory.GetAllList().Select(x => x.Maping<DTO>()).ToList();
        }

        public DTO GetElementById(DTO entity)
        {
            throw new NotImplementedException();
        }

        public bool UpDate(DTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
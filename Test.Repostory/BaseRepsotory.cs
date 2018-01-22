using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entity.Models;

namespace Test.Repostory
{
    public class BaseRepsotory<T> : IRepsotoryBase<T> where T:class
    {
        private NORTHWNDContext context;

        public NORTHWNDContext Context
        {
            get {

                context = context ?? new NORTHWNDContext();
                return context; }
            set { context = value; }
        }


        public bool AddItem(T entity)
        {
            Context.Set<T>().Add(entity);
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool Delete(T entity)
        {

            Context.Set<T>().Remove(entity);
            try
            {
               return Context.SaveChanges() > 0;

            }
            catch (Exception)
            {

                return false;
            }


        }

        public List<T> GetAllList()
        {
           return Context.Set<T>().ToList();
        }

       

        public bool UpDate(T entity)
        {
            return false;
        }
    }
}

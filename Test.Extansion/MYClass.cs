using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test.Extansion
{
   public static class MYClass
    {
        public static T Maping<T>(this object source)
        {
            Type qaynag = source.GetType();
            T hedef = Activator.CreateInstance<T>();
         PropertyInfo [] qynaginf= qaynag.GetProperties();
PropertyInfo [] hedefinf= hedef.GetType().GetProperties();
            foreach (PropertyInfo item in hedefinf)
            {
              PropertyInfo inf=  qynaginf.FirstOrDefault(x => x.Name.ToUpper() == item.Name.ToUpper());
                if (inf!=null)
                {
                  var obj=  inf.GetValue(source);
                    item.SetValue(hedef, obj);

                }
            }
            return hedef;
        }
    }
}

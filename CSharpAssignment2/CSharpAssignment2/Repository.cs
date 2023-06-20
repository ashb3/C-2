using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment2
{
    public class Repository<T> where T : BaseEntity
    {
        public string Add(T entity)
        {
           
            return $"Added {typeof(T).Name}";
        }

        public string Update(T entity)
        {
           
            return $"Updated {typeof(T).Name}";
        }

        public string Delete(T entity)
        {
            
            return $"Deleted {typeof(T).Name}";
        }

        public string GetAll()
        {
            
            return $"Retrieved all {typeof(T).Name}";
        }


      
    }


}

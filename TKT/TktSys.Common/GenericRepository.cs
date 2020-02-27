using System;

namespace TktSys.Utility.Common
{
    public class GenericRepository<T>
    {
        public Guid Post(T obj, string apiURL)
        {
            // Would actually contain contain calling the Post method of the respective API which would be decided from the apiURL
            Guid requestId = Guid.NewGuid();
            return requestId;
        }

        public T GetById(object id)
        {
            T obj = (T)new Object();
            return obj;
        }
    }
}

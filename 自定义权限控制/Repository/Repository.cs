using System;
using System.Collections.Generic;


namespace 自定义权限控制.Repository
{
    interface Repository<T> where T:class
    {
        IEnumerable<T> FindAll(Func<T, bool> exp);
        void Add(T entity);
        void Delete(T entity);
        void Save();

    }
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace BusinessEntity
{
    public interface IReporsitory<T> where T : class
    {
        void Add(T obj);

        void Delete(T obj);

        IEnumerable<T> GetAll();
    }
}

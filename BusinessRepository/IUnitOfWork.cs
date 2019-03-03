using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRepository
{
    //unit of work
    public interface IUnitOfWork
    {
        int SaveDbChanges();
    }
}

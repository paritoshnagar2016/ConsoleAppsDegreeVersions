using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRepository
{
    public interface IUnitOfWork
    {
        int SaveDbChanges();
    }
}

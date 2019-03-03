using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace BusinessRepository
{
    public abstract class AppDbContext : DbContext
    {
        public AppDbContext(string strConnectionName)
            : base(strConnectionName)
        {
        }
    }
}

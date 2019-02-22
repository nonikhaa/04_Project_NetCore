using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace _04_Example_Entity.Data
{
    public class ContextProvider : IContextProvider
    {
        private DbContext dbContext;

        public DbContext GetContext()
        {
            throw new NotImplementedException();
        }

        public DbContext Initiate()
        {
            throw new NotImplementedException();
        }

    }
}

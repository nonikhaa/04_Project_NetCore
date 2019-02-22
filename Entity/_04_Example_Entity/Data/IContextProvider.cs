using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace _04_Example_Entity.Data
{
    public interface IContextProvider
    {
        DbContext Initiate();
        DbContext GetContext();
    }
}

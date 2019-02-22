using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04_Example.Models;

namespace _04_Example.Interface
{
    public interface IMenuMasterService
    {
        IEnumerable<MenuMaster> GetMenuMaster();
        IEnumerable<MenuMaster> GetMenuMaster(String UserRole);
    }
}

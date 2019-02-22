using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04_Example.Interface;
using _04_Example.Models;

namespace _04_Example.Services
{
    public class MenuMasterService : IMenuMasterService
    {
        private readonly ApplicationDbContext _dbContext;

        public MenuMasterService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IEnumerable<MenuMaster> GetMenuMaster()
        {
            return _dbContext.MenuMaster.AsEnumerable();
        }

        public IEnumerable<MenuMaster> GetMenuMaster(string UserRole)
        {
            var result = _dbContext.MenuMaster.Where(m => m.User_Roll == UserRole).ToList();
            return result;
        }
    }
}

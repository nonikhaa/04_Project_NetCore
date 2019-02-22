using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using _04_Example_Entity;

namespace _04_Example_Repository.CommonRepository
{
    public interface IRoleRepository
    {
        Task CreateAsync(RoleModel Entity);
        Task DeleteAsync(RoleModel Entity);
        Task UpdateAsync(RoleModel Entity);
        Task<List<RoleModel>> GetListData();
        Task<RoleModel> GetRoleByName(string name);
    }
}

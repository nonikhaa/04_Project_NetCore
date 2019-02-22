using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using _04_Example_Entity;
using _04_Example_Entity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace _04_Example_Repository.CommonRepository
{
    public class RoleRepository: IRoleRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private IServiceProvider services;

        public RoleRepository(ApplicationDbContext dbContext, IServiceProvider services)
        {
            _dbContext = dbContext;
            this.services = services;
        }

        public async Task CreateAsync(RoleModel Entity)
        {
            var RoleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            IdentityResult roleResult;

            var roleCheck = await RoleManager.RoleExistsAsync(Entity.RoleName);
            if (!roleCheck)
            {
                roleResult = await RoleManager.CreateAsync(new IdentityRole(Entity.RoleName));
            }

            _dbContext.Add(Entity);
            _dbContext.SaveChanges();
        }

        public async Task DeleteAsync(RoleModel Entity)
        {
            var RoleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            IdentityResult roleResult;

            var roleCheck = await RoleManager.RoleExistsAsync(Entity.RoleName);
            if (!roleCheck)
            {
                roleResult = await RoleManager.DeleteAsync(new IdentityRole(Entity.RoleName));
            }

            _dbContext.Remove(Entity);
            _dbContext.SaveChanges();
        }

        public async Task UpdateAsync(RoleModel Entity)
        {
            var RoleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            IdentityResult roleResult;

            var roleCheck = await RoleManager.RoleExistsAsync(Entity.RoleName);
            if (!roleCheck)
            {
                roleResult = await RoleManager.UpdateAsync(new IdentityRole(Entity.RoleName));
            }

            _dbContext.Update(Entity);
            _dbContext.SaveChanges();
        }

        public async Task<List<RoleModel>> GetListData()
        {
            List<RoleModel> listData = await _dbContext.RoleModel.ToListAsync();
            return listData;
        }

        public async Task<RoleModel> GetRoleByName(string name)
        {
            RoleModel data = await _dbContext.RoleModel.FirstOrDefaultAsync();
            return data;
        }
    }
}

using HenE.Aeolus.Beveiliging.DbContext;
using System;
using System.Linq;
//using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using HenE.Aeolus.Beveiliging.Domein;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

/*
            Aeolus_BeveiligingContext dbContext = new Aeolus_BeveiligingContext();

            var entity = dbContext.AspNetRoles
                                    .Include(role => role.RolePermissions)
                                    .ThenInclude(per => per.RolePermissionApiResources)
                                    .Single(a => a.Id == new Guid("63B8B8A9-4918-49BD-86A4-4647073FBB1A"));

            RolePermission aeolusRolePermission = new RolePermission()
            {
                Permissions = "iets",
                Id = Guid.NewGuid(),
            };

            aeolusRolePermission.RolePermissionApiResources.Add(new RolePermissionApiResource() { ApiResourceId = 2 });

            entity.RolePermissions.Add(aeolusRolePermission);
*/

            BeveiligingDbContext dbContext = new BeveiligingDbContext();

            var entity = dbContext.Roles
                        .Include(role => role.RolePermissions)
                        .Single(a => a.Id == new Guid("63B8B8A9-4918-49BD-86A4-4647073FBB1A"));

            AeolusRolePermission aeolusRolePermission = new AeolusRolePermission("iets", "");
            aeolusRolePermission.RolePermissionApiResources = new List<RolePermissionApiResource>();

            aeolusRolePermission.RolePermissionApiResources.Add(new RolePermissionApiResource(2, entity.Id));

            entity.RolePermissions.Add(aeolusRolePermission);

            dbContext.SaveChanges();





            AeolusRole roleEntity = dbContext.Roles
            .Include(role => role.RolePermissions)
            .Single(r => r.Id == entity.Id);

            roleEntity.RolePermissions = new List<AeolusRolePermission>() { new AeolusRolePermission("iets","")
            {
                RoleId = roleEntity.Id,
                RolePermissionApiResources = new List<RolePermissionApiResource>()
                {
                    new RolePermissionApiResource(3, entity.Id)                
                }

            } };

            dbContext.Roles.Update(roleEntity);
            dbContext.SaveChanges();

            Console.ReadLine();

        }
    }
}

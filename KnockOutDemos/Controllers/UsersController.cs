using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Http;
using KnockOutDemos.Infrastructure;
using KnockOutDemos.Models;

namespace KnockOutDemos.Controllers
{
    public class UsersController: ApiController
    {
        [ActionName("GetUsers")]
        public IEnumerable<RandomUser> Get()
        {
            EFDbContext context = new EFDbContext();
            return context.Users;
        }

        [ActionName("WriteUser")]
        public void Post([FromBody]RandomUser user)
        {
            EFDbContext context = new EFDbContext();
            context.Users.AddOrUpdate(p => new { p.LastName, p.FirstName }, user);
            context.SaveChanges();
        }
        
        [ActionName("DeleteUser")]
        public void Delete([FromBody]RandomUser user)
        {
            EFDbContext context = new EFDbContext();
            context.Users.Remove(user);
            context.SaveChanges();
        }
    }
}
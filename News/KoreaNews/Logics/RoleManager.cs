using KoreaNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KoreaNews.Logics
{
    public class RoleManager
    {
        public List<Role> GetAllRoles()
        {
            using (var context = new KoreaNewsContext())
            {
                return context.Roles.ToList();
            }
        }
    }
}

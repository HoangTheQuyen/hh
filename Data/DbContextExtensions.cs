using System;
using System.Collections.Generic;
using System.Linq;
using ECommerce.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
   public static class DbContextExtensions
  {
    public static RoleManager<AppRole> RoleManager { get; set; }
    public static UserManager<AppUser> UserManager { get; set; }

    public static void EnsureSeeded(this EcommerceContext context)
    {
     
    }

    private static void AddRoles(EcommerceContext context)
    {
     
      
    }
     
  }
}
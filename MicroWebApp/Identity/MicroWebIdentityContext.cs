using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MicroWebApp.Identity;


namespace MicroWebApp.Models
{
    public class MicroWebIdentityContext : IdentityDbContext<User>
    {
        public MicroWebIdentityContext(DbContextOptions<MicroWebIdentityContext> options)
            : base(options)
        {
        }
        
    }
}

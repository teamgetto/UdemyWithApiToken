using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UdemyApiWithToken.Domain.Model;

namespace UdemyApiWithToken.Domain
{
    public partial class UdemyApiWithTokenContext : DbContext
    {
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<User> User { get; set; }

        
    }
}

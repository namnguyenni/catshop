﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatShop.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CAT_SHOP1Entities : DbContext
    {
        public CAT_SHOP1Entities()
            : base("name=CAT_SHOP1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<C_Login> C_Login { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<CommentBlog> CommentBlogs { get; set; }
        public DbSet<LoaiMeo> LoaiMeos { get; set; }
        public DbSet<Meo> Meos { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<BestCat> BestCats { get; set; }
        public DbSet<LastNew> LastNews { get; set; }
        public DbSet<MaxMonneyCat> MaxMonneyCats { get; set; }
        public DbSet<SellerCat> SellerCats { get; set; }
    }
}

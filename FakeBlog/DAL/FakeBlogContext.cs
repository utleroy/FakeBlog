using FakeBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FakeBlog.DAL
{
    public class FakeBlogContext : ApplicationDbContext
    {
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Drafts> Drafts { get; set; }
        public DbSet<PublishedPosts> PublishedPosts { get; set; }
    }
}
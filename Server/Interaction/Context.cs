using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Contract;
using Models.Models;

namespace Interaction
{
    public class Context : DbContext, IContext
    {
        public Context()
        {
            Database.Connection.ConnectionString =
                @"Data Source=DESKTOP-OO9MRLG\SQLEXPRESS;Initial Catalog=FRDCreator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
       

        public DbSet<User> Users { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
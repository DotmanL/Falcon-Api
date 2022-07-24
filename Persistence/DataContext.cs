using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }


        // sets the name of our table to Activities with the type of Activity
        // contains all the columns in our table from the fields in the Activity class
        public DbSet<Activity> Activities { get; set; }
    }
}

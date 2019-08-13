using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ale.Data
{
    public class AleContext:DbContext
    {
        public DbSet<Question> Questions { get; set; }

    }
}

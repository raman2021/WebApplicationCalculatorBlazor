using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCalculatorAPI.Data
{
    public class CalculatorDb : DbContext
    {
        public CalculatorDb(DbContextOptions<CalculatorDb> options) : base(options)
        {
        }
             public DbSet<Number1> Input1{ get; set; }
        public DbSet<Number2> Input2 { get; set; }
        public DbSet<Result> Result { get; set; }

    }
    }


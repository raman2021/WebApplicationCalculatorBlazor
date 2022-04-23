using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCalculatorAPI.Data
{
    public class CalculatorDb : DbContext
    {
        public CalculatorDb(DbContextOptions<CalculatorDb> options) : base(options)
        {
            Database.EnsureCreated();

        }

        [Key]
         public DbSet<Input1> Input1 { get; set; }
        public DbSet<Number2> Input2 { get; set; }
        public DbSet<Result> Result { get; set; }
    }

    }
    


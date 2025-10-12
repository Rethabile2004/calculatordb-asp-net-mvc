using CalculatorAppDB.Models;
using Microsoft.EntityFrameworkCore;

namespace CalculatorAppDB.Data
{
    public class CalculatorContext : DbContext
    {
        public CalculatorContext(DbContextOptions<CalculatorContext> options) : base(options)
        {
            //
            // Name             : CalculatorContext(DbContextOptions<CalculatorContext> options)
            // Purpose          : Constructor that initializes the Calculator database context with options
            // Re-use           : None
            // Input Parameters : DbContextOptions<CalculatorContext> options
            //                    - configuration options for the database context
            // Output Type      : None
            //
        } // end CalculatorContext

        public DbSet<Calc>? Calculators
        {
            //
            // Name            : property DbSet<Calc>? Calculators
            // Purpose         : Public property to give access to the Calculators table in the database
            // Re-use          : None
            // Input Parameter : DbSet<Calc>? value
            //                   - new database set value (typically managed by EF Core)
            // Output Type     : DbSet<Calc>?
            //                   - represents the Calculators table in the database
            //
            get; // end get
            set; // end set
        } // end property


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //
            // Name             : void OnModelCreating(ModelBuilder modelBuilder)
            // Purpose          : Configure the entity mapping between the Calc class and database table
            // Re-use           : None
            // Input Parameters : ModelBuilder modelBuilder
            //                    - provides APIs to configure entity relationships and table names
            // Output Type      : None
            //
            modelBuilder.Entity<Calc>().ToTable("Calculator");
        } // end OnModelCreating
    } // end class CalculatorContext
} // end namespace

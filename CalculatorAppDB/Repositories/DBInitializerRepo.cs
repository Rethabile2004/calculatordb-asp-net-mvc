using CalculatorAppDB.Data;
using CalculatorAppDB.Interfaces;
using CalculatorAppDB.Models;

namespace CalculatorAppDB.Repositories
{
    public class DBInitializerRepo : IDBInitializer
    {
        public void Initialize(CalculatorContext context)
        {
            //
            // Name             : void Initialize(CalculatorContext context)
            // Purpose          : Ensure database creation and seed default calculator data if empty
            // Re-use           : None
            // Input Parameters : CalculatorContext context
            //                    - database context used to manage calculator records
            // Output Type      : None
            //
            context.Database.EnsureCreated();

            if (context.Calculators.Any())
            {
                return; // DB has been seeded
            } // end if

            var calculators = new List<Calc>()
            {
                new Calc("1001", "Casio", "fx-991EX", 552),
                new Calc("1002", "Casio", "fx-991ES PLUS", 417),
                new Calc("1003", "Texas Instruments", "TI-30XS MultiView", 300),
                new Calc("1004", "Sharp", "EL-W535T", 422),
                new Calc("1005", "HP", "300s+", 315),
                new Calc("1006", "Canon", "F-789SGA", 605),
                new Calc("1007", "Casio", "fx-82MS", 240),
                new Calc("1008", "Texas Instruments", "TI-36X Pro", 400),
                new Calc("1009", "Sharp", "EL-W506T", 640),
                new Calc("1010", "CTIfree", "UL-991ES PLUS", 417)
            };

            foreach (Calc s in calculators)
            {
                context.Calculators.Add(s);
            } // end foreach

            context.SaveChanges();
        } // end Initialize
    } // end class DBInitializerRepo
} // end namespace 

using CalculatorAppDB.Data;
using CalculatorAppDB.Interfaces;
using CalculatorAppDB.Models;

namespace CalculatorAppDB.Repositories
{
    public class CalcRepo : ICalc
    {
        public readonly CalculatorContext _context;

        public CalcRepo(CalculatorContext context)
        {
            //
            // Name             : CalcRepo(CalculatorContext context)
            // Purpose          : Constructor that initializes the Calculator database context
            // Re-use           : None
            // Input Parameters : CalculatorContext context
            //                    - database context for EF Core operations
            // Output Type      : None
            //
            _context = context;
        } // end CalcRepo

        public Calc Create(Calc calc)
        {
            //
            // Name             : Calc Create(Calc calc)
            // Purpose          : Create and save a new calculator record to the database
            // Re-use           : None
            // Input Parameters : Calc calc
            //                    - calculator entity to be created
            // Output Type      : Calc
            //                    - newly created calculator object
            //
            _context.Add(calc);
            _context.SaveChanges();
            return calc;
        } // end Create

        public bool Delete(Calc calc)
        {
            //
            // Name             : bool Delete(Calc calc)
            // Purpose          : Delete an existing calculator record from the database
            // Re-use           : IsExist()
            // Input Parameters : Calc calc
            //                    - calculator entity to delete
            // Output Type      : bool
            //                    - true if calculator still exists after deletion, false otherwise
            //
            _context.Remove(calc);
            _context.SaveChanges();

            return IsExist(calc.SerialNr);
        } // end Delete

        public Calc Details(string serialNr)
        {
            //
            // Name             : Calc Details(string serialNr)
            // Purpose          : Retrieve calculator details by its serial number
            // Re-use           : None
            // Input Parameters : string serialNr
            //                    - serial number of the calculator
            // Output Type      : Calc
            //                    - calculator record if found, null otherwise
            //
            return _context.Calculators?.FirstOrDefault(x => x.SerialNr == serialNr);
        } // end Details

        public Calc Edit(Calc calc)
        {
            //
            // Name             : Calc Edit(Calc calc)
            // Purpose          : Update existing calculator information in the database
            // Re-use           : None
            // Input Parameters : Calc calc
            //                    - calculator entity with updated values
            // Output Type      : Calc
            //                    - updated calculator object
            //
            _context.Update(calc);
            _context.SaveChanges();
            return calc;
        } // end Edit

        public IEnumerable<Calc> GetCalcs()
        {
            //
            // Name             : IEnumerable<Calc> GetCalcs()
            // Purpose          : Retrieve all calculator records from the database
            // Re-use           : None
            // Input Parameters : None
            // Output Type      : IEnumerable<Calc>
            //                    - list of all calculators
            //
            var calculators = _context.Calculators?.ToList();
            return calculators;
        } // end GetCalcs

        public bool IsExist(string serialNr)
        {
            //
            // Name             : bool IsExist(string serialNr)
            // Purpose          : Check if a calculator with a given serial number exists
            // Re-use           : Details()
            // Input Parameters : string serialNr
            //                    - serial number of calculator to check
            // Output Type      : bool
            //                    - true if not found (does not exist), false otherwise
            //
            bool isExist = false;
            Calc existCalculator = Details(serialNr);
            if (existCalculator == null)
            {
                isExist = true;
            } // end if
            return isExist;
        } // end IsExist
    } // end class CalcRepo
} // end namespace CalculatorAppDB.Repositories

using CalculatorAppDB.Models;

namespace CalculatorAppDB.Interfaces
{
    public interface ICalc
    {
        // Retrieves a collection of Calcs.
        IEnumerable<Calc> GetCalcs();

        // Retrieves details of a calculator based on its serial number.
        // Parameters:
        //   - serialNr: The unique serial number of the calculator to retrieve details for.
        Calc Details(string serialNr);

        // Creates a new calculator entry.
        // Parameters:
        //   - calc: The Calc object representing the new calculator to be created.
        Calc Create(Calc calc);

        // Edits an existing calculator entry.
        // Parameters:
        //   - calc: The Calc object representing the modified calculator.
        Calc Edit(Calc calc);

        // Deletes an existing calculator entry.
        // Parameters:
        //   - calc: The Calc object representing the calculator to be deleted.
        // Returns:
        //   - True if the deletion was successful, false otherwise.
        bool Delete(Calc calc);

        // Checks if a calculator with the specified serial number exists.
        // Parameters:
        //   - serialNr: The serial number to check for existence.
        // Returns:
        //   - True if a calculator with the given serial number exists, false otherwise.
        bool IsExist(string serialNr);
    }//end interface

}

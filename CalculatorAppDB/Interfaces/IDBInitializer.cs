using CalculatorAppDB.Data;

namespace CalculatorAppDB.Interfaces
{
    public interface IDBInitializer
    {
        //
        // Name             : void Initialize(CalculatorContext context)
        // Purpose          : Ensure the database is created and seeded with initial calculator data
        // Re-use           : None
        // Input Parameters : CalculatorContext context
        //                    - database context used to access and modify calculator data
        // Output Type      : None
        //
        void Initialize(CalculatorContext context);

    } // end interface
} // end namespace CalculatorAppDB.Interfaces

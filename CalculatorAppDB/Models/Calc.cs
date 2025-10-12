using CalculatorAppDB.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace CalculatorAppDB.Models
{
    public class Calc
    {
        [Key]
        //Displays a required message
        [Required(ErrorMessage = "The serial number is required.")]
        //Limits the length of the serial number
        [StringLength(4, MinimumLength = 4, ErrorMessage = "The serial number must have a length of 4.")]
        //Displays the name of the property
        [Display(Name = "Serial number")]
        public string SerialNr
        {
            //
            // Name            : property string SerialNr
            // Purpose         : Public property to give access to the calculator's serial number
            // Re-use          : None
            // Input Parameter : string value
            //                   - new value for the SerialNr field
            // Output Type     : string
            //                   - value stored in the SerialNr field
            //
            get; // end get
            set; // end set
        } // end property

        //Displays a required message
        [Required(ErrorMessage = "The calculator manufacturer is required.")]
        //Displays the name of the property
        [Display(Name = "Manufacturer")]
        public string Make
        {
            //
            // Name            : property string Make
            // Purpose         : Public property to give access to the calculator's manufacturer
            // Re-use          : None
            // Input Parameter : string value
            //                   - new value for the Make field
            // Output Type     : string
            //                   - value stored in the Make field
            //
            get;// end get
            set;// end set
        } // end property

        //Displays a required message
        [Required(ErrorMessage = "The calculator model is required.")]
        //Displays the name of the property
        [Display(Name = "Model")]
        public string Model
        {
            //
            // Name            : property string Model
            // Purpose         : Public property to give access to the calculator's model name
            // Re-use          : None
            // Input Parameter : string value
            //                   - new value for the Model field
            // Output Type     : string
            //                   - value stored in the Model field
            //
            get; // end get
            set; // end set
        } // end property

        [VerifyFunctions]
        //Displays a required message
        [Required(ErrorMessage = "The number of functions is required.")]
        //Displays the name of the property
        [Display(Name = "Nr of functions")]
        public int? Functions
        {
            //
            // Name            : property int? Functions
            // Purpose         : Public property to give access to the calculator's number of functions
            // Re-use          : None
            // Input Parameter : int? value
            //                   - new value for the Functions field
            // Output Type     : int?
            //                   - value stored in the Functions field
            //
            get; // end get
            set; // end set
        } // end property

        //default constructor
        public Calc()
        {
            //
            // Name             : Calc()
            // Purpose          : Default constructor that initializes a new calculator object
            // Re-use           : None
            // Input Parameters : None
            // Output Type      : None
            //
        } // end Calc

        //non-default constructor
        public Calc(string serialNr, string make, string model, int functions)
        {
            //
            // Name             : Calc(string serialNr, string make, string model, int functions)
            // Purpose          : Overloaded constructor used to initialize calculator data fields
            // Re-use           : None
            // Input Parameters : string serialNr
            //                    - calculator serial number
            //                    string make
            //                    - manufacturer name
            //                    string model
            //                    - model name
            //                    int functions
            //                    - number of calculator functions
            // Output Type      : None
            //
            SerialNr = serialNr;
            Make = make;
            Model = model;
            Functions = functions;
        } // end Calc

        public override string ToString()
        {
            //
            // Name             : string ToString()
            // Purpose          : Returns formatted calculator information as text
            // Re-use           : None
            // Input Parameters : None
            // Output Type      : string
            //                    - formatted calculator details
            //
            return $"{SerialNr}: {Make} {Model} with {Functions} functions";
        } // end ToString
    } // end class
} // end namespace

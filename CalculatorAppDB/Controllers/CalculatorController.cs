using CalculatorAppDB.Interfaces;
using CalculatorAppDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAppDB.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalc _calcRepo;

        public CalculatorController(ICalc calcRepo)
        {
            //
            // Name             : CalculatorController(ICalc calcRepo)
            // Purpose          : Constructor that initializes the controller with a calculator repository
            // Re-use           : None
            // Input Parameters : ICalc calcRepo
            //                    - repository instance for calculator data operations
            // Output Type      : None
            //
            _calcRepo = calcRepo;
        } // end CalculatorController

        public IActionResult Index()
        {
            //
            // Name             : IActionResult Index()
            // Purpose          : Display a list of all calculators from the repository
            // Re-use           : GetCalcs()
            // Input Parameters : None
            // Output Type      : IActionResult
            //                    - Index view displaying a list of calculators
            //
            return View(_calcRepo.GetCalcs());
        } // end Index

        public IActionResult Details(string serialNr)
        {
            //
            // Name             : IActionResult Details(string serialNr)
            // Purpose          : Display detailed information for a specific calculator
            // Re-use           : Details()
            // Input Parameters : string serialNr
            //                    - serial number of the calculator to display
            // Output Type      : IActionResult
            //                    - Details view for the selected calculator
            //
            return View(_calcRepo.Details(serialNr));
        } // end Details

        [HttpGet]
        public IActionResult Create()
        {
            //
            // Name             : IActionResult Create()
            // Purpose          : Display the view for creating a new calculator entry
            // Re-use           : None
            // Input Parameters : None
            // Output Type      : IActionResult
            //                    - Create view
            //
            ViewBag.ShowAdd = false;
            return View();
        } // end Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("SerialNr, Make, Model, Functions")] Calc calc)
        {
            //
            // Name             : IActionResult Create(Calc calc)
            // Purpose          : Handle form submission for creating a new calculator entry
            // Re-use           : Create(), IsExist()
            // Input Parameters : Calc calc
            //                    - calculator object containing input data
            // Output Type      : IActionResult
            //                    - Create view with success or validation feedback
            //
            if (ModelState.IsValid)
            {
                ViewBag.SuccessMessage = $"Calculator with serial number {calc.SerialNr} was successfully added!";
                ViewBag.ShowAdd = true;
                calc = _calcRepo.Create(calc);
            } // end if

            if (_calcRepo.IsExist(calc.SerialNr))
            {
                return View(calc);
            } // end if

            return View();
        } // end Create

        [HttpGet]
        public IActionResult Edit(string serialNr)
        {
            //
            // Name             : IActionResult Edit(string serialNr)
            // Purpose          : Display calculator details in editable form
            // Re-use           : Details()
            // Input Parameters : string serialNr
            //                    - serial number of the calculator to edit
            // Output Type      : IActionResult
            //                    - Edit view with pre-filled calculator details
            //
            ViewBag.ShowSave = false;
            var calc = _calcRepo.Details(serialNr);
            return View(calc);
        } // end Edit

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string serialNr, [Bind("SerialNr, Make, Model, Functions")] Calc calc)
        {
            //
            // Name             : IActionResult Edit(string serialNr, Calc calc)
            // Purpose          : Handle form submission for editing an existing calculator
            // Re-use           : Edit(), IsExist()
            // Input Parameters : string serialNr
            //                    - serial number identifying the calculator to update
            //                    Calc calc
            //                    - calculator object containing updated values
            // Output Type      : IActionResult
            //                    - Edit view with success or validation feedback
            //
            if (ModelState.IsValid)
            {
                calc = _calcRepo.Edit(calc);
                ViewBag.SuccessMessage = $"Calculator with serial number {serialNr} was successfully updated!";
                ViewBag.ShowSave = true;
            } // end if

            if (_calcRepo.IsExist(calc.SerialNr))
            {
                return View(calc);
            } // end if

            return View(calc);
        } // end Edit

        [HttpGet]
        public IActionResult Delete(string serialNr)
        {
            //
            // Name             : IActionResult Delete(string serialNr)
            // Purpose          : Display the calculator record selected for deletion
            // Re-use           : Details()
            // Input Parameters : string serialNr
            //                    - serial number of the calculator to delete
            // Output Type      : IActionResult
            //                    - Delete view showing the selected calculator details
            //
            var calc = _calcRepo.Details(serialNr);
            ViewBag.ShowDelete = true;
            return View(calc);
        } // end Delete

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string serialNr, Calc calc)
        {
            //
            // Name             : IActionResult Delete(string serialNr, Calc calc)
            // Purpose          : Handle deletion of a calculator record from the repository
            // Re-use           : Delete()
            // Input Parameters : string serialNr
            //                    - serial number identifying the calculator to delete
            //                    Calc calc
            //                    - calculator object to delete
            // Output Type      : IActionResult
            //                    - Delete view with success feedback
            //
            bool found = _calcRepo.Delete(calc);

            if (found)
            {
                ViewBag.SuccessMessage = $"Calculator with serial number {calc.SerialNr} was successfully deleted!";
                ViewBag.ShowDelete = false;
            } // end if

            return View();
        } // end Delete
    } // end class CalculatorController
} // end namespace 

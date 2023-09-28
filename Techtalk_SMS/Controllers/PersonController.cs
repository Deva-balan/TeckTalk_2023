using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Techtalk_SMS.Models;

namespace Techtalk_SMS.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Person()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PersonList()
        {
            // Retrieve the list of saved persons from the session.
            List<Person> savedPersons = new List<Person>();
            string savedPersonsstring = HttpContext.Session.GetString("SavedPersons");
            if (!string.IsNullOrEmpty(savedPersonsstring))
            {
                savedPersons = JsonConvert.DeserializeObject<List<Person>>(savedPersonsstring);
            }

            // Check if the list is null or empty (if not found or if it's the first time).
            if (savedPersons == null || savedPersons.Count == 0)
            {
                savedPersons = new List<Person>();
            }

            // You can return the list or use it as needed.
            return View(savedPersons);
        }

        [HttpPost]
        public IActionResult BindForm([FromForm] Person person)
        {
            if (!ModelState.IsValid)
            {
                // Model validation failed; return to the form with validation errors.
                return View("Person", person);
            }

            try
            {
                // Save the person data to a database or perform any other data processing.
                // For demonstration purposes, let's assume you're saving to a list.

                // Initialize a list (you would typically use a database or other storage).
                List<Person> savedPersons = new List<Person>();
                string savedPersonsstring = HttpContext.Session.GetString("SavedPersons");
                if (!string.IsNullOrEmpty(savedPersonsstring))
                {
                    savedPersons = JsonConvert.DeserializeObject<List<Person>>(savedPersonsstring);
                }
                if (savedPersons == null)
                {
                    savedPersons = new List<Person>();
                }

                // Add the person to the list.
                savedPersons.Add(person);

                // Save the updated list to the session (again, this is for demonstration purposes).
                string json = JsonConvert.SerializeObject(savedPersons);

                // Store the serialized JSON in the session
                HttpContext.Session.SetString("SavedPersons", json);

                // Redirect to a success page or display a success message.
                return RedirectToAction("PersonList");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the saving process.
                // Log the exception or perform error handling as needed.
                return View("Error"); // Display an error view or page.
            }
        }


        [HttpPost]
        public IActionResult BindJson([FromBody] Person person)
        {
            return Content($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}

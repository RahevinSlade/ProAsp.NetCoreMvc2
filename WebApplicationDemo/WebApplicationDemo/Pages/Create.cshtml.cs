using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationDemo.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db;//made so others cant poke into the database

        public CreateModel(AppDbContext db)
        {
            _db = db;//creates our database and sets it to db
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) //checks if the state is valid
            {
                return Page();
            }

            _db.Customers.Add(Customer);//adds information
            await _db.SaveChangesAsync();//saves it to our database
            return RedirectToPage("/Index"); //redirects user to the index page

        }
    }
}

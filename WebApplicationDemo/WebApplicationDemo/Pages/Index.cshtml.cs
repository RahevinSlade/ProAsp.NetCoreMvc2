using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationDemo.Pages
{
    public class IndexModel : PageModel
    {

        private readonly AppDbContext _db;//made so others cant poke into the database

        public IndexModel(AppDbContext db)
        {
            _db = db;//creates our database and sets it to db
        }

        public IList<Customer> Customers { get; private set; }

        public async Task OnGetAsync()
        {
            Customers = await _db.Customers.AsNoTracking().ToListAsync();
        }
    }
}

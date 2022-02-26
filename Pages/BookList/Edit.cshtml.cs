using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGet(int Id)
        {
            Book = await _db.Book.FirstOrDefaultAsync(b => b.Id == Id);
            
        }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                if(Book!=null)
                {
                    _db.Book.Update(Book);
                    await _db.SaveChangesAsync();
                    return RedirectToPage("Index");
                }
            }
            return RedirectToPage();
        }
    }
}
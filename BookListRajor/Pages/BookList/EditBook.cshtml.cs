using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRajor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRajor.Pages.BookList
{
    public class EditBookModel : PageModel
    {
        private ApplicationDbContext _db;
        public EditBookModel(ApplicationDbContext db)
        {
            _db = db;   
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGet(int id) //instead of void must be use 'async task' because we r using 'await'.
        {
            Book = await _db.Book.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var BookFromDb = await _db.Book.FindAsync(Book.Id);
                BookFromDb.Name = Book.Name;
                BookFromDb.Author = Book.Author;
                BookFromDb.ISBN = Book.ISBN;
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}

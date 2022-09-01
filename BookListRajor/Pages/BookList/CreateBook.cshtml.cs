using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRajor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
namespace BookListRajor.Pages.BookList
{
    public class CreateBookModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CreateBookModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty] //u can also add this bind property instead of specifying the Book bookObj object in method.
        public Book Book { get; set; }
        public void OnGet()   /*Handler*/
        {
        }   /*Handler will always start with 'On'*/
        public async Task<IActionResult> OnPost()
        {
            //whether modelState is invalid or not check by the below code
            //var errors = ModelState.Where(x => x.Value.Errors.Count > 0).Select(x => new { x.Key, x.Value.Errors }).ToArray();
            if (ModelState.IsValid)
            {
                await _db.Book.AddAsync(Book);    /*only data inserted into the Queue (inserting data)*/
                await _db.SaveChangesAsync();     /*saveChangesAsync executes and will push the Queue into the database */
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookLibrary.Models;

namespace BookLibrary.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookLibrary.Data.BookLibraryContext _context;

        public IndexModel(BookLibrary.Data.BookLibraryContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}

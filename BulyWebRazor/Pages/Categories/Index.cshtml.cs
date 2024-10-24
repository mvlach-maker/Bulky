using BulyWebRazor.Data;
using BulyWebRazor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulyWebRazor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db; 
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;   
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}

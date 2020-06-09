using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Mgmt_System_ASP_Core.Business;
using System.Threading.Tasks;

namespace Student_Mgmt_System_ASP_Core.Pages.Student_Details
{
    public class DeleteModel : PageModel
    {
        private readonly Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB _context;

        public DeleteModel(Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB context)
        {
            _context = context;
        }

        [BindProperty]
        public student_Details student_Details { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            student_Details = await _context.student_Details.FirstOrDefaultAsync(m => m.student_ID == id);

            if (student_Details == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            student_Details = await _context.student_Details.FindAsync(id);

            if (student_Details != null)
            {
                _context.student_Details.Remove(student_Details);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

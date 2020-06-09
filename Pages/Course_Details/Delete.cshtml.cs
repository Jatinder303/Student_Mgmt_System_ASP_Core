using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Mgmt_System_ASP_Core.Business;
using System.Threading.Tasks;

namespace Student_Mgmt_System_ASP_Core.Pages.Course_Details
{
    public class DeleteModel : PageModel
    {
        private readonly Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB _context;

        public DeleteModel(Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB context)
        {
            _context = context;
        }

        [BindProperty]
        public Course_details Course_details { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course_details = await _context.Course_details.FirstOrDefaultAsync(m => m.course_ID == id);

            if (Course_details == null)
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

            Course_details = await _context.Course_details.FindAsync(id);

            if (Course_details != null)
            {
                _context.Course_details.Remove(Course_details);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

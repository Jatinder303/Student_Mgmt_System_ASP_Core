using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Mgmt_System_ASP_Core.Business;
using System.Threading.Tasks;

namespace Student_Mgmt_System_ASP_Core.Pages.Student_Enrollment
{
    public class DeleteModel : PageModel
    {
        private readonly Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB _context;

        public DeleteModel(Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB context)
        {
            _context = context;
        }

        [BindProperty]
        public Student_enrollment Student_enrollment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student_enrollment = await _context.Student_enrollment.FirstOrDefaultAsync(m => m.Student_Enrollment_ID == id);

            if (Student_enrollment == null)
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

            Student_enrollment = await _context.Student_enrollment.FindAsync(id);

            if (Student_enrollment != null)
            {
                _context.Student_enrollment.Remove(Student_enrollment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

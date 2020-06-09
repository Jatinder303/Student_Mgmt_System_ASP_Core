using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Mgmt_System_ASP_Core.Business;
using System.Threading.Tasks;

namespace Student_Mgmt_System_ASP_Core.Pages.Tutor_Details
{
    public class DeleteModel : PageModel
    {
        private readonly Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB _context;

        public DeleteModel(Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB context)
        {
            _context = context;
        }

        [BindProperty]
        public Tutor_details Tutor_details { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tutor_details = await _context.Tutor_details.FirstOrDefaultAsync(m => m.tutor_ID == id);

            if (Tutor_details == null)
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

            Tutor_details = await _context.Tutor_details.FindAsync(id);

            if (Tutor_details != null)
            {
                _context.Tutor_details.Remove(Tutor_details);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

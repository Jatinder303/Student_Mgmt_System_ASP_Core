using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Mgmt_System_ASP_Core.Business;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Student_Mgmt_System_ASP_Core.Pages.Student_Enrollment
{
    public class IndexModel : PageModel
    {
        private readonly Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB _context;

        public IndexModel(Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB context)
        {
            _context = context;
        }

        public IList<Student_enrollment> Student_enrollment { get; set; }

        public async Task OnGetAsync()
        {
            Student_enrollment = await _context.Student_enrollment.ToListAsync();
        }
    }
}

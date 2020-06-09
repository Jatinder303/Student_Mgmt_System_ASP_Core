using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Mgmt_System_ASP_Core.Business;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Student_Mgmt_System_ASP_Core.Pages.Tutor_Details
{
    public class IndexModel : PageModel
    {
        private readonly Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB _context;

        public IndexModel(Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB context)
        {
            _context = context;
        }

        public IList<Tutor_details> Tutor_details { get; set; }

        public async Task OnGetAsync()
        {
            Tutor_details = await _context.Tutor_details.ToListAsync();
        }
    }
}

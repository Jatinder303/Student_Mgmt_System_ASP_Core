﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Mgmt_System_ASP_Core.Business;
using System.Threading.Tasks;

namespace Student_Mgmt_System_ASP_Core.Pages.Course_Details
{
    public class CreateModel : PageModel
    {
        private readonly Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB _context;

        public CreateModel(Student_Mgmt_System_ASP_Core.Data.Student_Mgmt_System_DB context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Course_details Course_details { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Course_details.Add(Course_details);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

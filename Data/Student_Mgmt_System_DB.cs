using Microsoft.EntityFrameworkCore;
using Student_Mgmt_System_ASP_Core.Business;

namespace Student_Mgmt_System_ASP_Core.Data
{
    public class Student_Mgmt_System_DB : DbContext
    {
        public Student_Mgmt_System_DB(DbContextOptions<Student_Mgmt_System_DB> options)
            : base(options)
        {
        }

        public DbSet<Student_Mgmt_System_ASP_Core.Business.Tutor_details> Tutor_details { get; set; }

        public DbSet<Student_Mgmt_System_ASP_Core.Business.Course_details> Course_details { get; set; }

        public DbSet<Student_Mgmt_System_ASP_Core.Business.student_Details> student_Details { get; set; }

        public DbSet<Student_Mgmt_System_ASP_Core.Business.Student_enrollment> Student_enrollment { get; set; }
    }
}

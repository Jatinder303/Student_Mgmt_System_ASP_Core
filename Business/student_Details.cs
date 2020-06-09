using System.ComponentModel.DataAnnotations;

namespace Student_Mgmt_System_ASP_Core.Business
{
    public class student_Details
    {
        [Key]
        public int student_ID { get; set; }
        public string student_Name { get; set; }

        public string student_Email { get; set; }

        public string student_Mobile { get; set; }
        public string student_Address { get; set; }

    }
}

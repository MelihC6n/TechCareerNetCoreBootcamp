using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkEntry.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage ="İsim boş bırakılamaz")]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Soyisim boş bırakılamaz")]
        public string LastName { get; set; }
        public string? Adress { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? City { get; set; }
        public DateTime? AddTime { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApplication.Entities
{
    public class Pacient
    {
        public int Id { get; set; }

        public string Name { get; set; }  

        public DateTime DateOfBirth { get; set; }

        public ICollection<Doctor> Doctors{ get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedDate { get; set; }
 

    }
}

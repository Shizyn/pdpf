using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static QuantumEvents.Controllers.BookingController;

namespace QuantumEvents.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Тип мероприятия обязателен")]
        public string TypeEvent { get; set; }

        [Required(ErrorMessage = "Пропроба обязателена")]
        public int ProfProbaId { get; set; }
        public ProfProba ProfProba { get; set; }

        [Required(ErrorMessage = "Событие обязательно")]
        public int EventId { get; set; }
        public Event Event { get; set; }

        [Required(ErrorMessage = "ФИО обязательно")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Телефон обязателен")]
        [Phone(ErrorMessage = "Некорректный номер телефона")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Школа обязательна")]
        public string SchoolName { get; set; }

        [Required(ErrorMessage = "Дата обязательна")]
        public DateTime BookingDate { get; set; }

        [Required(ErrorMessage = "Время обязательно")]
        public string TimeRange { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        public List<UploadedFile> Files { get; set; }
    }
}

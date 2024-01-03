using System.ComponentModel.DataAnnotations;

namespace LAB10.Models
{
    public class RegistrationFormModel
    {
        [Required(ErrorMessage = "Будь ласка, введіть ім'я та прізвище.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть Email.")]
        [EmailAddress(ErrorMessage = "Email не відповідає формату.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть бажану дату консультації.")]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Дата має бути в майбутньому.")]
        [NoWeekends(ErrorMessage = "Консультація не може бути в вихідні дні.")]
        public DateTime DesiredDate { get; set; }

        [Required(ErrorMessage = "Будь ласка, виберіть продукт.")]
        [NoBasicOnMondays(ErrorMessage = "Консультація щодо продукту «Основи» не може проходити по понеділках.")]
        public string Product { get; set; }
    }
}

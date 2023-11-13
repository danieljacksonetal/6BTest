using System.ComponentModel.DataAnnotations;

namespace SixBeeAppointments.Data
{
    public class Appointment
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Name { get; set; }
        public string Issue { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
    }
}

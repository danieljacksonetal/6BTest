namespace SixBeeAppointments.Data
{
    public interface IAppointmentService
    {
        Task<Appointment[]> GetAppointmentsAsync();
    }
}

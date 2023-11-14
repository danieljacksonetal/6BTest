namespace SixBeeAppointments.Data
{
    public interface IAppointmentService
    {
        Task<Appointment[]> GetAppointmentsAsync();
        Task<bool> CreateAppointmentAsync(Appointment appointment);
        Task ApproveAppointmentAsync(Appointment appointment);
    }
}

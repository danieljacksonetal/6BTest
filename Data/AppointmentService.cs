using Microsoft.EntityFrameworkCore;

namespace SixBeeAppointments.Data
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _dbContext;

        public AppointmentService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public async Task<Appointment[]> GetAppointmentsAsync()
        {
            return await _dbContext.Appointments.ToArrayAsync();
        }

        public async Task<bool> CreateAppointmentAsync(Appointment appointment)
        {
            await _dbContext.Appointments.AddAsync(appointment);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task ApproveAppointmentAsync(Appointment appointment)
        {
            var approved = appointment.IsApproved;
            var appointmentToUpdate = await _dbContext.Appointments.FirstOrDefaultAsync(x => x.Id == appointment.Id);
            _dbContext.Update(appointment);
            await _dbContext.SaveChangesAsync();
        }
    }
}

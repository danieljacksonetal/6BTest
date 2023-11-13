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
    }
}

using NSubstitute;
using Shouldly;
using SixBeeAppointments.Data;
using System.Threading.Tasks;
using Xunit;

namespace SixBeeAppointments.Tests.Data
{
    public class AppointmentServiceTests : TestFixture
    {
        private readonly AppointmentService _service;
        private readonly ApplicationDbContext _dbContext;

        public AppointmentServiceTests()
        {
            _dbContext = Substitute.For<ApplicationDbContext>();

            _service = new AppointmentService(_dbContext);
        }

        [Fact]
        public async Task Get_Calls_Db_And_Returns_Data()
        {
            await _dbContext.Appointments.AddRangeAsync(Appointments);
            var result = await _service.GetAppointmentsAsync();
            result.Length.ShouldBe(Appointments.Count);

        }
    }
}

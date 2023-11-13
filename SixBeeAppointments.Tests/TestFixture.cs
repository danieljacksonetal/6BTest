using AutoFixture;
using SixBeeAppointments.Data;
using System.Collections.Generic;
using System.Linq;

namespace SixBeeAppointments.Tests
{
    public class TestFixture
    {
        public readonly Fixture AutoFixture;
        public List<Appointment> Appointments { get; set; }

        public TestFixture()
        {
            AutoFixture = new();
            AutoFixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList().ForEach(b => AutoFixture.Behaviors.Remove(b));
            AutoFixture.Behaviors.Add(new OmitOnRecursionBehavior());

            Appointments = new List<Appointment>()
            {
                CreateAppointment(),
                CreateAppointment(),
                CreateAppointment()
            };
        }
        private Appointment CreateAppointment()
        {
            return AutoFixture.Build<Appointment>()
               .Create();
        }

    }
}

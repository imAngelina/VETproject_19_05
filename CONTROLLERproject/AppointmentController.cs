using DATAproject;
using DATAproject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLERproject
{
    public class AppointmentController
    {
        private readonly VetContext context;

        public AppointmentController()
        {
            context = new VetContext();
        }
        public AppointmentController(VetContext c)
        {
            context = c;
        }

        public async Task<List<Appointment>> GetAllAsync()
        {
            return await context.Appointments
                .Include(x => x.Pet)
                .ThenInclude(x => x.Owner)
                .Include(x => x.Employee)
                .Include(x => x.Service)
                .ToListAsync();
        }

       
        public async Task<List<Appointment>> GetClientAppointmentsAsync(int ownerId)
        {
            return await context.Appointments
                .Include(x => x.Pet)
                .Include(x => x.Employee)
                .Include(x => x.Service)
                .Where(x => x.Pet.OwnerId == ownerId)
                .ToListAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var appointment =
                await context.Appointments.FindAsync(id);

            if (appointment != null)
            {
                context.Appointments.Remove(appointment);

                await context.SaveChangesAsync();
            }
        }
        public async Task<bool> IsAppointmentTakenAsync(DateTime dateTime, int employeeId)
        {
            return await context.Appointments
                .AnyAsync(x => x.EmployeeId == employeeId
                            && x.DateTime == dateTime);
        }

        public async Task<bool> CreateAppointmentAsync(Appointment appointment)
        {
            bool isTaken = await IsAppointmentTakenAsync(
                appointment.DateTime,
                appointment.EmployeeId);

            if (isTaken)
            {
                return false;
            }

            await context.Appointments.AddAsync(appointment);
            await context.SaveChangesAsync();

            return true;
        }
        public async Task<Appointment> GetById(int id)
        {
            var user = await context.Appointments.FindAsync(id);
            return user;
        }
    }
}

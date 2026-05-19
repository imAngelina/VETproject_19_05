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
        private readonly VetContext context = new VetContext();

        public async Task<List<Appointment>> GetAllAsync()
        {
            return await context.Appointments
                .Include(x => x.Pet)
                .ThenInclude(x => x.Owner)
                .Include(x => x.Employee)
                .Include(x => x.Service)
                .ToListAsync();
        }

        public async Task<List<Appointment>> GetEmployeeAppointmentsAsync(int employeeId)
        {
            return await context.Appointments
                .Include(x => x.Pet)
                .Include(x => x.Service)
                .Where(x => x.EmployeeId == employeeId)
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

        public async Task<Appointment?> GetByIdAsync(int id)
        {
            return await context.Appointments
                .Include(x => x.Pet)
                .Include(x => x.Employee)
                .Include(x => x.Service)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task CreateAsync(Appointment appointment)
        {
            await context.Appointments.AddAsync(appointment);

            await context.SaveChangesAsync();
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
    }
}

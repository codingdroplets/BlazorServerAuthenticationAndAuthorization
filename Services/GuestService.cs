using BlazorAppProjekt.Data;
using BlazorAppProjekt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppProjekt.Services
{
    public class GuestService
    {
        private readonly MyDbContext _context;

        public GuestService(MyDbContext context)
        {
            _context = context;
        }

        public async Task AddGuestAsync(Guest guest)
        {
            _context.Guests.Add(guest);
            await _context.SaveChangesAsync();
        }

         public async Task<List<Guest>> GetGuestsAsync()
        {
            return await _context.Guests.ToListAsync();
        }
        public async Task<List<Event>> GetEventsAsync()
        {
            var currentDate = DateTime.Now;
            return await _context.Events
                .Where(e => e.EventDate >= currentDate)
                .ToListAsync();
        }
        public async Task<Guest> GetGuestByIdAsync(int id)
        {
            return await _context.Guests.FindAsync(id);
        }
        public async Task UpdateGuestAsync(Guest guest)
        {
            _context.Entry(guest).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}

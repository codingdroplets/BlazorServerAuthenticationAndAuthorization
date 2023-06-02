using BlazorAppProjekt.Data;
using BlazorAppProjekt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppProjekt.Services
{
    public class EventGuestService
    {
        private readonly MyDbContext _context;

        public EventGuestService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<List<EventGuest>> GetAllEventGuestsAsync()
        {
            return await _context.EventGuests.Include(e => e.Event).Include(g => g.Guest).ToListAsync();
        }

        // Hozzáadás
        public async Task AddEventGuestAsync(EventGuest eventGuest)
        {
            var existingEventGuest = await _context.EventGuests
                .Where(eg => eg.EventId == eventGuest.EventId && eg.GuestId == eventGuest.GuestId)
                .FirstOrDefaultAsync();

            if (existingEventGuest == null)
            {
                _context.EventGuests.Add(eventGuest);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> IsGuestAlreadyInEventAsync(int eventId, int guestId)
        {
            return await _context.EventGuests.AnyAsync(eg => eg.EventId == eventId && eg.GuestId == guestId);
        }
        // Ide jöhetnek az EventGuest-hez kapcsolódó további műveletek, például:
        public async Task DeleteEventGuestAsync(int eventId, int guestId)
        {
            var eventGuest = await _context.EventGuests
                .Where(eg => eg.EventId == eventId && eg.GuestId == guestId)
                .FirstOrDefaultAsync();

            if (eventGuest != null)
            {
                _context.EventGuests.Remove(eventGuest);
                await _context.SaveChangesAsync();
            }
        }
        // - Lekérdezés
        // stb.
    }
}

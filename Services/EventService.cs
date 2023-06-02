using BlazorAppProjekt.Data;
using BlazorAppProjekt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppProjekt.Services
{
    public class EventService
    {
        private readonly MyDbContext _context;

        public EventService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Event> AddEventAsync(Event eventItem)
        {
            _context.Events.Add(eventItem);
            await _context.SaveChangesAsync();
            return eventItem;
        }

        public async Task<List<Event>> GetEventsAsync()
        {
            var currentDate = DateTime.Now;
            return await _context.Events
                .Where(e => e.EventDate >= currentDate)
                .ToListAsync();
        }


        public async Task<List<Event>> GetEventsAfterAsync(DateTime date)
        {
            return await _context.Events.Where(e => e.EventDate > date).ToListAsync();
        }

        public async Task<Event> GetEventAsync(int id)
        {
            return await _context.Events.FindAsync(id);
        }

        public async Task<Event> UpdateEventAsync(Event eventItem)
        {
            _context.Events.Update(eventItem);
            await _context.SaveChangesAsync();
            return eventItem;
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _context.Events.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<Event>> GetAllEventsAsync()
        {
            return await _context.Events.ToListAsync();
        }
    }
}


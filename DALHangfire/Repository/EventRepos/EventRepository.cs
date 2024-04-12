using DALHangfire.Context;
using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALHangfire.Repository.EventRepos
{
    public class EventRepository : IEventRepository
    {
        private readonly HangFireContext _context;

        public EventRepository(HangFireContext context)
        {
            _context = context;
        }
        public List<Event> GetEvents()
        {
            return _context.Events.ToList();
        }
        public Event GetEventById(int id)
        {
            throw new NotImplementedException();
        }

     
    }
}

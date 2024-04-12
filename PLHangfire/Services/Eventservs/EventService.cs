using DALHangfire.Repository.EventRepos;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLHangfire.Services.Eventservs
{
    public class EventService: IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService( IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public List<Event> GetAllEvents()
        {
            return _eventRepository.GetEvents();
        }
    }
}

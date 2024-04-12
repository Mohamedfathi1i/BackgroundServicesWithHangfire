using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLHangfire.Services.Eventservs
{
    public interface IEventService
    {
        List<Event> GetAllEvents();
    }
}

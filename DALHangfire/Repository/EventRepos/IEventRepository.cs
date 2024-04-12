using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entites;

namespace DALHangfire.Repository.EventRepos
{
    public interface IEventRepository
    {
        List<Event> GetEvents();
        Event GetEventById(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
    public interface IMeetupRepository //imeetuprepos
    {

        public IQueryable<MeetupScheduler> GetAllMeetings();  //meetup change

        public MeetupScheduler GetMeetingById(int id);
        void AddMeetup(MeetupScheduler meetup);
        bool RemoveMeetup(int id);
        public MeetupScheduler Update(MeetupScheduler meetup);
        void Save();
    }
}

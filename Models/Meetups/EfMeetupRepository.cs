using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
    public class EfMeetupRepository : IMeetupRepository
    {
        private AppDbContext _context;

        public EfMeetupRepository(AppDbContext db)
        {
            _context = db;
        }

        public void AddMeetup(MeetupScheduler meetup)
        {
            _context.Meetings.Add(meetup);
        }

        public IQueryable<MeetupScheduler> GetAllMeetings()
        {
            return _context.Meetings;
        }

        public MeetupScheduler GetMeetingById(int id)
        {
            return _context.Meetings.FirstOrDefault(m => m.ID == id);  //given a particular variable (m) find out where m.ID ==id
            //for every meeting, get only the vheicles where m.ID is equal to the parameter 
        }

        public bool RemoveMeetup(int id)
        {
            MeetupScheduler meetupScheduler = _context.Meetings.Find(id);
            if (meetupScheduler == null)
            {
                return false;
            }
             _context.Meetings.Remove(_context.Meetings.FirstOrDefault(i => i.ID == id));
            _context.SaveChanges();
            return true;
        
        }


        public void Save()
        {
            _context.SaveChanges();
        }

        public MeetupScheduler Update(MeetupScheduler meetup)
        {
            MeetupScheduler meetupToUpdate = _context.Meetings.SingleOrDefault(m => m.ID == meetup.ID);
            if (meetupToUpdate != null)
            {
                meetupToUpdate.BuyerID = meetup.BuyerID;
                meetupToUpdate.BuyerName = meetup.BuyerName;
                meetupToUpdate.ItemID = meetup.ItemID;
                meetupToUpdate.StreetAddress = meetup.StreetAddress;
                meetupToUpdate.City = meetup.City;
                meetupToUpdate.State = meetup.State;
                meetupToUpdate.ZipCode = meetup.ZipCode;
                meetupToUpdate.Time = meetup.Time;
                meetupToUpdate.MeetingDate = meetup.MeetingDate;
                _context.SaveChanges();
            }
            return meetupToUpdate;

        }
    }
}



using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SilentAthleticsWebApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Controllers
{
    public class MeetupSchedulerController : Controller
    {
        private IMeetupRepository _meetupRepository;  //_repository
        public int PageSize = 4;
        public MeetupSchedulerController(IMeetupRepository _meeting)  //Imeetuprepository**
        {
            _meetupRepository = _meeting;
        }



        public IActionResult Index()
        {
            IQueryable<MeetupScheduler>allMeetings=_meetupRepository.GetAllMeetings();
            return View(allMeetings);


        }

        [HttpGet]
        public IActionResult Create()
        {
            //returns create cshtml page
            return View();
        }

        [HttpPost]
        public IActionResult Create(MeetupScheduler m)
        {

            //save meet up being recieved to the database
            //returns the details page post addition of data

            MeetupScheduler meetup = new MeetupScheduler();




            _meetupRepository.AddMeetup(m);
            _meetupRepository.Save();

           
            return RedirectToAction("Details",  new { id = m.ID });  //anon class with one field "id"
        }

        public IActionResult Details(int id)
        {
            //pulls from database and displays it in view

            

            
            return View(_meetupRepository.GetMeetingById(id));

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            //grabs the obj from database to be edited

            MeetupScheduler meetup = _meetupRepository.GetMeetingById(id);
            return View(meetup);

        }

        [HttpPost]
        public IActionResult Edit(MeetupScheduler m)
        {

            _meetupRepository.Update(m);
            _meetupRepository.Save();
            
            return RedirectToAction("Details");
           
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            MeetupScheduler meetup = _meetupRepository.GetMeetingById(id);
            if (meetup != null)
            {
                return View(meetup);
            }
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Delete(MeetupScheduler meetup, int id)
        {

            _meetupRepository.RemoveMeetup(id);
            _meetupRepository.Save();

            return RedirectToAction("Index");
        }

    }
}
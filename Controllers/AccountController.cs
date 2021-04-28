using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SilentAthleticsWebApp.Models;

namespace SilentAthleticsWebApp.Controllers
{
    public class AccountController : Controller
    {
        private IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepo)
        {
            _accountRepository = accountRepo;

        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(Account account)
        {
            _accountRepository.Add(account);

            if (account.Id < 1)
            {
                return View(account);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Account account)
        {
            bool isValidAccount = _accountRepository.Login(account);
            if (isValidAccount)
            {
                return RedirectToAction("Index");
            }
            return View(account);
        }

        public IActionResult Logout()
        {
            _accountRepository.Logout();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {

            IQueryable<Account> allAccounts = _accountRepository.GetAllAccounts();
            return View(allAccounts);


        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Account account)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _accountRepository.InsertAccount(account);
                    _accountRepository.Save();

                    return RedirectToAction("Details");
                }
            }

            catch (DataException)
            {
                ModelState.AddModelError("", "Can't save changes, Try Again..");

            }
            return View(account);


        }



        public IActionResult Details(int id)
        {
            Account account = _accountRepository.GetAccountByID(id);
            return View(account);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Account account = _accountRepository.GetAccountByID(id);
            return View(account);
        }



        public IActionResult Delete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _accountRepository.DeleteAccount(id);
                    _accountRepository.Save();

                    return RedirectToAction("Details");
                }
            }

            catch (DataException)
            {
                ModelState.AddModelError("", "Can't save changes, Try Again..");

            }
            Account account = _accountRepository.GetAccountByID(id);
            return View(account);

        }



    }

}

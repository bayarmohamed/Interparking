using Interparking.DAL.Abstraction;
using Interparking.DAL.Model;
using Interparking.WeppApp.Command;
using Interparking.WeppApp.Models.User;
using MediatR;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interparking.WeppApp.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        private readonly IMediator mediator;


        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                mediator.Send(new CreateUserCommand
                {
                    email = user.Email,
                    name = user.Name,
                    password = user.Password
                });

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }

    }
}
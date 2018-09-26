using BLL.Contracts;
using DAL.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IClientService _clientService;
        //private readonly IGroupService _groupService;

       public HomeController(/*IClientService clientService, IGroupService groupService*/)
        {
            //_clientService = clientService;
            //_groupService = groupService;
        }

        //public async Task<IHttpActionResult> GetClients()
        //{
        //    var clients = await _clientService.GetAllClientsAsync();
        //    return;
        //}
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}

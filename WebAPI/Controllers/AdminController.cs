using BLL.Contracts;
using DAL.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdminController : ApiController
    {
        private readonly IClientService _clientService;
        private readonly IGroupService _groupService;

        public AdminController(IGroupService groupService, IClientService clientService)
        {
            _clientService = clientService;
            _groupService = groupService;
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetClients()
        {
            var clients = await _clientService.GetAllClientsAsync();
            return Ok(clients);
        }

        [HttpPost]
        [Route("AddClient")]
        public async Task<IHttpActionResult> AddClient(Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _clientService.CreateClientAsync(client);
            return Ok();
        }
    }
}
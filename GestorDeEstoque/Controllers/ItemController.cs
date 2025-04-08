using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestorDeEstoque.Data;
using GestorDeEstoque.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestorDeEstoque.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ItemController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(Item item)
        {
            if (item == null)
            {
                return BadRequest("Dados inválidos!");
            }

            _appDbContext.WebApiItensDB.Add(item);

            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, item);
        }
    }
}
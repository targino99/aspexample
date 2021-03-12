using System.Collections.Generic;
using WebApiFornecedor.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiFornecedor.Controllers
{
    [Route("api/[controller]")]
    public class FornecedoresController : ControllerBase
    {
        [HttpGet]
        public List<Fornecedor> Get()
        {
            Fornecedor Fornecedores = new Fornecedor();
            return Fornecedores.ListarFornecedores();
        }
    }
}

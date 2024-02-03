using ExemploAPICSharp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using ExemploAPICSharp.Model; clicando na onde está com erro e alt + enter

namespace ExemploAPICSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet("GetPessoa")]
        public Pessoa GetPessoa()
        {
            var vPessoa = new Pessoa();
            vPessoa.Id = 1;
            vPessoa.Nome = "José da Couves";
            vPessoa.NumeroCelular = "(18) 98569-7845";
            
            return vPessoa;
        }
    }
}

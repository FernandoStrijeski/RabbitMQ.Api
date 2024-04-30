using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rabbit.Models.Entities;
using Rabbit.Services.Interfaces;

namespace Rabbit.Publisher.Api.Controllers
{
    /// <summary>
    /// Classe controladora dos endPoints de mensagens
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class RabbitMessageController : ControllerBase
    {
        private readonly IRabbitMessageService _service;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="service"></param>
        public RabbitMessageController(IRabbitMessageService service)
        {
            _service = service;
        }

        /// <summary>
        /// Adiciona uma mensagem na fila
        /// </summary>
        /// <response code="200">Retorna que ocorreu sucesso no envio da mensagem</response>
        /// <response code="400">Retorna o erro</response>
        /// <response code="401">Um token Bearer válido é necessário para autenticar a chamada</response>
        /// <response code="403">Token não é válido para esta requisição ou não possui credenciais necessárias</response>       
        [ProducesResponseType(typeof(NoContentResult), StatusCodes.Status200OK)]
        [HttpPost]
        //[Authorize(Roles = "R001")]
        public void AddMessage(RabbitMessage mensagem)
        {
            _service.SendMessage(mensagem);
        }
    }
}

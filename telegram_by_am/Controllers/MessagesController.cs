using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace telegram_by_am.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        readonly Discord1135Context _context;

        public MessagesController(Discord1135Context _context)
        {
            this._context = _context;
        }

        [HttpPost("SendMessages")]
        public async Task<ActionResult> SendMessages(Chat chat)
        {
            _context.Chats.Add(chat);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("GetMessages")]
        public async Task<List<Chat>> GetMessages()
        {
            await Task.Delay(1000);
            List<Chat> messages = new List<Chat>();
            messages = _context.Chats.ToList();
            return messages;
        }
    }
}

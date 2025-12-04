using Microsoft.AspNetCore.Mvc;
using ReserveringssysteemzonderEF;

namespace ReserveringssysteemzonderEFAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GuestController : Controller
    {
        private readonly DAL dal;

        public GuestController(DAL _dal)
        {
            dal = _dal;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var guests = dal.GetAllGuests();
            return Ok(guests);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var guest = dal.GetGuestById(id);
            if (guest == null) return NotFound();
            return Ok(guest);
        }

        [HttpPost]
        public IActionResult Create(Guest guest)
        {
            dal.AddGuest(guest);
            return CreatedAtAction(nameof(GetById), new { id = guest.GuestID }, guest);
        }
        /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// ///
        [HttpPut("{id}")]
        public IActionResult Update(int id, Guest guest)
        {
            if (id != guest.GuestID) return BadRequest();
            dal.UpdateGuest(guest);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            dal.DeleteGuest(id);
            return NoContent();
        }
    }
}

using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;
        public HotelsController(IHotelService hotelservice)
        {
            _hotelService = hotelservice;
        }
        /// <summary>
        /// get all hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var hotels = await _hotelService.GetAllHotel();
            return Ok(hotels);
        }

        /// <summary>
        /// get them by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetHotelsById(int id)
        {
            var hotel=  _hotelService.GetHotelById(id);
            if(hotel!=null){
            
                return Ok(hotel);
            
            }
            return NotFound();
        }

        /// <summary>
        /// create a hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPost]
        public Hotel Post([FromBody]Hotel hotel)
        {
            return _hotelService.CreateHotel(hotel);
        }
        /// <summary>
        /// update the hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPut]
        public Hotel Put([FromBody] Hotel hotel)
        {
            return _hotelService.UpdateHotel(hotel);
        }
        
        /// <summary>
        /// delete the hotel
        /// </summary>
        /// <param name="id"></param>

        [HttpDelete]
        public void Delete(int id)
        {
            _hotelService.DeleteHotel(id);
        }
    }
}

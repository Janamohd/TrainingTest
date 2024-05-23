using DataAccess.Model;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class itemController : ControllerBase
    {
        private readonly IItemsRepository _ItemsRepository;
        public itemController(IItemsRepository itemsRepository)
        {
           this. _ItemsRepository = itemsRepository;
        }
        [HttpGet]
        public ActionResult Get()
        {

            var getItems = _ItemsRepository.GetAll();   
            return Ok(getItems);

        }
        [HttpPost]
        public ActionResult Create(Items item)
        {

            var getItems = _ItemsRepository.GetAll();
            return Ok(getItems);

        }
    }
   
}

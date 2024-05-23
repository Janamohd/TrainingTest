using DataAccess.Model;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ItemsWorksheet.Controllers
{
    public class ItemController : Controller     
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemController(IItemsRepository itemsRepository)
        {
            this._itemsRepository = itemsRepository;
        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Items items) 
        {
            _itemsRepository.Add(items);
            return View();
        }

        public IActionResult GetItems()
        {
            return View(_itemsRepository.GetAll());
        }
    }
}

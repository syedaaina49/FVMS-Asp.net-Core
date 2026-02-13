using Asp.net_Core_2024_07D.Models;
using Asp.net_Core_2024_07D.Data;
using Microsoft.AspNetCore.Mvc;



namespace Asp.net_Core_2024_07D.Controllers
{
   
    public class VoucherController : Controller

    {
        
        [HttpGet]
        public IActionResult Create( )
        {
            
            return View();
        }

        private readonly ApplicationDbContext _context;

        public VoucherController(ApplicationDbContext context)
        {
            _context =context;
        }

        [HttpPost]
        public IActionResult Create(Voucher model)
        {
            //model.Id = 1;
            model.Status = "Paid";

            _context.Voucher.Add(model);
            _context.SaveChanges();

            ViewBag.Message = "Fee Voucher Generated Successfully";
            ViewBag.ShowPreview = true;
            ViewBag.PreviewData = model;

            ModelState.Clear();

            return View(new Voucher());
        }

    }
}

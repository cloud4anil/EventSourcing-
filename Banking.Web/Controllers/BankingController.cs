using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Banking.Web.Models;
using Banking.Web.Services;
using Banking.Web.Models.DTO;

namespace Banking.Web.Controllers
{
    public class BankingController : Controller
    {
        private readonly ITransferService _transferService;
        public BankingController(ITransferService transferService)
        {
            _transferService = transferService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Transfer(TransferViewModel transferViewModel)
        {

            var transferDto = new TransferDto()
            {
                AccountFrom = transferViewModel.FromAccount,
                AccountTo = transferViewModel.ToAccount,
                TransferAmmount = transferViewModel.TeansferAmmount
            };

            await _transferService.Transfer(transferDto);
          
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

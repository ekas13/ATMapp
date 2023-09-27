using EnalyzerATM.Data;
using EnalyzerATM.Services;
using Microsoft.AspNetCore.Mvc;

namespace EnalyzerATM.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransactionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> InputForm()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Deposit(int amount)
        {

            TransactionCalculator calculator = new TransactionCalculator(_context);
            ATMDeposit atmDeposit = calculator.call(amount);
            TransactionLog log = new TransactionLog(_context);
            log.call(atmDeposit);

            return View(atmDeposit);
        }

    }
}

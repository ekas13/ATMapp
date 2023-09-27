using EnalyzerATM.Data;
using System.Linq;
using EnalyzerATM.Models;

namespace EnalyzerATM.Services
{
    public class TransactionLog
    {
        private readonly ApplicationDbContext _context;

        public TransactionLog(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public void call(ATMDeposit deposit)
        {
            int currentId;

            bool isEmptyTable = !_context.Transactions.Any();

            if (isEmptyTable)
                currentId = 1;
            else
                currentId = _context.Transactions.OrderByDescending(transaction => transaction.Id).ToList().First().Id + 1;

            _context.Add<Transactions>(new Transactions {Id = currentId, Amount = deposit.getCurrentAmount(), Time = DateTime.Now });

            _context.SaveChanges();
        }
    }
}
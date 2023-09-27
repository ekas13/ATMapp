using System.Linq;
using EnalyzerATM.Data;
using EnalyzerATM.Models;
using EnalyzerATM.Services;

namespace EnalyzerATM.Services
{
    public class TransactionCalculator
    {
        private readonly ApplicationDbContext _context;

        public TransactionCalculator(ApplicationDbContext context)
        {
            _context = context;
        }

        public ATMDeposit call(int amount)
        {
            ATMDeposit atmDeposit = new ATMDeposit();

            calculateBankNotes(amount, atmDeposit);
            calculateBigCoins(amount - atmDeposit.getCurrentAmount(), atmDeposit);
            calculateSmallCoins(amount - atmDeposit.getCurrentAmount(), atmDeposit);

            return atmDeposit;
        }

        private void calculateBankNotes(int amount, ATMDeposit atmDeposit)
        {
            List<Notes> notes = _context.Notes.Where(note => note.Count > 0)
                                              .OrderByDescending(note => note.Value)
                                              .ToList();
            foreach (Notes note in notes)
            {
                int division = amount / note.Value;
                int count = division <= note.Count ? division : note.Count;
                note.Count -= count;
                amount -= note.Value * count;

                atmDeposit.addNotes(note.Value, count);
            }

            _context.SaveChanges();

        }

        private void calculateBigCoins(int amount, ATMDeposit atmDeposit)
        {
            List<Coins> coins = _context.Coins.Where(coin => coin.Count > 0)
                                              .Where(coin => coin.Diameter > 20)
                                              .OrderByDescending(coin => coin.Value)
                                              .ToList();
            foreach (Coins coin in coins)
            {
                int division = amount / coin.Value;
                int count = division <= coin.Count ? division : coin.Count;
                coin.Count -= count;
                amount -= coin.Value * count;

                atmDeposit.addBigCoins(coin.Value, count);
            }

            _context.SaveChanges();
        }

        private void calculateSmallCoins(int amount, ATMDeposit atmDeposit)
        {
            List<Coins> coins = _context.Coins.Where(coin => coin.Count > 0)
                                              .Where(coin => coin.Diameter <= 20)
                                              .OrderByDescending(coin => coin.Value)
                                              .ToList();
            foreach (Coins coin in coins)
            {
                int division = amount / coin.Value;
                int count = division <= coin.Count ? division : coin.Count;
                coin.Count -= count;
                amount -= coin.Value * count;

                atmDeposit.addSmallCoins(coin.Value, count);
            }

            _context.SaveChanges();
        }
    }
}


using EnalyzerATM.Services;
using NUnit.Framework;


namespace EnalyzerATM.Tests
{
    [TestFixture]
    public class ATMDepositTests
    {
        [Test]
        public void AddNotesShouldAddNotesToDictionary()
        {
            
            var atmDeposit = new ATMDeposit();

            
            atmDeposit.addNotes(10, 5);

            
            Dictionary<int, int> notes = atmDeposit.getNotes();
            Assert.IsTrue(notes.ContainsKey(10));
            Assert.AreEqual(5, notes[10]);
        }

        [Test]
        public void AddBigCoinsShouldAddBigCoinsToDictionary()
        {
         
            var atmDeposit = new ATMDeposit();

         
            atmDeposit.addBigCoins(25, 3);

         
            Dictionary<int, int> bigCoins = atmDeposit.getBigCoins();
            Assert.IsTrue(bigCoins.ContainsKey(25));
            Assert.AreEqual(3, bigCoins[25]);
        }

        [Test]
        public void AddSmallCoins_Should_AddSmallCoinsToDictionary()
        {
            
            var atmDeposit = new ATMDeposit();

            
            atmDeposit.addSmallCoins(5, 10);

            
            Dictionary<int, int> smallCoins = atmDeposit.getSmallCoins();
            Assert.IsTrue(smallCoins.ContainsKey(5));
            Assert.AreEqual(10, smallCoins[5]);
        }

        [Test]
        public void GetCurrentAmount_Should_ReturnCurrentAmount()
        {
            
            var atmDeposit = new ATMDeposit();
            atmDeposit.addNotes(10, 5);

            
            int currentAmount = atmDeposit.getCurrentAmount();

           
            Assert.AreEqual(50, currentAmount);
        }

        [Test]
        public void SetCurrentAmount_Should_SetCurrentAmount()
        {
            
            var atmDeposit = new ATMDeposit();

            
            atmDeposit.setCurrentAmount(100);

            
            int currentAmount = atmDeposit.getCurrentAmount();
            Assert.AreEqual(100, currentAmount);
        }
    }
}

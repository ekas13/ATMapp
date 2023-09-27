using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using EnalyzerATM.Data;
using EnalyzerATM.Models;
using EnalyzerATM.Services;

namespace EnalyzerATM.Tests
{
    [TestFixture]
    public class TransactionCalculatorTests
    {

        [Test]
        public void Call_Should_CalculateATMDeposit()
        {

            int amount = 135;
            var atmDeposit = new ATMDeposit();
            var notesData = new List<Notes>
            {
                new Notes { Value = 100, Count = 5 },
                new Notes { Value = 50, Count = 10 }
            }.AsQueryable();

            var coinsData = new List<Coins>
            {
                new Coins { Value = 25, Count = 10, Diameter = 25 },
                new Coins { Value = 10, Count = 20, Diameter = 15 },
            }.AsQueryable();

            var mockDbSetNotes = new Mock<DbSet<Notes>>();
            var mockDbSetCoins = new Mock<DbSet<Coins>>();

            mockDbSetNotes.As<IQueryable<Notes>>().Setup(m => m.Provider).Returns(notesData.Provider);
            mockDbSetNotes.As<IQueryable<Notes>>().Setup(m => m.Expression).Returns(notesData.Expression);
            mockDbSetNotes.As<IQueryable<Notes>>().Setup(m => m.ElementType).Returns(notesData.ElementType);
            mockDbSetNotes.As<IQueryable<Notes>>().Setup(m => m.GetEnumerator()).Returns(notesData.GetEnumerator());

            mockDbSetCoins.As<IQueryable<Coins>>().Setup(m => m.Provider).Returns(coinsData.Provider);
            mockDbSetCoins.As<IQueryable<Coins>>().Setup(m => m.Expression).Returns(coinsData.Expression);
            mockDbSetCoins.As<IQueryable<Coins>>().Setup(m => m.ElementType).Returns(coinsData.ElementType);
            mockDbSetCoins.As<IQueryable<Coins>>().Setup(m => m.GetEnumerator()).Returns(coinsData.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>(new DbContextOptions<ApplicationDbContext>());
            mockContext.Setup(c => c.Notes).Returns(mockDbSetNotes.Object);
            mockContext.Setup(c => c.Coins).Returns(mockDbSetCoins.Object);

            var calculator = new TransactionCalculator(mockContext.Object);


            ATMDeposit result = calculator.call(amount);


            Assert.AreEqual(135, result.getCurrentAmount());
            Assert.AreEqual(1, result.getNotes()[100]);
            Assert.AreEqual(1, result.getBigCoins()[25]);
            Assert.AreEqual(1, result.getSmallCoins()[10]);

        }

        /** [Test]
        public void CalculateBankNotes_Should_UpdateATMDeposit()
        {
            
            int amount = 150;
            var atmDeposit = new ATMDeposit();
            var notesData = new List<Notes>
            {
                new Notes { Value = 100, Count = 5 },
                new Notes { Value = 50, Count = 10 },
                new Notes { Value = 20, Count = 8 }
            }.AsQueryable();

            var mockDbSet = new Mock<DbSet<Notes>>();
            mockDbSet.As<IQueryable<Notes>>().Setup(m => m.Provider).Returns(notesData.Provider);
            mockDbSet.As<IQueryable<Notes>>().Setup(m => m.Expression).Returns(notesData.Expression);
            mockDbSet.As<IQueryable<Notes>>().Setup(m => m.ElementType).Returns(notesData.ElementType);
            mockDbSet.As<IQueryable<Notes>>().Setup(m => m.GetEnumerator()).Returns(notesData.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(c => c.Notes).Returns(mockDbSet.Object);

            var calculator = new TransactionCalculator(mockContext.Object);

            
            calculator.calculateBankNotes(amount, atmDeposit);

            
            Assert.AreEqual(1, atmDeposit.getNotes()[100]);
            Assert.AreEqual(1, atmDeposit.getNotes()[50]);
            Assert.AreEqual(0, atmDeposit.getNotes()[20]); 
    }*/
    }
}

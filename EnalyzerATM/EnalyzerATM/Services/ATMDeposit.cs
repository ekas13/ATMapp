using EnalyzerATM.Models;

namespace EnalyzerATM.Services
{
    public class ATMDeposit
    {
        public ATMDeposit()
        {
            this.currentAmount = 0;
        }

        private int currentAmount;
        private Dictionary<int, int> notes = new Dictionary<int, int>();
        private Dictionary<int, int> smallCoins = new Dictionary<int, int>();
        private Dictionary<int, int> bigCoins = new Dictionary<int, int>();

        public void addNotes(int value, int count)
        {
            if (count == 0)
                return;

            notes.Add(value, count);
            setCurrentAmount(currentAmount + count * value);
        }
        public void addBigCoins(int value, int count)
        {
            if (count == 0)
                return;

            bigCoins.Add(value, count);
            setCurrentAmount(currentAmount + count * value);
        }
        public void addSmallCoins(int value, int count)
        {
            if (count == 0)
                return;

            smallCoins.Add(value, count);
            setCurrentAmount(currentAmount + count * value);
        }
        public int getCurrentAmount()
        {
            return currentAmount;
        }

        public void setCurrentAmount(int value)
        {
            this.currentAmount = value;
        }

        public Dictionary<int, int> getNotes()
        {
            return notes;
        }

        public Dictionary<int, int> getBigCoins()
        {
            return bigCoins;
        }

        public Dictionary<int, int> getSmallCoins()
        {
            return smallCoins;
        }
    }
}

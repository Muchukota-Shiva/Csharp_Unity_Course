using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// A mutual fund
    /// </summary>
    public class MutualFund : InvestmentAccount
    {
        const float ServiceChargePercent = 0.01f;
        protected float deposit;


        #region Contructor

        public MutualFund(float deposit) : base(deposit)
        {
            this.deposit = deposit;
        }

        #endregion

        #region Public methods

        public override void AddMoney(float amount)
        {
            balance = balance + (balance - (balance * ServiceChargePercent));
        }

        /// <summary>
        /// Updates the balance by adding 6%
        /// </summary>
        public override void UpdateBalance()
        {
            // delete code below and replace with your code
            //throw new NotImplementedException();
            balance += (balance * 6/100);
            //Console.WriteLine(balance);
        }

        /// <summary>
        /// Provides balance with account type caption
        /// </summary>
        /// <returns>balance with caption</returns>
        public override string ToString()
        {
            return "Mutual Fund Balance: " + balance;
        }

        #endregion
    }
}

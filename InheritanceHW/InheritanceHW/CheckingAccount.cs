using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    public class CheckingAccount : Account
    {
        private decimal transactionFee;

        public CheckingAccount(decimal balance, decimal transactionFee) : base(balance)
        {
            TransactionFee = transactionFee;
        }

        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            }
            set
            {
                if (transactionFee < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(TransactionFee)} must " +
                        $"be greater than or equal to 0.00");
                }
                transactionFee = value;
            }
        }

        public override decimal Credit(decimal amount)
        {
            return base.Credit(amount) - TransactionFee;
        }

        public override bool Debit(decimal amount)
        {
            return base.Debit(amount + TransactionFee);
        }

    }
}

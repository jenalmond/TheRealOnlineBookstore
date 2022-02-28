using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public interface ITransactionRepository
    {
        IQueryable<Transaction> Transactions { get; }

        void SaveTransaction(Transaction tran);
    }
}

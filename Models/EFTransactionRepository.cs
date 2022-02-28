using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public class EFTransactionRepository : ITransactionRepository
    {
        private OnlineBookstoreContext context;
        public EFTransactionRepository (OnlineBookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Transaction> Transactions => context.Transactions
            .Include(x => x.Lines)
            .ThenInclude(x =>x.Book);

        public void SaveTransaction(Transaction tran)
        {
            context.AttachRange(tran.Lines.Select(x =>x.Book));
            if (tran.CheckoutID == 0)
            {
                context.Transactions.Add(tran);
            }
            context.SaveChanges();
        }
    }
}

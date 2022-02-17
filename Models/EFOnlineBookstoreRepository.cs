using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public class EFOnlineBookstoreRepository :IOnlineBookstoreRepository
    {
        private OnlineBookstoreContext context { get; set; }
        public EFOnlineBookstoreRepository(OnlineBookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}

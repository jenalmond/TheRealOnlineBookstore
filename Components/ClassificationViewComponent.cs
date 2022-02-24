using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Components
{
    public class ClassificationViewComponent : ViewComponent
    {
        private IOnlineBookstoreRepository repo { get; set; }
        public  ClassificationViewComponent (IOnlineBookstoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            var types = repo.Books
                .Select(x => x.Classification)
                .Distinct()
                .OrderBy(x => x);
            return View(types);
        }
    }
}

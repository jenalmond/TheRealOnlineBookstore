using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public class Transaction
    {
        [Key]
        [BindNever]
        public int CheckoutID { get; set; }
        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }
        [Required(ErrorMessage ="Please input a first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please input a last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please input an address")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required(ErrorMessage = "Please input a city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please input a state")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please input a zip code")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please input a phone number")]
        [Phone]
        public string Phone { get; set; }

    }
}

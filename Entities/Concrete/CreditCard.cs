using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CreditCard : IEntity
    {
        public int CreditCardId { get; set; }
        public string CardNumber { get; set; }
        public string Expiration { get; set; }
        public int CVV { get; set; }
        public int UserId { get; set; }
        public string NameOfUser { get; set; }

    }
}
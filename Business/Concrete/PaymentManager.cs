using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        
        public IResult MakePayment(Payment payment)
        {
            if (payment.Amount < 140)
            {
                return new ErrorResult("Payment Test Error");
            }
            return new SuccessResult();
        }
    }
}

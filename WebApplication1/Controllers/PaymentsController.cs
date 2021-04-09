using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class PaymentsController:ControllerBase
    {
        IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }


        [HttpPost("payment")]
        public IActionResult MakePayment(Payment payment)
        {
            var result = _paymentService.MakePayment(payment);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
        
    }
}

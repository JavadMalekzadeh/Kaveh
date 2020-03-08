using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using static Kaveh.Domain.Infrustructure.GlobalCnst;

namespace Kaveh.Domain.Models
{
    public class Havaleh
    {
        public ObjectId _id { get; set; }
        public string Customer { get; set; }
        public double Payment { get; set; }
        public PaymentType MyProperty { get; set; }
        public string BankName { get; set; }
        public int Date { get; set; }
        public int Time { get; set; }
        public bool Confirm { get; set; } = false;
        public string ImageUrl { get; set; }

    }
    
}

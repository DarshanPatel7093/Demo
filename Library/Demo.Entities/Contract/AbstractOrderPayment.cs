﻿using Demo.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities.Contract
{
    public abstract class AbstractOrderPayment : BaseModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int SubscriptionId { get; set; }
        public int StandardId { get; set; }
        public int SubjectId { get; set; }
        public int CustomerId { get; set; }
        public int NoofDays { get; set; }
        public string ExpiryDate { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal ActualPrice { get; set; }
        public string OrderDate { get; set; }
        public string Status { get; set; }
        public int TransactionId { get; set; }
        public string Signature { get; set; }
    }
}

using System;

namespace CurrencyConverter.Models
{
    public class AuditEvent
    {

        public AuditEvent()
        {
            this.RequestedTime = DateTime.Now;
        }

        public AuditEvent(string from, string to, decimal amount, decimal conversionRate) : this()
        {
            this.From = from;
            this.To = to;
            this.Amount = amount;
            this.ConversionRate = conversionRate;
        }

        public int Id { get; set; }
        public DateTime RequestedTime { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public decimal Amount { get; set; }
        public decimal ConversionRate { get; set; }
    }
}

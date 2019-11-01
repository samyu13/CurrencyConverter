using CurrencyConverter.Models.Interfaces;
using System;
using System.Collections.Generic;


namespace CurrencyConverter.Models
{
    public class GBPCurrencyConverter : ICurrencyConverter
    {
        private readonly IAuditService auditService;

        public GBPCurrencyConverter(IAuditService auditService)
        {
            this.auditService = auditService;
        }

        static readonly Dictionary<string, decimal> GBPConversionRates = new Dictionary<string, decimal>() {
                { "USD", 0.72m },
                { "AUD", 0.91m },
                { "EUR", 0.98m }
            };

        public decimal convert(string to, decimal amount)
        {
            if (!GBPConversionRates.ContainsKey(to))
            {
                throw new NotImplementedException();
            }
            var conversionRate = GBPConversionRates[to];
            decimal convertedAmount = amount * conversionRate;

            auditService.SaveAudit(new AuditEvent("GBP", to, amount, conversionRate));

            return convertedAmount;
        }
    }
}

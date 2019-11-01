using CurrencyConverter.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace CurrencyConverter.Models
{
    public class AuditService : IAuditService
    {
        private readonly SqlRepository SqlRepository;

        public AuditService(SqlRepository sqlRepository)
        {
            this.SqlRepository = sqlRepository;
        }

        public List<AuditEvent> QueryAudit(DateTime fromDate, DateTime toDate)
        {
            return this.SqlRepository.GetAuditEvents(fromDate, toDate);
        }

        public void SaveAudit(AuditEvent AuditEvent)
        {
            this.SqlRepository.AddAuditEvent(AuditEvent);
        }
    }
}

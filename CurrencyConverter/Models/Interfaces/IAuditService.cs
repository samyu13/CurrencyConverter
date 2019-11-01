using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models.Interfaces
{
    public interface IAuditService
    {
        void SaveAudit(AuditEvent auditEvent);

        List<AuditEvent> QueryAudit(DateTime fromDate, DateTime toDate);
    }
}

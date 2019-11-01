using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    public class SqlRepository
    {
        private readonly AppDbContext _context;
        public SqlRepository(AppDbContext context)
        {
            _context = context;
        }

        public AuditEvent AddAuditEvent(AuditEvent audit)
        {
            try
            {
                _context.AuditLogs.Add(audit);
                _context.SaveChanges();
                return audit;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<AuditEvent> GetAuditEvents(DateTime fromDate, DateTime toDate)
        {
            try
            {
              return  _context.AuditLogs.Where(x => x.RequestedTime >= fromDate && x.RequestedTime <= toDate).ToList();               
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyConverter.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Controllers
{
    [Route("[controller]")]
    public class AuditLogsController : Controller
    {
        private readonly IAuditService auditService;

        public AuditLogsController(IAuditService auditService)
        {
            this.auditService = auditService;
        }
        [HttpGet]
        public IActionResult Index()
        {            
            return View();
        }
        [HttpPost]        
        public IActionResult Index(DateTime fromDate,  DateTime toDate)
        {
            var audits = auditService.QueryAudit(fromDate, toDate);
            return View(audits);
        }
    }
}
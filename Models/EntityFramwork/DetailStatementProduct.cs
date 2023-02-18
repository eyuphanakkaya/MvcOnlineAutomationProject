using MvcOnlineAutomationProject.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcOnlineAutomationProject.Models.EntityFramwork
{
    public class DetailStatementProduct:Entity
    {
        public IEnumerable<Product> Products1 { get; set; }
        public IEnumerable<Detail> Details1 { get; set; }
    }
}
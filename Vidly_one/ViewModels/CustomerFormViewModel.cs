using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_one.Models;

namespace Vidly_one.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}
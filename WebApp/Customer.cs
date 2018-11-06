using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public class Customer
    {
        public int Id { get; set; }

        [Requied, StringLength(45)]
        public string Name { get; set; }
    }
}

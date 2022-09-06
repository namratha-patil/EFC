using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
    
        [Table("Customer")]
        public class Customer
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int ID { get; set; }



            [Required()]
            public string Name { get; set; }



            [Required]
            public int Age { get; set; }



            public virtual ICollection<Order> Orders { get; set; } //navigation prop
        }
    }


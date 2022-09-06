using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
   
        [Table("Book")]
        public class Book
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

            public int BookID { get; set; }

            [Required]
            public string BookName { get; set; }



            [Required]
            public string author { get; set; }



            public int price { get; set; }


        }
    }


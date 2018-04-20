using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinDz
{
    public class Signature
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public  Person Person { get; set; }
        public DateTime SubscribeDate { get; set; }
        [ForeignKey("Document")]
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public string ECP { get; set; }


    }
}

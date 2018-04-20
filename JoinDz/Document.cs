using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinDz
{
  public  class Document
    {
        [Key]
        public int Id { get; set; }
        public virtual IList<Signature> Subscribers { get; set; }
        public string DocumentTheme { get; set; }
        public string DocumentType { get; set; }
        public DateTime CretionDate { get; set; }
        [ForeignKey("Creator")]
        public int PersonId { get; set; }
        public Person Creator { get; set; }
        public DateTime ReviewDate { get; set; }

    }
}

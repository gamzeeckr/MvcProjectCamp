using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Writer
    {        
        [Key]
        public int WriterId { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; } 
        [StringLength(50)]
        public string WriterSurname { get; set; } 
        [StringLength(100)]
        public string WriterImage { get; set; } 
        [StringLength(50)]
        public string WriterMail { get; set; } 
        [StringLength(20)]
        public string WriterPassword { get; set; } 

        // content sınıfı ile ilişki kuruldu. bir yazarın birden fazla içeriği olabilir.
        public ICollection<Content> Contents { get; set; }

        // heading sınıfı ile ilişki kuruldu. bir yazarın birden çok başlığı olabilir.
        public ICollection<Heading> Headings { get; set; }
    }
}

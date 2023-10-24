using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Concrate
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
        public string WriterImg { get; set; }
        [StringLength(200)]
        public string WriterAbout { get; set; } 
        [StringLength(200)]
        public string WriterMail { get; set; }
        [StringLength(200)]
        public string WriterPassword { get; set; }
        [StringLength(100)]
        public string WriterTitle { get; set; }

        #region Heading tablo ilişkisi
        public ICollection<Heading> Headings { get; set; }
        #endregion

        #region Content tablo ilişkisi
        public ICollection<Content> Contents { get; set; } 
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Concrate
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        [StringLength(1000)]
        public string ContentText { get; set; }
        public DateTime ContentDate { get; set; }

        #region Heading tablo ilişkisi
        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }
        #endregion

        #region Writer tablo ilişkisi
        public int? WriterId { get; set; }
        public virtual Writer Writer { get; set; } 
        #endregion
    }
}
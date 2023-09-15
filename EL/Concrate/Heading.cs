using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Concrate
{
    public class Heading
    {
        [Key]
        public int HeadingId { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        #region Category tablo ilişkisi
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        #endregion

        #region Writer tablo ilişkisi
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
        #endregion

        #region Content tablo ilişkisi
        public ICollection<Content> Contents { get; set; } 
        #endregion
    }
}
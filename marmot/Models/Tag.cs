using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Marmot.Models
{
    public class Tag
    {
        [Required]
        public Guid TagId { get; set; } = Guid.NewGuid();
        public Guid BookmarkId { get; set; }
        public string UserId { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }

        // audit properties
        [Required]
        [MaxLength(255)]
        public string CreatedBy { get; set; } = WindowsIdentity.GetCurrent().Name;
        [Required]
        public DateTimeOffset CreatedDateUtc { get; set; } = DateTimeOffset.UtcNow;
        [MaxLength(255)]
        public string ModifiedBy { get; set; } = WindowsIdentity.GetCurrent().Name;
        public DateTimeOffset ModifiedDateUtc { get; set; } = DateTimeOffset.UtcNow;

        public virtual Bookmark Bookmark { get; set; }
    }
}

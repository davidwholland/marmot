using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Marmot.Models
{
    public class Bookmark
    {
        [Required]
        public Guid BookmarkId { get; set; } = Guid.NewGuid();
        [Required]
        public Guid UserId { get; set; } // TODO: fix user id storage
        [MaxLength(2000)]
        public string Url { get; set; }
        public string Title { get; set; }
        public bool IsFavorite { get; set; } = false;
        public bool IsArchived { get; set; } = false;

        // audit properties
        [Required]
        [MaxLength(255)]
        public string CreatedBy { get; set; } = WindowsIdentity.GetCurrent().Name;
        [Required]
        public DateTimeOffset CreatedDateUtc { get; set; } = DateTimeOffset.UtcNow;
        [MaxLength(255)]
        public string ModifiedBy { get; set; } = WindowsIdentity.GetCurrent().Name;
        public DateTimeOffset ModifiedDateUtc { get; set; } = DateTimeOffset.UtcNow;

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Tag Tag { get; set; }
    }
}

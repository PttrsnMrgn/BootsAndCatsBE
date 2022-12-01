using System;
using System.Collections.Generic;

namespace BootsAndCats
{
    public partial class Review
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string AlbumId { get; set; }
        public int? Rating { get; set; }
        public string? ReviewContent { get; set; }
        public bool? Recommendation { get; set; }
        public string? Tag { get; set; }
        public DateTime? DateSubmitted { get; set; } = DateTime.Now;

        public virtual User? User { get; set; }
    }
}

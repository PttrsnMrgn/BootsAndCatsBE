using System;
namespace BootsAndCats.DTOs
{
	public class ReviewPost
	{
        public int? Rating { get; set; }
        public string? ReviewContent { get; set; }
        public bool? Recommendation { get; set; }
        public string? Tag { get; set; }
        public DateTime? DateSubmitted { get; set; } = DateTime.Now;
        public ICollection<Review> Reviews { get; set; }
       
    }
}


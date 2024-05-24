using System.ComponentModel.DataAnnotations;

namespace BlazorUrls.Data
{
    public class LinkAnalytic
    {
        [Key]
        public long Id { get; set; }

        public long LinkId { get; set; }

        public DateTime ClicedAt { get; set; }

        public virtual Link Link { get; set; }
    }
}

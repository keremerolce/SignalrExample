namespace WebSignalrDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MessageGroup")]
    public partial class MessageGroup
    {
        public int MessageGroupId { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime MessageTime { get; set; }

        public int UserId { get; set; }

        public int GroupId { get; set; }

        public virtual Group Group { get; set; }

        public virtual User User { get; set; }
    }
}

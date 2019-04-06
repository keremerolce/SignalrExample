namespace WebSignalrDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserGroup")]
    public partial class UserGroup
    {
        public int UserGroupId { get; set; }

        public int UserId { get; set; }

        public int GroupId { get; set; }

        public virtual Group Group { get; set; }

        public virtual User User { get; set; }
    }
}

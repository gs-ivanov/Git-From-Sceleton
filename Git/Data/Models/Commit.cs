namespace Git.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;
    public class Commit
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        public string Description { get; init; }

        public DateTime CreatedOn { get; init; } = DateTime.UtcNow;

        public string CreatorId { get; init; }

        public User Creator { get; init; }

        public string RepositoryId { get; init; }

        public Repository Repository { get; init; }
    }
}
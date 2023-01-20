namespace Git.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Repository
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(RepositoryMaxLength)]
        public string Name { get; init; }

        public DateTime CreatedOn { get; init; } = DateTime.UtcNow;

        public bool IsPublic { get; init; }

        public string OwnerId { get; init; }

        public User Owner { get; init; }

        public IEnumerable<Commit> Commits { get; init; } = new List<Commit>();
    }
}
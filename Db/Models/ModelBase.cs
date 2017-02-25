using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Db.Models
{
    public abstract class ModelBase
    {
        protected ModelBase()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = CreatedAt;
        }

        [Key]
        public virtual Guid Id { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

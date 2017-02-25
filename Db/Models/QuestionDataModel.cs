using System;
using System.ComponentModel.DataAnnotations.Schema;
using static Db.Models.Types;

namespace Db.Models
{
    [Table("Questions")]
    public class QuestionDataModel : ModelBase
    {
        public QuestionDifficulty Difficulty { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int Points { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}

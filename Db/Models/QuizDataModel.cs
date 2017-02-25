using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static Db.Models.Types;

namespace Db.Models
{
    [Table("Quiz")]
    public class QuizDataModel : ModelBase
    {
        public QuizCategory QuizCategory { get; set; }
        public int Score { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}

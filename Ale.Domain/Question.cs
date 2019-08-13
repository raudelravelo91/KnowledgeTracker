using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ale.Data
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public int Text { get; set; }

        public List<string> PossibleAnswers { get; set; }
    }
}

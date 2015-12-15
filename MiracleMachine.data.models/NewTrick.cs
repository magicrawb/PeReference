using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiracleMachine.data.models
{
    public class NewTrick
    {
        [Key]
        public int NewTrickId { get; set; }
        public string TrickName { get; set; }

        public Nullable<int> PropId { get; set; }
        [ForeignKey("PropId")]
        public virtual ICollection<Prop> Props { get; set; }

        public Nullable<int> TheoryId { get; set; }
        [ForeignKey("TheoryId")]
        public virtual Theory Theory { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiracleMachine.data.models
{
    public class Prop
    {
        [Key]
        public int PropId { get; set; }
        public string PropName { get; set; }
    }
}
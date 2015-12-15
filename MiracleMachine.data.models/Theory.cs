using System.ComponentModel.DataAnnotations;

namespace MiracleMachine.data.models
{
    public class Theory
    {
        [Key]
        public int TheoryId { get; set; }
        public string TheoryName { get; set; }
        public string TheoryDescription { get; set; }
    }
}
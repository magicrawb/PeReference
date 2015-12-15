using MiracleMachine.data.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiracleMachine.Models
{
    public class NewTrickViewModel : NewTrick
    {
        [Key]
        public int Id { get; set; }
        public IList<Prop> UserProps { get; set; }
    }
}
using MiracleMachine.data.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiracleMachine.Models
{
    public class ProfileViewModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<NewTrick> NewTricks { get; set; }

    }

    public class EditProfileViewModel
    {

    }
}
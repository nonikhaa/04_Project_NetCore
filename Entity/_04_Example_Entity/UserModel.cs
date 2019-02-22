using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace _04_Example_Entity
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string UserRole { get; set; }
        public string TimeStamp { get; set; }
    }
}

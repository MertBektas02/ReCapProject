using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
    public class UsersDetailDto:IDto
    {
        //customer class'tan aldıklarım
        public int UserId { get; set; }
        public string CompanyName { get; set; }

        //user class'tan aldıklarım
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

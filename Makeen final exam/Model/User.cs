using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Makeen_final_exam.Model
{
    public class User
    {
        public  Guid Id { get; set; }
        public  string PhoneNumber { get; set; }
        public  string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string NationalCode { get; set; }
        public string MemberShipCode { get; set; }
        public DateTime BeganContractDateTime { get; set; }
        public DateTime EndContractDateTimeDateTime { get; set; }

    }
}

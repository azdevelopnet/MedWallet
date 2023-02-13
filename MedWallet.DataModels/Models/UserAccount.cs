using System;
namespace MedWalletAPI.Models
{
	public class UserAccount
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public Address Address { get; set; }
        public string Password { get; set; }
		public DateTime DOB { get; set; }
		public Physician PrimaryCare { get; set; }
    }
}


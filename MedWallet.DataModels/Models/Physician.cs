using System;
namespace MedWalletAPI.Models
{
	public class Physician
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
    }
}


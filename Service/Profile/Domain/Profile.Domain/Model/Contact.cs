

namespace Profile.Domain.Model
{
    public class Contact
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string phoneNumber, string email)
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }

    }
}

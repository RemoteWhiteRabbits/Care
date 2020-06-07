using Profile.Domain.Enum;
using System;


namespace Profile.Domain.Model
{
    public class Profile
    {
        public Guid Id { get; }
        public PersonalInfo Person { get; }
        public Contact Contact { get; }
        public string NickName { get; }
        public string PasswordToken { get; }
        public ProfyleType ProfileType { get; }
        public bool IsVerified { get; }
        public string SessionToken { get; }


        public Profile(Guid id, PersonalInfo person, Contact contact, string nickName, string passwordToken, ProfyleType profileType, bool isVerified, string sessionToken)
        {
            Id = id;
            Person = person;
            Contact = contact;
            NickName = nickName;
            PasswordToken = passwordToken;
            ProfileType = profileType;
            IsVerified = isVerified;
            SessionToken = sessionToken;
        }
    }
}

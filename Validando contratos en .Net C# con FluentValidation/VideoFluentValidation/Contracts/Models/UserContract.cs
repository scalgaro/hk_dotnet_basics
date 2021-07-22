using System;

namespace VideoFluentValidation.Contracts.Models
{
    public class UserContract
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
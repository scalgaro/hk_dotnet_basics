namespace VideoFluentValidation.Contracts.Requests
{
    public class CreateUserRequest
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
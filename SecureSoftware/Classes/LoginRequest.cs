namespace SecureSoftware.Classes
{
    public class LoginRequest
    {
        public MasterAccount user { get; set; }
        public string jwt { get; set; }

        public LoginRequest(MasterAccount user, string jwt, string session_id)
        {
            if (user == null)
            {
                throw new ArgumentException($"'{nameof(user)}' cannot be null or empty.", nameof(user));
            }

            if (string.IsNullOrEmpty(jwt))
            {
                throw new ArgumentException($"'{nameof(jwt)}' cannot be null or empty.", nameof(jwt));
            }

            this.user = user;
            this.jwt = jwt;
        }
    }
}

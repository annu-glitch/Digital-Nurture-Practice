namespace JwtAuth.Models   
{
    public class LoginModel    //acting only as a data transfer object to receive API data, no real database connectin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

namespace TokenApp.Models
{
    /// <summary>
    /// The main user who is responsible for doing all the operations
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isActive {  get; set; }
        public List<Token> tokens {  get; set; }
        public List<Group> groups { get; set; } 
    }
}

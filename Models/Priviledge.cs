namespace TokenApp.Models
{
    /// <summary>
    /// The Privieledge associated with any token
    /// </summary>
    public class Priviledge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> scope { get; set; }
        
    }
}

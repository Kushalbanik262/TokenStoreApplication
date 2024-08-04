namespace TokenApp.Models
{
    /// <summary>
    /// Token Which will be issued by some user to some audience
    /// </summary>
    public class Token
    {
        public int Id { get; set; }
        public String issued { get; set; }
        public string expired { get; set; }
        public List<string> audience { get; set; }
        public List<Priviledge> privileges { get; set; }
        public string type { get; set; }
        public string userName {  get; set; }

    }
}

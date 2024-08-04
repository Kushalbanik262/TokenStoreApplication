namespace TokenApp.Models
{
    /// <summary>
    /// Token Which will be issued by some user to some audience
    /// `Builder` Design pattern is used
    /// </summary>
    public class Token
    {
        private Token _buildToken;
        public string Id { get; set; }

        public string issuer { get; set; }
        public string issued { get; set; }
        public string expired { get; set; }
        public List<string> audience {  get; set; }
        public List<Priviledge> privileges { get; set; }
        public string type { get; set; }

        public Token() { 
            _buildToken = new Token();
            this.audience = new List<string>();
            this.privileges = new List<Priviledge>();
        }

        public Token addIssuer(string issuer)
        {
            _buildToken.issuer = issuer;
            return _buildToken;
        }

        public Token addId(string id)
        {
            _buildToken.Id = id;
            return _buildToken;
        }


        public Token addIssued(string issued)
        {
            _buildToken.issued = issued;
            return _buildToken;
        }

        public Token addExpired(string expired)
        {
            _buildToken.expired = expired;
            return _buildToken;
        }

        public Token addAudience(string audience)
        {
            _buildToken.audience.Add(audience);
            return _buildToken;
        }

        public Token addPrivilege(Priviledge priviledge)
        {
            _buildToken.privileges.Add(priviledge);
            return _buildToken;
        }

        public Token addType(string type)
        {
            _buildToken.type = type;
            return _buildToken;
        }

        public Token build() { return _buildToken; }

        
       

    }
}

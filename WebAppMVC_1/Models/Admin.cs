namespace WebApp_1.Models
{
    public class Admin
    {
        private string _id;
        private string _name;
        private string _email;
        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
    }
}

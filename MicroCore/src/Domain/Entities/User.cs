namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public User(string email,string name)
        {
            Id = Guid.NewGuid();
            Email = email;
            Name = name;
        }
        public void ChangeEmail(string newEmail)
        {
            if (string.IsNullOrWhiteSpace(newEmail))
            {
                throw new Exception("Correo inválido");
            }
            Email = newEmail;
        }
    }
}

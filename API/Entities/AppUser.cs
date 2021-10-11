namespace API.Entities 
// sve entiti klase odgovaraju tabelama u bazi
{
    public class AppUser
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
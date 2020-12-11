namespace Core.Entities
{
   public class Owner : EntiteyBase
    {
        public string FullName { get; set; }
        public string Profil { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }

    }
}

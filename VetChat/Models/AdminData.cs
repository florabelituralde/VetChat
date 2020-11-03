namespace VetChat.Data
{
    public partial class AdminData
    {
        public int AdminId { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }

        public virtual GroupData Group { get; set; }
        public virtual UserInformation User { get; set; }
    }
}
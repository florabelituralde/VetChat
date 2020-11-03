using System.Collections.Generic;

namespace VetChat.Data
{
    public partial class GroupData
    {
        public GroupData()
        {
            AdminData = new HashSet<AdminData>();
        }

        public int GroupId { get; set; }
        public int UserId { get; set; }
        public string GroupName { get; set; }
        public string GroupVisibility { get; set; }
        public int? MembersCount { get; set; }

        public virtual UserInformation User { get; set; }
        public virtual ICollection<AdminData> AdminData { get; set; }
    }
}
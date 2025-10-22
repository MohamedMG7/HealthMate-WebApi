using HealthMate.DAL.Enums;

namespace HealthMate.DAL.Data.Models
{
	public class Admin
	{
        public int Admin_Id { get; set; }

        //link with application user
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public DateOnly BirthDate { get; set; }
		public Gender Gender { get; set; }
        public bool IsDeleted { get; set; }
    }

}

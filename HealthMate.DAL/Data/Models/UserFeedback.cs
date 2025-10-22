using HealthMate.DAL.Enums;

namespace HealthMate.DAL.Data.Models
{
	public class UserFeedback
	{
        public int UserFeedback_Id { get; set; }
        
        // Link ApplicationUser 
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUser_Id { get; set; } // Required

        public string Feedback { get; set; }
        public FeedBack_Category FeedBackCategory { get; set; }
    }

    
}

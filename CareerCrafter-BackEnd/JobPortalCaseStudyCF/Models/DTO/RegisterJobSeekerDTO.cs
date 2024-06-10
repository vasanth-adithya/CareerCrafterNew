using System.ComponentModel.DataAnnotations;

namespace JobPortalCaseStudyCF.Models.DTO
{
    public class RegisterJobSeekerDTO
    {
        [Required]
        public string JobSeekerName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string ContactPhone { get; set; }
        
        public string? Address { get; set; }
        
        public string? Description { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        public string? Qualification { get; set; }
        
        public string? Specialization { get; set; }
        
        public string? Institute { get; set; }
        
        public int? Year { get; set; }
        
        public decimal? CGPA { get; set; }
        
        public string? CompanyName { get; set; }
        
        public string? Position { get; set; }
        
        public string? Responsibilities { get; set; }
        
        public DateTime? StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace ThinkSmartAPI.Models
{
    [Keyless]
    public class Students
    {
        public int StudentID { get; set; }
        public Guid StudentCode { get; set; }
        public string? StudentFirstName { get; set; }
        public string? StudentLastName { get; set; }
        public string? StudentExtension { get; set; }
        public DateTime StudentDateOfBirth { get; set; }
        public int? StudentAge { get; set; }
        public string? StudentGender { get; set; } // Consider using an enum for gender if you have predefined values
        public string? StudentAddress1 { get; set; }
        public string? StudentAddress2 { get; set; }
        public string? StudentAddress3 { get; set; }
        public string? StudentAddress4 { get; set; }
        public string? ZipCode { get; set; }
        public string? StudentGuardianName { get; set; }
        public string? StudentGuardianContact { get; set; }
        public string? StudentGuardianEmail { get; set; }
        public string? StudentEmergencyContactName { get; set; }
        public string? StudentEmergencyContactPhone { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string? Allergies { get; set; }
        public string? MedicalConditions { get; set; }
        public string? SpecialNeeds { get; set; }
        public string? Notes { get; set; }
        public string? Status { get; set; } // Consider using an enum if the status has a predefined set of values
    }
}

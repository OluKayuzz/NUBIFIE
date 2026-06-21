using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NUBIFIE_Web_Portal.Models
{
    public class MemberRegistration
    {
        [Key]
        public int ID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string RefID { get; set; }

        [Required]
        public DateTime RegDate { get; set; }

        public byte[] PictureImg { get; set; }
        
        [StringLength(50)]
        [Display(Name = "Nubifie Sector")]
        public string SectorId { get; set; }

        [Display(Name = "Title")]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Surname")]
        [StringLength(255)]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Other Names")]
        [StringLength(255)]
        public string Othername { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Gender")]
        [StringLength(50)]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Contact Phone number")]
        [StringLength(50)]
        public string ContactNumber { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Residential Address")]
        public string ResidentialAddress { get; set; }

        [Display(Name = "State of Residence")]
        [StringLength(50)]
        public string StateID { get; set; }

        [Display(Name = "LGA of Residence")]
        [StringLength(50)]
        public string LGAID { get; set; }

        [StringLength(50)]
        public string MMOId { get; set; } 

        [Display(Name = "Business Name")]
        public string BusinessName { get; set; } 

        [Display(Name = "Business Address")]
        public string BusinessAddress { get; set; } 

        [Display(Name = "State of Business")]
        [StringLength(50)]
        public string AdminOfficeStateID { get; set; } 

        [Display(Name = "LGA of Business")]
        [StringLength(50)]
        public string AdminOfficeLGAID { get; set; } 

        [Display(Name = "Number of Outlet")]
        public int NumberOfOutlets { get; set; } = 0;

        public string BusinessLocation { get; set; } = "";

        [Display(Name = "Terms and Agreement")]
        [Required]
        public bool Agreement { get; set; }

        [Display(Name = "UserID")]
        [StringLength(100)]
        public string UserID { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(100)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public bool Active { get; set; } = true;

        public int? EditCnt { get; set; } = 0;

        public DateTime DateLastEdit { get; set; }

        [Required]
        public bool Suspend { get; set; } = false;

        [Required]
        public bool Activated { get; set; } = false;

        // Constructor
        public MemberRegistration()
        {
            // Set the default image path
            string imagePath = "~/img/blank_Person2.png";

            // Convert the image to a byte array
            PictureImg = GetImageAsByteArray(imagePath);
        }

        private byte[] GetImageAsByteArray(string path)
        {
            // Resolve the path to the actual file location
            string resolvedPath = path.Replace("~", AppDomain.CurrentDomain.BaseDirectory);

            // Read the file and convert to byte array
            return File.Exists(resolvedPath) ? File.ReadAllBytes(resolvedPath) : null;
        }
    }
}

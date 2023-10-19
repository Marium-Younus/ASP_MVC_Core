using System.ComponentModel.DataAnnotations;

namespace WebApp_ModelValidation.Models
{
	public class User
	{
		public int User_Id { get; set; }

		[Required(ErrorMessage = "Please Enter Name ")]
        [StringLength(20, ErrorMessage = "Name length should be under the range to 3 to 20", MinimumLength = 3)]
        public string User_Name { get; set; }

		[Required(ErrorMessage = "Please Enter Email ")]
		[EmailAddress]
        public string User_Email { get; set; }

		[Required(ErrorMessage = "Please Enter Password ")]
		[RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage ="Please Enter Lower&Upper Case, Number,Symbols and Min. 8 Chars")]
		public string User_Password { get; set; }

		[Required(ErrorMessage = "Please Enter Confirm Password ")]
        [Compare("User_Password", ErrorMessage = "Both password must match")]
        public string User_CPassword { get; set; }
		
		[Required(ErrorMessage = "Please Enter Age ")]
        [Range(18, 100, ErrorMessage = "Below 18 and above 100 is not eligible for casting vote")]
        public int? User_Age { get; set; }

		[Required(ErrorMessage = "Please Enter Qualification ")]
		public string User_Qualification { get; set; }

		[Required(ErrorMessage = "Please Phone Number ")]
		[RegularExpression("^((\\+92)|(0092))-{0,1}\\d{3}-{0,1}\\d{7}$|^\\d{11}$|^\\d{4}-\\d{7}$",ErrorMessage ="Invalid Phone Number +92xxxxxxxxxx")]
        public string? User_Phone { get; set; }

		[Required(ErrorMessage = "Website URL is Must")]
		[Url(ErrorMessage ="Invalid URL")]
        public string? WebsiteURL { get; set; }
    }
}

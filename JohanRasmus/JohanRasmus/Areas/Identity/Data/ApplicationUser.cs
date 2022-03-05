using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace JohanRasmus.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
	[Required]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public Int32 ApplicationUserId { get; set; }

	[Required]
	[MaxLength(256)]
	[Display(Name = "First name")]
	[Column(TypeName = "VARCHAR")]
	public string FirstName { get; set; }

	[Required]
	[Display(Name = "Last name")]
	[MaxLength(256)]
	[Column(TypeName = "VARCHAR")]
	public string LastName { get; set; }

	[Display(Name = "Date of birth")]
	[DataType(DataType.Date)]
	public DateTime Birthdate { get; set; }
}
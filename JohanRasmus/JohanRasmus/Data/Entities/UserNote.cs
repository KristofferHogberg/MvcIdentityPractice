using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohanRasmus.Data.Entities
{
	public class UserNote
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public int IdentityId { get; set; }

		[MaxLength(160)]
		public string Note { get; set; }

		[DataType(DataType.Date)]
		public DateTime Created { get; set; } = DateTime.Now;
	}
}
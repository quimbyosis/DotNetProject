using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetLimber.Models
{
    public class Person
	{
		[Key]
		public string Email { get; set; }
		public string FirstName { get; set; }
			public string LastName { get; set; }
			public int ZipCode { get; set; }
	}
}

using Microsoft.AspNetCore.Identity;

namespace Restaurant_app.Models
{
	public class ApplicationUser : IdentityUser
	{
		public ICollection<Order>? Orders { get; set; }
	}
}

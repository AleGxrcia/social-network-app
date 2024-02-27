﻿using Microsoft.AspNetCore.Identity;

namespace SocialNetwork.Infrastructure.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ProfilePicture { get; set; }
        public bool? IsVerified { get; set; }

    }
}

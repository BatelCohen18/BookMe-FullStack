using System;
using System.Collections.Generic;

namespace App.DataAccess.Entities
{
    /// <summary>
    /// Represents a user within the system.
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the full name of the user.
        /// </summary>
        public string FullName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        public string UserName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        public string Email { get; set; } = null!;

        /// <summary>
        /// Gets or sets the password of the user.
        /// </summary>
        public string Password { get; set; } = null!;

        /// <summary>
        /// Navigation property for the orders associated with the user.
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}

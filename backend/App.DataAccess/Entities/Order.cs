using System;
using System.Collections.Generic;

namespace App.DataAccess.Entities
{
    /// <summary>
    /// Represents an order within the system.
    /// </summary>
    public partial class Order
    {
        /// <summary>
        /// Gets or sets the unique identifier for the order.
        /// </summary>
        public Guid OrderId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who placed the order.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the total amount for the order.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the payment status of the order.
        /// </summary>
        public bool PaymentStatus { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the order was placed.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Navigation property for the associated user.
        /// </summary>
        public virtual User User { get; set; } = null!;
    }
}

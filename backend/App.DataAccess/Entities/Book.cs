using System;
using System.Collections.Generic;

namespace App.DataAccess.Entities
{
    /// <summary>
    /// Represents a book entity with various attributes related to the book.
    /// </summary>
    public partial class Book
    {
        /// <summary>
        /// Gets or sets the unique identifier for the book.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the book.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the category of the book (e.g., Fiction, Non-Fiction).
        /// </summary>
        public string Category { get; set; } = null!;

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; } = null!;

        /// <summary>
        /// Gets or sets the year the book was published.
        /// </summary>
        public int PublishingYear { get; set; }

        /// <summary>
        /// Gets or sets the name of the publisher.
        /// </summary>
        public string Publishing { get; set; } = null!;

        /// <summary>
        /// Gets or sets the price of the book.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the title of the book. Note: This might be a typo and should be 'Title'.
        /// </summary>
        public string Titel { get; set; } = null!;

        /// <summary>
        /// Gets or sets the URL or path to the book's image. This property is optional.
        /// </summary>
        public string? Img { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the book available in stock.
        /// </summary>
        public int Qty { get; set; }
    }
}

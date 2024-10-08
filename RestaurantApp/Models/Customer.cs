﻿using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}

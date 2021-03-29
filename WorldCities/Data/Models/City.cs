﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCities.Data.Models
{
    [Table("Cities")]
    public class City
    {
        #region Constructor
        public City()
        {
        }
        #endregion
        #region Properties

        [Key]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Name_ASCII { get; set; }

        [Column(TypeName = "decimal(7,4)")]
        public decimal Lat { get; set; }
  
        [Column(TypeName = "decimal(7,4)")]
        public decimal Lon { get; set; }
        #endregion

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
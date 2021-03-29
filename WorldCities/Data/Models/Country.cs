﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCities.Data.Models
{
    [Table("Countries")]
    public class Country
    {
        #region Constructor
        public Country()
        {
        }
        #endregion
        #region Properties

        [Key]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ISO2 { get; set; }

        public string ISO3 { get; set; }

        public virtual List<City> Cities { get; set; }
        #endregion
    }
}
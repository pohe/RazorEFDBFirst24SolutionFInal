﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RazorEFDBFirst24Solution.Models;

[Table("Country")]
public partial class Country
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Code { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; }

    public double? PopulationNumber { get; set; }

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
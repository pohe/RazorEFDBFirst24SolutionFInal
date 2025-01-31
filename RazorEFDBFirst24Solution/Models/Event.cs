﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RazorEFDBFirst24Solution.Models;

[Table("Event")]
public partial class Event
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; }

    [Required]
    [StringLength(20)]
    [Unicode(false)]
    public string City { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CountryCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateTime { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("Events")]
    public virtual Country CountryCodeNavigation { get; set; }
}
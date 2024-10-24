using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ItemPortel.Models;

[Table("Item")]
public partial class Item
{
    [Key]
    public int ItemId { get; set; }

    public string ItemName { get; set; }

    public string ItemDescription { get; set; }
}

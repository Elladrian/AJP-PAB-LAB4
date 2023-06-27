using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Localization
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int KodyPocztoweId { get; set; }

    public virtual KodyPocztowe KodyPocztowe { get; set; } = null!;
}

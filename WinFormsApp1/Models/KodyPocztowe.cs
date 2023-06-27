using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class KodyPocztowe
{
    public int Id { get; set; }

    public string KodPocztowy { get; set; } = null!;

    public string Adres { get; set; } = null!;

    public string Miejscowosc { get; set; } = null!;

    public string Wojewodztwo { get; set; } = null!;

    public string Powiat { get; set; } = null!;

    public string Uwagi { get; set; } = null!;

    public virtual ICollection<Localization> Localizations { get; set; } = new List<Localization>();
}

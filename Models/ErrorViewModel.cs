namespace Kitaplık.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

public class Kitap
{
    public string KitapAdi { get; set; }
    public string YazarAdi { get; set; }
    public DateTime YayinlanmaTarihi { get; set; }
    public string Turu { get; set; }
    public int SayfaSayisi { get; set; }
    public decimal Fiyat { get; set; }
}


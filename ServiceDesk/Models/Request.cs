using System.Collections.Generic;

namespace ServiceDesk.Models;

public class Request
{
    public int Id { get; set; }
    public string ClientName { get; set; } = string.Empty;
    public string DeviceModel { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Status { get; set; } = "Принята";
    public List<string> History { get; set; } = new();
    public List<string> Parts { get; set; } = new();
}
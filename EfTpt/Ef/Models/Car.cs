using EfTpt.Ef.Types;

namespace EfTpt.Ef.Models;

public class Car : Transport
{
    public Speed Speed { get; set; }
}
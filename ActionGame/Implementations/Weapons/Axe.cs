using ActionGame.Abstractions.Weapons;

namespace ActionGame.Implementations.Weapons;

public class Axe : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("chopping with an axe");
    }
}

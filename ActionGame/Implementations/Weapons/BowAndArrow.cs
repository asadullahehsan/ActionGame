using ActionGame.Abstractions.Weapons;

namespace ActionGame.Implementations.Weapons;

public class BowAndArrow : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Shooting arrow");
    }
}

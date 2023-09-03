using ActionGame.Abstractions.Weapons;

namespace ActionGame.Implementations.Weapons;

public class Sword : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("swinging a sword");
    }
}

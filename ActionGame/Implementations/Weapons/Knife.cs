using ActionGame.Abstractions.Weapons;

namespace ActionGame.Implementations.Weapons;

public class Knife : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("cutting with a knife");
    }
}

using ActionGame.Abstractions.Characters;
using ActionGame.Implementations.Weapons;

namespace ActionGame.Implementations.Characters;

public class Knight : CharacterBase
{
    public Knight()
    {
        weapon = new Sword();
    }
    public override void Fight()
    {
        Console.WriteLine("Knight fight");
        weapon.UseWeapon();
    }
}

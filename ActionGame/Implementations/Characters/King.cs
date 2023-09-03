using ActionGame.Abstractions.Characters;
using ActionGame.Implementations.Weapons;

namespace ActionGame.Implementations.Characters;

public class King : CharacterBase
{
    public King()
    {
        weapon = new Axe();
    }

    public override void Fight()
    {
        Console.WriteLine($"king fight");
        weapon.UseWeapon();
    }
}

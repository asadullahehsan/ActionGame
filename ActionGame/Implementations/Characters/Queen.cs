using ActionGame.Abstractions.Characters;
using ActionGame.Implementations.Weapons;

namespace ActionGame.Implementations.Characters;

public class Queen : CharacterBase
{
    public Queen()
    {
        weapon = new BowAndArrow();
    }
    public override void Fight()
    {
        Console.WriteLine("Queen fight");
        weapon.UseWeapon();
    }
}

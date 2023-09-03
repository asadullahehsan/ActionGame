using ActionGame.Abstractions.Characters;
using ActionGame.Implementations.Weapons;

namespace ActionGame.Implementations.Characters;

public class Troll : CharacterBase
{
    public Troll()
    {
        weapon = new Knife();
    }
    public override void Fight()
    {
        Console.WriteLine("Troll fight");
        weapon.UseWeapon();
    }
}

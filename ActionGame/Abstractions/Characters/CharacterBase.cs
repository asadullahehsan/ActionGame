using ActionGame.Abstractions.Weapons;

namespace ActionGame.Abstractions.Characters;

public abstract class CharacterBase
{
    #region Variable Behavior
    protected IWeaponBehavior weapon;
    #endregion

    public void SetWeapon(IWeaponBehavior wp)
    {
        weapon = wp;
    }
    
    #region Constant Behavior
    public abstract void Fight();
    #endregion
}

namespace BTVNT5;

public class Player : Character
{
    public Weapon CurrentWeapon { get; private set; }

    public Player(int x, int y, Weapon weapon, int healthPoints)
        : base(x, y, weapon.Attack, weapon.RangeAttack, healthPoints)
    {
        CurrentWeapon = weapon;
    }
}
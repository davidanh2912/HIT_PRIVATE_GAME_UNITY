namespace BTVNT5;

public class Weapon
{
    public string Name { get; private set; }
    public int Attack { get; private set; }
    public int RangeAttack { get; private set; }

    public Weapon(string name, int attack, int range)
    {
        Name = name;
        Attack = attack;
        RangeAttack = range;
    }
}
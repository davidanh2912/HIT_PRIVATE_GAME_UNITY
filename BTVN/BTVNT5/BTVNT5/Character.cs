namespace BTVNT5;

public abstract class Character
{
    public int PosX { get; protected set; }
    public int PosY { get; protected set; }
    public int Damage { get; protected set; }
    public int RangeAttack { get; protected set; }
    public int HealthPoints { get; protected set; }

    public Character(int posX, int posY, int damage, int range, int heathPoints)
    {
        PosX = posX;
        PosY = posY;
        Damage = damage;
        RangeAttack = range;
        HealthPoints = heathPoints;
    }

    public void Move(int posX, int posY)
    {
        PosX = posX;
        PosY = posY;
    }

    public void Attack(Character target)
    {
        if (IsInRange(target))
        {
            target.HealthPoints -= Damage;
        }
    }

    public bool IsInRange(Character target)
    {
        int distance = Math.Abs(PosX - target.PosX) + Math.Abs(PosY - target.PosY);
        return distance <= RangeAttack;
    }
}
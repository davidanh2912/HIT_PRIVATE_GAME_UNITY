namespace BTVNT5;

public class Enemy : Character
{
    private static Random random = new Random();

    public Enemy(int posX, int posY, int damage, int range, int healthPoints) : base(posX, posY, damage, range, healthPoints)
    {
    }

    public void RandomMove(int gridWidth, int gridHeight)
    {
        int newX = PosX + random.Next(-1, 2);
        int newY = PosY + random.Next(-1, 2);
        PosX = Math.Clamp(newX, 0, gridWidth - 1);
        PosY = Math.Clamp(newY, 0, gridHeight - 1);
    }
    
    
}
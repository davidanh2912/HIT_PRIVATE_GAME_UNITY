namespace BTVNT5;

public class Tile
{
    public Character Occupant { get; set; }
    public int PosX { get; private set; }
    public int PosY { get; private set; }

    public Tile(int x, int y)
    {
        PosX = x;
        PosY = y;
        Occupant = null;
    }
    
    public bool IsOccupied()
    {
        return Occupant != null;
    }
}
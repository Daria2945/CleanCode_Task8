using System;

class Player
{
    private readonly Movement _movement;
    private Weapon _weapon;

    public string Name { get; private set; }

    public int Age { get; private set; }
}

public class Weapon
{
    public int Damage { get; private set; }

    public float Cooldown { get; private set; }

    public void Attack()
    {
        //attack
    }

    public bool IsReloading()
    {
        throw new NotImplementedException();
    }
}

public class Movement
{
    public float Speed { get; private set; }

    public float DirectionX { get; private set; }

    public float DirectionY { get; private set; }

    public void Move()
    {
        //Do move
    }
}
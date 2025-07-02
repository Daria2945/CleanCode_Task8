using System;

class Player
{
    private readonly Movement _movement;
    private readonly Stats _stats;

    private Weapon _weapon;

    public Player(Movement movement, Stats stats)
    {
        _movement = movement ?? throw new ArgumentNullException(nameof(movement));
        _stats = stats ?? throw new ArgumentNullException(nameof(stats));
    }

    public void SetWeapon(Weapon weapon)
    {
        _weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
    }
}

public class Stats
{
    public Stats(string name, int age)
    {
        if (age <= 0)
            throw new ArgumentOutOfRangeException(nameof(age));

        Name = name ?? throw new ArgumentNullException(nameof(name));
        Age = age;
    }

    public readonly string Name { get; private set; }

    public readonly int Age { get; private set; }
}

public class Weapon
{
    private readonly int _damage;
    private readonly float _cooldown;

    public Weapon(int damage, float cooldown)
    {
        if (damage <= 0)
            throw new ArgumentOutOfRangeException(nameof(damage));

        if (cooldown <= 0)
            throw new ArgumentOutOfRangeException(nameof(cooldown));

        _damage = damage;
        _cooldown = cooldown;
    }

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
    private readonly InputReder _inputReader;
    private readonly float _speed;

    public Movement(InputReder inputReader, float speed)
    {
        if (speed <= 0)
            throw new ArgumentOutOfRangeException(nameof(speed));

        _inputReader = inputReader ?? throw new ArgumentNullException(nameof(inputReader));
        _speed = speed;
    }

    public void Move()
    {
        //Do move
    }
}

public class InputReder
{
    public float DirectionX { get; private set; }

    public float DirectionY { get; private set; }
}
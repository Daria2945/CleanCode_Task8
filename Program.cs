using System;

class Player
{
    private readonly Movement _movement;
    private readonly Stats _stats;
    private readonly Weapon _weapon;

    public Player(Movement movement, Stats stats, Weapon weapon)
    {
        _movement = movement ?? throw new ArgumentNullException(nameof(movement));
        _stats = stats ?? throw new ArgumentNullException(nameof(stats));
        _weapon = weapon ?? throw new ArgumentNullException(nameof(_weapon));
    }

    public void Move() =>
        _movement.Move();

    public void Attack() =>
        _weapon.Attack();
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

    public string Name { get; private set; }

    public int Age { get; private set; }
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
        if (IsReloading())
            return;

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
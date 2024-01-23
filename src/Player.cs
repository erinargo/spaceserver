namespace Library

public class Player {
    public float Health { get; set; }
    public int Role { get; set; } // Roles will be enums, this is the old way of doing it don't fix what isn't broken <3 ily; Captain, Gunner, Engineer
    public int State { get; set; } // Walking, Running, Jumping, Falling

    public int id { get; set; }
} 
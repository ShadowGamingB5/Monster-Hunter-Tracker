namespace MonsterHunterTracker.Logic;

public class Monster
{
    public string Name { get; set; }

    public string Classification { get; set; }
    public List<Attributes> Weaknesses { get; set; }
    public List<Attributes> Strengths { get; set; }
    public int NumberHunted { get; set; }

    public List<Drops> Drops{ get; set; }
}

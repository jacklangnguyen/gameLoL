// Hệ thống khả năng của tướng

public class ChampionAbility {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Cooldown { get; set; }

    public ChampionAbility(string name, string description, int cooldown) {
        Name = name;
        Description = description;
        Cooldown = cooldown;
    }

    public void CastAbility() {
        // Thực hiện khả năng
        Console.WriteLine($"Đang thi triển khả năng: {Name}");
    }
}
// Lớp cơ sở cho các nhà vô địch

public class Champion {
    // Tốc độ di chuyển của nhà vô địch
    public float MovementSpeed { get; set; }

    // Danh sách các khả năng của nhà vô địch
    public List<Ability> Abilities { get; set; }

    // Phương thức khởi tạo
    public Champion(float movementSpeed) {
        MovementSpeed = movementSpeed;
        Abilities = new List<Ability>();
    }

    // Phương thức để thêm khả năng
    public void AddAbility(Ability ability) {
        Abilities.Add(ability);
    }
}

// Lớp mô tả một khả năng
public class Ability {
    public string Name { get; set; }
    public string Description { get; set; }

    public Ability(string name, string description) {
        Name = name;
        Description = description;
    }
}
// Hệ thống combat
// Tính toán sát thương trong combat

public class CombatSystem {

    public int CalculateDamage(int attack, int defense) {
        // Công thức tính sát thương
        int damage = attack - defense;
        return damage > 0 ? damage : 0;
    }

    public void ExecuteCombat(Player attacker, Player defender) {
        int damage = CalculateDamage(attacker.Attack, defender.Defense);
        defender.Health -= damage;
        // Thông báo sát thương
        Console.WriteLine(attacker.Name + " tấn công " + defender.Name + " gây ra " + damage + " sát thương!");
    }
}
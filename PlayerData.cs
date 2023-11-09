public class PlayerData {
    public int MaxHP;
    public int CurrentHP;
    public int Damage;
    public int Level;

    public PlayerData(int MaxHP) {
        this.MaxHP = MaxHP;
        this.CurrentHP = MaxHP;
    }

    public NewDamage(int level, int damage)
    {
        this.Level = level;
        this.Damage = damage;
    }
}
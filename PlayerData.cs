public class PlayerData
{
    public int MaxHP;
    public int CurrentHP;

    public PlayerData(int MaxHP)
    {
        this.MaxHP = MaxHP;
        this.CurrentHP = MaxHP;
    }

    public void DamagePlayer(int damage) 
    {
    CurrentHP -= damage;
    if (CurrentHP < 0) 
    {
        CurrentHP = 0;
    }
}
}
public class PlayerData{
    public int MaxHP;
    public int CurrentHP;

    public PlayerData(int MaxHP){
        this.MaxHP = MaxHP;
        this.CurrentHP = MaxHP;
    }
    private void RecibirDaņo(int damage)
    {
        CurrentHP -= damage;
    }
}
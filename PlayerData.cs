public class PlayerData{
    public int MaxHP;
    public int CurrentHP;

    public PlayerData(int MaxHP){
        this.MaxHP = MaxHP;
        this.CurrentHP = MaxHP;
    }
    private void RecibirDa�o(int damage)
    {
        CurrentHP -= damage;
    }
}
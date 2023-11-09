public class PlayerData{
    public int MaxHP;
    public int CurrentHP;

    public PlayerData(int MaxHP){
        this.MaxHP = MaxHP;
        this.CurrentHP = MaxHP;
    }

    PlayerData NewPlayerData = new PlayerData();

    void DamagePlayer(int currentHp)
    {
        currentHp = NewPlayerData.CurrentHP - 10;
    }
}
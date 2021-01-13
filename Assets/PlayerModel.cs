using UnityEngine;

public class PlayerModel
{
    string name;
    int hp;
    int at;

    //生成されたときに呼び出される
    public PlayerModel()
    {
        name = "atsu";
    }

    public PlayerModel(string name)
    {
        this.name = name;
    }

    public void SayName()
    {
        Debug.Log(name);
    }
}


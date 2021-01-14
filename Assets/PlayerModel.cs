using UnityEngine;

public class PlayerModel
{
    string name;
    int hp;
    int at;

    //プロパティ
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    //生成されたときに呼び出される
    public PlayerModel()
    {
        name = "atsu";
    }

    public PlayerModel(string name)
    {
        this.name = name;
        hp = 100;
        at = 10;
    }

    public void SayName()
    {
        Debug.Log(name);
    }
}


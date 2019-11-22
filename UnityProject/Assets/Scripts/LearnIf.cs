
using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public int combo;
    private void Start()
    {
        if (combo >= 50 && combo<100)
        {
        print("dmgx2");
        }
        else if(combo >= 100 && combo <150)
        {
        print("dmgx5")
        }
        else if(combo >=150 && combo < 200)
        {
        print("dmgx10")
        }
    }
}

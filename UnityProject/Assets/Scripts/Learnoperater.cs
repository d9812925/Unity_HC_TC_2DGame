
using UnityEngine;

public class Learnoperater : MonoBehaviour
{


    public int a = 10, b = 3;
    public int c = 25, d = 15;
    public bool boolA = true, boolB = false;
    public int Hp = 100, item = 10;

    private void Start()
    {
        #region
        print(a + b); 
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);
        #endregion

        #region
        print(c<d);
        print(c>d);
        print(c<=d);
        print(c<=d);
        print(c==d);
        print(c!=d);
        #endregion

        #region
        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);

        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);

        print(!true);
        print(!false);

        print(Hp > 50 && item > 7);
        #endregion
    }


}

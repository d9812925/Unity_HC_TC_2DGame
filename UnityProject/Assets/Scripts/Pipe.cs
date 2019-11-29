// : 繼承 類別，可以享有繼承類別的成員
public class Pipe : Ground
{
    private void OnBecameInvisible()
    {
        // 刪除(此遊戲物件，延遲 2.5 秒);
        Destroy(gameObject, 5f);
    }
    private void OnBecameVisible()
    {
        
    }
}

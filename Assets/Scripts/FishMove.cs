using Unity.VisualScripting;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    public float speed = 2f;
    public float lifetime = 7f; // Ömrü, yani ne kadar süre sonra objenin yok olacaðýný belirten deðiþken

    private int movementDirection = 1;

    private void Start()
    {
        // Invoke fonksiyonu ile belirlenen süre sonra Destroy fonksiyonunu çaðýrarak objeyi yok ediyoruz
        Invoke("DestroyFish", lifetime);
    }

    private void Update()
    {
        MoveFish();
    }

    private void MoveFish()
    {
        // Hareket yönetimi
        transform.Translate(new Vector2(5 * movementDirection, 0) * speed * Time.deltaTime);
    }

    private void DestroyFish()
    {
        if (gameObject.IsDestroyed() == false)
        {
            Destroy(gameObject);
        }
       
    }

    // Yeni fonksiyon
    public void SetMovementDirection(SpawnManager.SpawnSide spawnSide)
    {
        // Eðer spawn sol taraftan ise, hareket yönünü negatif yap
        if (spawnSide == SpawnManager.SpawnSide.Left)
        {
            movementDirection = -1;
        }
        else
        {
            movementDirection = -1;
        }
    }
}


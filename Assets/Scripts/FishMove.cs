using Unity.VisualScripting;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    public float speed = 2f;
    public float lifetime = 7f; // �mr�, yani ne kadar s�re sonra objenin yok olaca��n� belirten de�i�ken

    private int movementDirection = 1;

    private void Start()
    {
        // Invoke fonksiyonu ile belirlenen s�re sonra Destroy fonksiyonunu �a��rarak objeyi yok ediyoruz
        Invoke("DestroyFish", lifetime);
    }

    private void Update()
    {
        MoveFish();
    }

    private void MoveFish()
    {
        // Hareket y�netimi
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
        // E�er spawn sol taraftan ise, hareket y�n�n� negatif yap
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


using UnityEngine;
using UnityEngine.UIElements;

public class lineRendererCode : MonoBehaviour
{
    public Transform nesne1; // �lk nesne
    public Transform nesne2; // �kinci nesne
    public LineRenderer lineRenderer; // LineRenderer bile�eni
    float genislik = 0.1f;
    Color renk = Color.gray;

    void Start()
    {
        lineRenderer.startWidth = genislik;
        lineRenderer.endWidth = genislik;
        lineRenderer.startColor = renk;
        lineRenderer.endColor = renk;
        lineRenderer.SetPosition(0, nesne1.position);
        lineRenderer.SetPosition(1, nesne2.position);
    }

    void Update()
    {
        // �ki nesne aras�ndaki mesafeye ba�l� olarak �izginin uzunlu�unu g�ncelle
        float uzaklik = Vector2.Distance(nesne1.position, nesne2.position);
        lineRenderer.SetPosition(0, nesne1.position);
        lineRenderer.SetPosition(1, nesne2.position);

    }
}

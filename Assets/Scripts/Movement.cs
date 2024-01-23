using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    OxygenCode oxygenCode;
    float sayac = 0;
    float moves = 25;
    [SerializeField] float XSpeed = 2f;
    [SerializeField] float YSpeed = 2f;
    [SerializeField] float xRange = 17f;
    [SerializeField] float yRange = 52.5f;
    [SerializeField] float yrange =5f;
    bool ziplamaIzni = true;
    private Rigidbody rb;
    private void Awake()
    {
        Time.timeScale = 0;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        oxygenCode = GetComponent<OxygenCode>();
    }

    private void Update()
    {
        LeftOrRight();
        Debug.Log(ziplamaIzni);
        float x = transform.localPosition.x;
        float y = transform.localPosition.y;
        float clampXPos = Mathf.Clamp(x, -xRange, xRange);
        float clampYPos = Mathf.Clamp(y, -yRange, yrange);
        transform.localPosition = new Vector3(clampXPos, clampYPos, transform.localPosition.z);
    }

    public void LeftOrRight()
    {
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
        {
            transform.Translate(Time.deltaTime * XSpeed, 0, 0);
            transform.rotation = Quaternion.Euler(0, 180, 0); // Rotate to the left
        }
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
        {
            transform.Translate(Time.deltaTime * XSpeed, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0); // Rotate to the right
        }
    }
}
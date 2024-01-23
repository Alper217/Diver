using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenCode : MonoBehaviour
{
    [SerializeField] Image Load;
    public Image OxygenBar;
    public float Oxygen, MaxOxygen;
    public float oxyCost;
    public float ChargeRate;
    private Coroutine Recharge;


    private void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.tag == "Below")
        {
            // Below b�lgesindeyken oksijeni azalt
            Debug.Log("Cost");
            Oxygen -= oxyCost * Time.deltaTime;
            if (Oxygen <= 0)
            {
                Load.gameObject.SetActive(true);
                Oxygen = 0;
                Time.timeScale = 0;
            }
            OxygenBar.fillAmount = Oxygen / MaxOxygen;

            // Surface b�lgesine girdi�inizde, Recharge coroutine'ini durdur
            if (Recharge != null)
            {
                StopCoroutine(Recharge);
                Recharge = null;
            }
        }
        else if (other.gameObject.tag == "Surface")
        {
            // Surface b�lgesine girdi�inizde oksijeni art�r
            if (Recharge == null) // E�er Recharge coroutine �al��m�yorsa ba�lat
            {
                Debug.Log("A");
                Recharge = StartCoroutine(RechargeOxygen());
            }
        }
    }

    private IEnumerator RechargeOxygen()
    {
        while (Oxygen < MaxOxygen)
        {
            Oxygen += ChargeRate * Time.deltaTime;
            if (Oxygen > MaxOxygen) Oxygen = MaxOxygen;
            OxygenBar.fillAmount = Oxygen / MaxOxygen;
            yield return null; // Coroutine'i her frame'de �al��t�r
        }

        // Recharge tamamland���nda coroutine'i s�f�rla
        Recharge = null;
    }
}




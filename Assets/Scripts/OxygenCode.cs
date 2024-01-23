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
            // Below bölgesindeyken oksijeni azalt
            Debug.Log("Cost");
            Oxygen -= oxyCost * Time.deltaTime;
            if (Oxygen <= 0)
            {
                Load.gameObject.SetActive(true);
                Oxygen = 0;
                Time.timeScale = 0;
            }
            OxygenBar.fillAmount = Oxygen / MaxOxygen;

            // Surface bölgesine girdiðinizde, Recharge coroutine'ini durdur
            if (Recharge != null)
            {
                StopCoroutine(Recharge);
                Recharge = null;
            }
        }
        else if (other.gameObject.tag == "Surface")
        {
            // Surface bölgesine girdiðinizde oksijeni artýr
            if (Recharge == null) // Eðer Recharge coroutine çalýþmýyorsa baþlat
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
            yield return null; // Coroutine'i her frame'de çalýþtýr
        }

        // Recharge tamamlandýðýnda coroutine'i sýfýrla
        Recharge = null;
    }
}




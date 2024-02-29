using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HapticExit : MonoBehaviour
{
    public ScenesInformation scenesInformation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Exit"))
        {
            Debug.Log("Colisionó con exit");
            ScenesInformation.instancia.esferaTransitions.SetActive(true);
            StartCoroutine(waitingForExit());
            Debug.Log("Colisionó con exit");

        }

    }
    IEnumerator waitingForExit()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}

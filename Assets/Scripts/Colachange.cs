using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colachange : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<Colachange>();
        foreach (Colachange button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(100, 100, 100, 100);
        }

        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<CoreSpawnerCac1>().SetSelectedDefender(defenderPrefab);
    }

}

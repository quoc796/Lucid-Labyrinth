using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterLucidityModifier : MonoBehaviour
{
    public LucidityBar lucidity;
    public float modifier = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lucidity.monsterModifier += modifier;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lucidity.monsterModifier -= modifier;
        }
    }
}

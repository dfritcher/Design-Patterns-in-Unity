using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("GrowPowerUp"))
        {
            _transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);            
        }
        else if (other.CompareTag("ShrinkPowerUp"))
        {
            _transform.localScale = new Vector3(.5f, .5f, .5f);
        }
        other.GetComponent<IPowerUp>()?.Pickup();
        StartCoroutine(ReturnToNomralSize());
    }


    private IEnumerator ReturnToNomralSize()
    {
        yield return new WaitForSecondsRealtime(3);

        _transform.localScale = Vector3.one;
    }
}

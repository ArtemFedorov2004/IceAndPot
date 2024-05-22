using System.Collections;
using UnityEngine;

public class DestroyIceCube : MonoBehaviour
{
    private GameObject _key;
    private void Awake()
    {
        _key = GameObject.Find("key");
    }
    private void OnTriggerEnter(Collider other)
    {        
        GameObject triggeredObject = other.gameObject;
        if (triggeredObject.CompareTag("IceCube"))
        {
            _key.transform.parent = null;
            StartCoroutine(DestroyCoroutine(triggeredObject));
        }        
    }
    private IEnumerator DestroyCoroutine(GameObject objectToDestroy)
    {
        yield return new WaitForSeconds(1);

        Destroy(objectToDestroy);
    }
}

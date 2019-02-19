using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
   public Healthbar bar;

    public void OnCollisionEnter(Collision other)
    {
        
        if (other == null)
        {
            throw new System.ArgumentNullException(nameof(other));
        }
        
        if (other.gameObject.tag.Equals("sphere"))
        {
            Debug.Log("hit");
            Destroy(other.gameObject);
            bar.TakeDamage(10f);
        }
    }
}
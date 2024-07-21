using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour {

 [SerializeField]
 GameObject objectToDestroy1, objectToDestroy2;

 public void DestroyGameObject()
 {
  Destroy (objectToDestroy1);
  Destroy (objectToDestroy2);
 }
}

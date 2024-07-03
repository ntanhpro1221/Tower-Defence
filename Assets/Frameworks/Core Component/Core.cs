using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour {
    public T GetCoreComponent<T>() where T : CoreComponent =>
        GetComponentInChildren<T>();
}
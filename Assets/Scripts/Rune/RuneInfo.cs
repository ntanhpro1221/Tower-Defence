using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class RuneInfo {
    [field: SerializeField]
    public string Name { get; set; }
    [field: SerializeField]
    public string Id { get; set; }
    [field: SerializeField]
    [field: TextArea(1, 4)]
    public string Description { get; set; }
    [field: SerializeField]
    public List<Vector3> StatsTrans { get; set; }
}



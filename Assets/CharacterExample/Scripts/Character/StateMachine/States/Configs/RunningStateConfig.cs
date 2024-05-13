using System;
using UnityEngine;

[Serializable]
public class RunningStateConfig
{
    [field: SerializeField, Range(1, 5)] public float SlowRunSpeed { get; private set; }
    [field: SerializeField, Range(7, 12)] public float AverageRunSpeed { get; private set; }
    [field: SerializeField, Range(14, 19)] public float FastRunSpeed { get; private set; }

}

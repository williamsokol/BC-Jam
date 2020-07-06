using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMusic", menuName = "Song")]
public class MusicTrack : ScriptableObject
{
    public AudioClip[] chords;
    public float[] times;

    public AudioClip song;
}

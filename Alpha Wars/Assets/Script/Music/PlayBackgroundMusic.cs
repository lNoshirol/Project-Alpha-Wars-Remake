using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBackgroundMusic : MonoBehaviour
{
    [SerializeField] private List<AudioClip> BGMusicList;
    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        if (_audioSource != null && BGMusicList.Count == 0)
            return; 

        _audioSource.clip = BGMusicList[Random.Range(0, BGMusicList.Count)];
        _audioSource.Play();
    }
}
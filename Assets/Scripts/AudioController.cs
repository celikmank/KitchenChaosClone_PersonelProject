using System;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioClip[] Songs;
    [SerializeField] private AudioSource audioSource; 
    private int currentSongIndex = 0;
    
        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
            if (Songs.Length>0)
            {
             audioSource.clip = Songs[0];   
            }
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayNextSong();
            }
        }

        void PlayNextSong()
        {
            // Eğer şarkılar varsa
            if (Songs.Length > 0)
            {
                // Şarkıyı değiştir
                audioSource.clip = Songs[currentSongIndex];
                audioSource.Play();

                // Bir sonraki şarkıya geç
                currentSongIndex = (currentSongIndex + 1) % Songs.Length;
            }
        }
}

using NAudio.Wave;
using System;

namespace Reflex_Master
{
    public static class AudioHelper
    {
        private static IWavePlayer musicPlayer;
        private static AudioFileReader musicFile;
        private static IWavePlayer soundPlayer;
        private static AudioFileReader soundFile;
        private static float musicVolume = 1.0f;
        private static float soundVolume = 1.0f;

        public static void InitializeMusic(string musicFilePath)
        {
            musicPlayer = new WaveOutEvent();
            musicFile = new AudioFileReader(musicFilePath);
            musicFile.Volume = musicVolume;
            musicPlayer.Init(musicFile);
        }

        public static void PlayMusic()
        {
            musicPlayer.Play();
        }

        public static void SetMusicVolume(float volume)
        {
            if (volume >= 0.0f && volume <= 1.0f)
            {
                musicVolume = volume;
                if (musicFile != null)
                {
                    musicFile.Volume = volume;
                }
            }
        }

        public static void InitializeClickSound(string clickSoundFilePath)
        {
            soundPlayer = new WaveOutEvent();
            soundFile = new AudioFileReader(clickSoundFilePath);
            soundFile.Volume = soundVolume;
            soundPlayer.Init(soundFile);
        }

        public static void PlayClickSound()
        {
            if (soundPlayer != null)
            {
                InitializeClickSound("click.wav");
            }

            if (soundPlayer != null) soundPlayer.Play();
        }

        public static void SetClickSoundVolume(float volume)
        {
            if (volume >= 0.0f && volume <= 1.0f)
            {
                soundVolume = volume;
                if (soundFile != null)
                {
                    soundFile.Volume = volume;
                }
            }
        }
    }
}


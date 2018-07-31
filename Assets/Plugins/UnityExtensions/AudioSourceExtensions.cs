using System;
using UnityEngine;
#if EXTENSIONS_UNIRX
using UniRx;
#endif
#if EXTENSIONS_DOTWEEN
using DG.Tweening;
#endif

namespace UnityExtensions
{
    public static class AudioSourceExtensions
    {
        public static bool Play(this AudioSource self, AudioClip clip, float volume)
        {
            if (clip == null || volume <= 0.0f)
                return false;

            self.clip = clip;
            self.volume = volume;
            self.Play();
            return true;
        }

#if EXTENSIONS_DOTWEEN
        public static void FadeIn(this AudioSource self, float volume, float duration)
        {
            self.DOFade(volume, duration);
        }

        public static void FadeOut(this AudioSource self, float duration)
        {
            self.DOFade(0.0f, duration);
        }

        public static bool PlayWithFadeIn(this AudioSource self, AudioClip clip, float volume, float duration)
        {
            if (clip == null || volume <= 0.0f)
                return false;

            self.clip = clip;
            self.volume = 0.0f;
            self.Play();
            self.FadeIn(volume, duration);
            return true;
        }
#endif

#if EXTENSIONS_UNIRX
        public static IObservable<Unit> PlayAsObservable(this AudioSource self, AudioClip clip, float volume)
        {
            if (self.Play(clip, volume))
                return Observable.Timer(TimeSpan.FromSeconds(clip.length)).AsUnitObservable();
            else
                return Observable.Throw<Unit>(new ArgumentException());
        }
#endif

#if EXTENSIONS_DOTWEEN && EXTENSIONS_UNIRX
        public static IObservable<Unit> PlayWithFadeInAsObservable(this AudioSource self, AudioClip clip, float volume, float duration)
        {
            if (self.PlayWithFadeIn(clip, volume, duration))
                return Observable.Timer(TimeSpan.FromSeconds(clip.length)).AsUnitObservable();
            else
                return Observable.Throw<Unit>(new ArgumentException());
        }
#endif
    }
}

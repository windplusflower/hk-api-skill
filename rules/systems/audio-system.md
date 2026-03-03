---
title: Audio System Management
impact: MEDIUM
impactDescription: Proper audio handling improves mod quality
tags: hk-api, audio, sound-effects, audio-clip
---

## Audio System

### Global Audio Manager Pattern

```csharp
public static class AudioManager
{
    private static Dictionary<string, AudioClip> _cache = new();
    private const float GLOBAL_VOLUME = 0.45f;
    
    // Initialize from embedded resources
    public static void Init(Dictionary<string, string> resourceMap)
    {
        Assembly asm = Assembly.GetExecutingAssembly();
        foreach (var item in resourceMap)
        {
            string path = $"{asm.GetName().Name}.assets.{item.Value}";
            using (Stream s = asm.GetManifestResourceStream(path))
            {
                if (s == null) continue;
                byte[] buffer = new byte[s.Length];
                s.Read(buffer, 0, buffer.Length);
                AudioClip clip = WavUtility.ToAudioClip(buffer, item.Value);
                _cache[item.Key] = clip;
            }
        }
    }
    
    // Play one-shot with 3D positioning
    public static void Play(string key, float volume = 1.0f)
    {
        if (_cache.TryGetValue(key, out AudioClip clip))
        {
            GameObject audioObj = new GameObject($"Audio_{key}");
            AudioSource source = audioObj.AddComponent<AudioSource>();
            source.clip = clip;
            source.volume = volume * GLOBAL_VOLUME;
            source.spatialBlend = 0.3f;
            source.minDistance = 2f;
            source.maxDistance = 15f;
            source.rolloffMode = AudioRolloffMode.Linear;
            source.Play();
            UnityEngine.Object.Destroy(audioObj, clip.length + 0.1f);
        }
    }
}
```

---

### AudioEvent Structure

```csharp
public struct AudioEvent
{
    public float PitchMin;    // Default: 0.75
    public float PitchMax;    // Default: 1.25
    public float Volume;      // Default: 1.0
}
```

Used in `InfectedEnemyEffects` for hit sounds.

---

### Looping Audio Pattern

```csharp
public class LoopingAudio
{
    private AudioSource _source;
    private bool _isStopped = false;
    
    public bool IsPlaying => !_isStopped && _source != null && _source.isPlaying;
    
    public void Start(AudioClip clip, float volume = 1.0f)
    {
        _isStopped = false;
        _source = new GameObject("LoopingAudio").AddComponent<AudioSource>();
        _source.clip = clip;
        _source.volume = volume;
        _source.loop = true;
        _source.Play();
    }
    
    public void Stop()
    {
        _isStopped = true;
        if (_source != null)
        {
            _source.Stop();
            UnityEngine.Object.Destroy(_source.gameObject);
        }
    }
}
```

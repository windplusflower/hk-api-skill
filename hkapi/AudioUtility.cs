using UnityEngine;

/// <summary>
/// 全局音效工具类 - 用于播放空洞骑士中的各种音效
/// </summary>
public static class AudioUtility
{
    /// <summary>
    /// 播放受击音效（最简版本）
    /// </summary>
    /// <param name="clip">音频片段</param>
    /// <param name="position">播放位置</param>
    /// <param name="volume">音量 (0-1)</param>
    public static void PlayHitSound(AudioClip clip, Vector3 position, float volume = 1f)
    {
        if (clip == null) return;
        
        GameObject audioObj = new GameObject("HitSound");
        audioObj.transform.position = position;
        AudioSource audioSource = audioObj.AddComponent<AudioSource>();
        audioSource.volume = volume;
        audioSource.PlayOneShot(clip);
        Object.Destroy(audioObj, clip.length + 0.1f);
    }

    /// <summary>
    /// 播放受击音效（带随机音高）
    /// </summary>
    /// <param name="clip">音频片段</param>
    /// <param name="position">播放位置</param>
    /// <param name="pitchMin">最小音高</param>
    /// <param name="pitchMax">最大音高</param>
    /// <param name="volume">音量 (0-1)</param>
    public static void PlayHitSoundWithPitch(AudioClip clip, Vector3 position, float pitchMin = 0.75f, float pitchMax = 1.25f, float volume = 1f)
    {
        if (clip == null) return;
        
        float pitch = Random.Range(pitchMin, pitchMax);
        GameObject audioObj = new GameObject("HitSound");
        audioObj.transform.position = position;
        AudioSource audioSource = audioObj.AddComponent<AudioSource>();
        audioSource.pitch = pitch;
        audioSource.volume = volume;
        audioSource.PlayOneShot(clip);
        Object.Destroy(audioObj, clip.length / pitch + 0.1f);
    }
}

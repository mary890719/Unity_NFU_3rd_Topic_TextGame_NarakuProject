using UnityEngine;
using UnityEngine.Audio;        // �ޥ� ���� API

public class AudioController : MonoBehaviour
{
    [Header("�V����")]
    public AudioMixer mixer;

    // �Ʊ� slider �� On Value Changed �ƥ�G�ư��ܧ�ƭȮɮɰ���@��
    // (Single) ���� float

    /// <summary>
    /// �]�w BGM ���q
    /// </summary>
    /// <param name="volume">�n�]�w�����q��</param>
    public void SetVolumeBGM(float volume)
    {
        mixer.SetFloat("VolumeBGM", volume);
    }

    /// <summary>
    /// �]�w SFX ���q
    /// </summary>
    /// <param name="volume">�n�]�w�����q��</param>
    public void SetVolumeSFX(float volume)
    {
        mixer.SetFloat("VolumeSFX", volume);
    }
}

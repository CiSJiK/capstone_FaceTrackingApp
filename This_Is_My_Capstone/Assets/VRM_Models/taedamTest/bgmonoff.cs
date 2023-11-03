using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmonoff : MonoBehaviour
{
    public AudioSource audioSource; // Audio Source ������Ʈ�� �ν����Ϳ��� ������ �� �ֵ��� public ������ ����ϴ�.
    public float volume = 1.0f; // ������ ���� ���� �ν����Ϳ��� ������ �� �ֵ��� public ������ ����ϴ�.

    // ��ũ��Ʈ�� Ȱ��ȭ�� �� ����˴ϴ�.
    private void Start()
    {
        // Audio Source�� �������� ���� ���, ���� GameObject���� Audio Source ������Ʈ�� ã���ϴ�.
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        // �ʱ� ���� ����
        audioSource.volume = volume;
    }

    // ������ �����ϴ� �޼���
    public void SetVolumeOff(float newVolume)
    {
        if (audioSource != null)
        {
            volume = 0.0f;
            audioSource.volume = volume;
        }
    }
     public void SetVolumeOn(float newVolume)
    {
        if (audioSource != null)
        {
            volume = 1.0f;
            audioSource.volume = volume;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonPress : MonoBehaviour
{
    // Start is called before the first frame update
    public Text displayText1; // �ؽ�Ʈ�� ǥ���� UI Text ������Ʈ�� ������ ����
    public Text displayText2; // �ؽ�Ʈ�� ǥ���� UI Text ������Ʈ�� ������ ����
    public Text displayText3; // �ؽ�Ʈ�� ǥ���� UI Text ������Ʈ�� ������ ����
    public Text displayText4; // �ؽ�Ʈ�� ǥ���� UI Text ������Ʈ�� ������ ����
    public Text displayText5; // �ؽ�Ʈ�� ǥ���� UI Text ������Ʈ�� ������ ����
    public Text displayText6; // �ؽ�Ʈ�� ǥ���� UI Text ������Ʈ�� ������ ����
    private bool isButtonPressed = false;


    private void Update()
    {
        if (isButtonPressed)
        {
            // ��ư�� ���� ���� ������ ������ �̰��� �߰��մϴ�.
            Debug.Log("��ư�� ���Ƚ��ϴ�.");
            displayText1.gameObject.SetActive(true);
            displayText2.gameObject.SetActive(true);
            displayText3.gameObject.SetActive(true);
            displayText4.gameObject.SetActive(true);
            displayText5.gameObject.SetActive(true);
            displayText6.gameObject.SetActive(true);
           
        }
        else{
            displayText1.gameObject.SetActive(false);
            displayText2.gameObject.SetActive(false);
            displayText3.gameObject.SetActive(false);
            displayText4.gameObject.SetActive(false);
            displayText5.gameObject.SetActive(false);
            displayText6.gameObject.SetActive(false);
           
        }
    }

    public void OnButtonPressed()
    {
        isButtonPressed = true;
    }

    public void OnButtonReleased()
    {
        isButtonPressed = false;
    }

}

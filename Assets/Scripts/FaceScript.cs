using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceScript : MonoBehaviour
{
    //普通の顔は１０
    int Emotion = 10;
    Image Uwamabuta;
    Image Sitamabuta;
    Image Eyeball;
    Image Namida;
    // Start is called before the first frame update
    void UwamabutaMinus()
    {
        if (Emotion < 20 && Emotion > 0)
        {
            Transform umTransform = Uwamabuta.transform;
            //位置
            Vector3 pos = umTransform.position;
            pos.y += 1f;
            umTransform.position = pos;
            //しなり
            //角度
            Vector3 localAngle = umTransform.localEulerAngles;
            localAngle.z += 10f;
            umTransform.localEulerAngles = localAngle;
        }
        else
        {
            return;
        }

    }
    void UwamabutaPlus()
    {
        if (Emotion < 20 && Emotion > 0)
        {
            //位置
            Transform umTransform = Uwamabuta.transform;
            Vector3 pos = umTransform.position;
            pos.y -= 1f;
            umTransform.position = pos;
            //しなり
            //角度
            Vector3 localAngle = umTransform.localEulerAngles;
            localAngle.z -= 10f;
            umTransform.localEulerAngles = localAngle;
        }
        else
        {
            return;
        }
    }
    void SitamabutaMinus()
    {
        if (Emotion < 20 && Emotion > 0)
        {
            //位置
            Transform smTransform = Sitamabuta.transform;
            Vector3 pos = smTransform.position;
            pos.y += 1f;
            smTransform.position = pos;
            //しなり
            //角度
            Vector3 localAngle = smTransform.localEulerAngles;
            localAngle.z += 10f;
            smTransform.localEulerAngles = localAngle;
        }
        else
        {
            return;
        }
    }
    void SitamabutaPlus()
    {
        if (Emotion < 20 && Emotion > 0)
        {
            //位置
            Transform smTransform = Sitamabuta.transform;
            Vector3 pos = smTransform.position;
            pos.y -= 1f;
            smTransform.position = pos;
            //しなり
            //角度
            Vector3 localAngle = smTransform.localEulerAngles;
            localAngle.z -= 10f;
            smTransform.localEulerAngles = localAngle;
        }
        else
        {
            return;
        }
    }
    void EyeBallPlus()
    {
        if (Emotion < 20 && Emotion > 0)
        {
            Transform ebTransform = Eyeball.transform;
            //大きさ
            ebTransform.localScale = new Vector3(
                ebTransform.localScale.x * 1.1f,
                ebTransform.localScale.y * 1.1f,
                ebTransform.localScale.z
            );
            //振動
        }
        else
        {
            return;
        }
    }
    void EyeBallMinus()
    {
        if (Emotion < 20 && Emotion > 0)
        {
            Transform ebTransform = Eyeball.transform;
            //大きさ
            ebTransform.localScale = new Vector3(
                ebTransform.localScale.x / 1.1f,
                ebTransform.localScale.y / 1.1f,
                ebTransform.localScale.z
            );
            //振動
        }
        else
        {
            return;
        }
    }
    void NamidaPlus()
    {
        if (Emotion < 20 && Emotion > 0)
        {
            Transform nTransform = Namida.transform;
            //大きさ
            nTransform.localScale = new Vector3(
                nTransform.localScale.x / 1.1f,
                nTransform.localScale.y / 1.1f,
                nTransform.localScale.z
           );
        }
        else
        {
            return;
        }
    }
    void NamidaMinus()
    {
        if (Emotion < 20 && Emotion > 0)
        {
            Transform nTransform = Namida.transform;
            //大きさ
            nTransform.localScale = new Vector3(
                nTransform.localScale.x * 1.1f,
                nTransform.localScale.y * 1.1f,
                nTransform.localScale.z
           );
        }
        else
        {
            return;
        }
    }
}

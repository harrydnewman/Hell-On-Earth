using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PongScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    public void OnCollisionEnter2D(Collision2D collision)
    {

        PongBall ball = collision.gameObject.GetComponent<PongBall>();

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }

}

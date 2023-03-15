using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float currentTime = 0;
	public float timeSpeed = 0.5f;
	
	public bool nextTurn = false;
	
	 [SerializeField] private Bar _timeBar;
	 
	 void Update()
	 {
		 currentTime += timeSpeed * Time.deltaTime;
		 
		 if(currentTime >= 1)
		 {
			 nextTurn = true;
			 currentTime = 0;
		 }
		 _timeBar.SetBar(currentTime,1);
	 }
}

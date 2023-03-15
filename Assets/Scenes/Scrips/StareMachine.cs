using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StareMachine : MonoBehaviour
{
    public enum State
	{
		Normal,
		LowHp,
		Sleep
	}
	
	[SerializeField] private State _state;
	[SerializeField] private Enemy _enemy;
	
// Start
// ------>	Nextstate();
// ------> PatrolState()
// ---------> CombatState()
// ---------> SleepState() 

	private void Start()
	{
		NextState();
	}
	
	private void NextState()
	{
		switch(_state)
		
	
		{
			case State.Normal:
				StartCoroutine(NormalState());
				break;
			case State.LowHp:
				StartCoroutine(LowHpState());
				break;
			case State.Sleep:
				StartCoroutine(SleepState());
				break;
			
		}
	}
	
	private IEnumerator NormalState()
	{
		Debug.Log("Entering Normal State");
		while(_state == State.Normal)
		{
			if(_enemy.CurrentHleath() < 30)
			{
				_state = State.LowHp;
			}
			// do code here
			yield return null; // continue1 fram later
		}
		Debug.Log("Exiting Normal State");
		NextState();
	}
	
	private IEnumerator LowHpState()
	{
		Debug.Log("Entering LowHp State");
		while(_state == State.LowHp)
		{
			// do code here
			_enemy.Heal();
			if(_enemy.CurrentHleath() > 80)
			{
				_state = State.Normal;
			}
			yield return null; // continue1 fram later
		}
		Debug.Log("Exiting LowHp State");
		NextState();
	}
	
	private IEnumerator SleepState()
	{
		Debug.Log("Entering Sleep State");
		while(_state == State.Sleep)
		{
			// do code here
			yield return null; // continue1 fram later
		}
		Debug.Log("Exiting Sleep State");
		NextState();
	}
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD39 {
	public class CanAct : MonoBehaviour {

		void Awake() {
			InputManager.OnAction += Action;
		}

		void OnDestroy() {
			InputManager.OnAction -= Action;
		}

		void Action(InputAction action) {

		}
	}
}

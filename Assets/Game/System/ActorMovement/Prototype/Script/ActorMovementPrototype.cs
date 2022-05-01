#region

using AutoBot.Utilities.Extensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#endregion

namespace ActorMovement.Prototype.Script
{
    public class ActorMovementPrototype : MonoBehaviour
    {
    #region Private Variables

        [SerializeField]
        private TMP_Text textState;

        [SerializeField]
        private Button buttonMove;

    #endregion

    #region Unity events

        private void Start()
        {
            textState.text = "Idle";
            buttonMove.BindClick(MoveToward);
        }

    #endregion

    #region Private Methods

        private void MoveToward()
        {
            transform.position += transform.right;
            textState.text     =  "Move";
        }

    #endregion
    }
}
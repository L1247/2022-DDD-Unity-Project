#region

using UnityEngine;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Application.Components
{
    public class ActorComponent : MonoBehaviour
    {
    #region Private Variables

        private Transform trans;

        [SerializeField]
        private SpriteRenderer mainSpriteRenderer;

    #endregion

    #region Unity events

        private void Awake()
        {
            trans = transform;
        }

    #endregion

    #region Public Methods

        public void SetPosition(Vector3 position)
        {
            trans.position = position;
        }

        public void SetSprite(Sprite sprite)
        {
            mainSpriteRenderer.sprite = sprite;
        }

    #endregion

    #region Nested Types

        public class Pool : MonoMemoryPool<ActorComponent>
        {
        #region Protected Methods

            protected override void Reinitialize(ActorComponent component) { }

        #endregion
        }

    #endregion
    }
}
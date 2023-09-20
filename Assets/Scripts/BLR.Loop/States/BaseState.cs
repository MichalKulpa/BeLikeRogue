using UnityEngine;

namespace BLR.Loop
{
    public abstract class BaseState 

    {
        protected GameController gameController;

        public virtual void BeforeInitialize(GameController gameController) //Awake
        {
            this.gameController = gameController;
        }
        public virtual void Initialize() //Start
        {

        }
        public virtual void Tick() //Update
        {

        }
        public virtual void LateTick() //LateUpdate
        {

        }
        public virtual void FixedTick() //FixedUpdate
        {

        }
        public virtual void Dispose() //OnDestroy
        {

        }
           
    }
}

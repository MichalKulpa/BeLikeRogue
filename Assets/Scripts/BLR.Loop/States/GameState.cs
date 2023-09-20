namespace BLR.Loop
{
    public class GameState : BaseState
    {
        public override void Initialize()
        {
           
        }
        public override void Tick()
        {
            gameController.InputManager.TickInput();
        }
        public override void LateTick()
        {
            gameController.InputManager.LateTickInput();
        }
        public override void FixedTick()
        {
            gameController.InputManager.FixedTickInput();
        }
        public override void Dispose()
        {
            
        }
        public void LoseGame()
        {

        }
    }
}
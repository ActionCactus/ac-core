using System;

namespace ActionCactus.Controllers
{
    abstract public class Controller
    {
        protected bool isNetworkedController = false;

        public Controller useNetwork(bool isNetworkedController)
        {
            this.isNetworkedController = isNetworkedController;

            return this;
        }

        abstract public lookVertical(float rotation);

        abstract public lookHorizontal(float rotation);

        abstract public zoom(float zoomIntensity);
    }
}
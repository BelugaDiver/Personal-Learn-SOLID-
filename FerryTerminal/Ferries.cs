namespace FerryTerminal
{
    enum FerryType 
    {
        SmallFerry,
        LargeFerry
    };
    interface IFerry
    {
        public static int spaceAvailable;
        public static int TryPush(IVehicle vehicle);
    }

    public class SmallFerry : IFerry
    {
        private int currentSpace;
        private const int maxSpace = 8; 

        public SmallFerry()
        {
            currentSpace = this.maxSpace;
        }
        public static int spaceAvailable
        {
            get {
                return this.currentSpace;
            }

            set {
                this.currentSpace = value;
            }
        }

        public static TryPush(IVehicle vehicle)
        {
            
        }
    }

    public class LargeFerry : IFerry
    {
        private int currentSpace;
        private const int maxSpace = 6; 

        public LargeFerry()
        {
            currentSpace = this.maxSpace;
        }
        public static int spaceAvailable
        {
            get {
                return this.currentSpace;
            }

            set {
                this.currentSpace = value;
            }
        }
    }
}
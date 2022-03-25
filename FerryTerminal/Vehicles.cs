namespace FerryTerminal
{
    interface IVehicle
    {
        public FerryType ferryType;
        public IFerryTicket ferryTicket;
        public string location;
        public int GetGasLevelRatio();
    }

    interface ILargeFerryVehicle : IVehicle
    {
        public bool isCargoDoorOpen;
    }

    class Car : IVehicle
    {
        public string location {get;set;}
        public IFerryTicket ferryTicket = new CarTicket();
        public FerryType ferryType 
        {
            get { return FerryType.SmallFerry; }
        }

        public int GetGasLevelRatio()
        {
            return 10;
        }
    }

    class Van : IVehicle
    {
        public string location {get;set;}
        public IFerryTicket ferryTicket = new VanTicket();
        public FerryType ferryType 
        {
            get { return FerryType.SmallFerry; }
        }

        public int GetGasLevelRatio()
        {
            return 10;
        }
    }

    class Bus : ILargeFerryVehicle
    {
        public string location {get;set;}
        public IFerryTicket ferryTicket = new BusTicket();
        public bool isCargoDoorOpen { get; set; }
        public FerryType ferryType 
        {
            get { return FerryType.LargeFerry; }
        }

        public int GetGasLevelRatio()
        {
            return 20;
        }
    }

    class Truck : ILargeFerryVehicle
    {
        public string location {get;set;}
        public IFerryTicket ferryTicket = new TruckTicket();
        public bool isCargoDoorOpen { get; set; }
        public FerryType ferryType 
        {
            get { return FerryType.LargeFerry; }
        }

        public int GetGasLevelRatio()
        {
            return 40;
        }
    }
}
namespace FerryTerminal
{
    interface IFerryTicket
    {
        public static int cost;
    }

    class CarTicket : IFerryTicket
    {
        public static int cost {
            get {
                return 3;
            }
        }
    }

    class VanTicket : IFerryTicket
    {
        public static int cost {
            get {
                return 4;
            }
        }
    }

    class BusTicket : IFerryTicket
    {
        public static int cost {
            get {
                return 5;
            }
        }
    }

    class TruckTicket : IFerryTicket
    {
        public static int cost {
            get {
                return 6;
            }
        }
    }
}
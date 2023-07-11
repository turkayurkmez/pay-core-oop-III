namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Bir request üzerinde sırasıyla:
             * 1. Authanticate
             * 2. Authorization
             * 3. Routing
             * 4. Logging
             */
            ReservationClient reservationClient = new ReservationClient();
            reservationClient.HandleReservation("Roma");
        }
    }
}
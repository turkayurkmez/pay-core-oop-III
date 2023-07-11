namespace ChainOfResponsibility
{
    /*
     * Senaryo: 
     *    Avrupa'da salon kiralama hizmeti veren bir uygulamanın rezervasyon sistemi
     *    Gelen rezervasyon hangi halkanın sorumluluğunda ise o işlemi tamamlayacak.
     */

    public class ReservationClient
    {
        public void HandleReservation(string city)
        {
            IstanbulMeeting istanbulMeeting = new IstanbulMeeting();
            LondonMeeting londonMeeting = new LondonMeeting();
            ParisMeeting parisMeeting = new ParisMeeting();
            RomaMeeting romaMeeting = new RomaMeeting();

            istanbulMeeting.Next = londonMeeting;
            londonMeeting.Next = parisMeeting;
            parisMeeting.Next = romaMeeting;

            Reservation reservation = new Reservation() { City = city };
            istanbulMeeting.Confirm(reservation);


        }
    }

    public class Reservation
    {
        public string City { get; set; }
        public int Capacity { get; set; }
    }

    public class ReservationEventArgs
    {
        public Reservation Reservation { get; set; }
    }
    public abstract class Responsible
    {
        public Responsible()
        {
            ReservationConfirmed += ReservationConfirmedHandler;
        }
        public Responsible Next { get; set; }
        public abstract void ReservationConfirmedHandler(object sender, ReservationEventArgs e);
        public EventHandler<ReservationEventArgs> ReservationConfirmed;
        public void Confirm(Reservation reservation)
        {
            ReservationEventArgs reservationEventArgs = new ReservationEventArgs { Reservation = reservation };
            if (ReservationConfirmed != null)
            {

                ReservationConfirmed(this, reservationEventArgs);
            }
        }



    }

    public class IstanbulMeeting : Responsible
    {

        public override void ReservationConfirmedHandler(object sender, ReservationEventArgs e)
        {
            if (e.Reservation.City == "İstanbul")
            {
                Console.WriteLine("İstanbul'da rezervasyon işlemi tamamlandı...");
            }
            else
            {
                Next.ReservationConfirmedHandler(this, e);
            }
        }
    }

    public class LondonMeeting : Responsible
    {
        public override void ReservationConfirmedHandler(object sender, ReservationEventArgs e)
        {
            if (e.Reservation.City == "London")
            {
                Console.WriteLine("Londra'da rezervasyon işlemi tamamlandı...");
            }
            else
            {
                Next.ReservationConfirmedHandler(this, e);
            }
        }
    }

    public class ParisMeeting : Responsible
    {
        public override void ReservationConfirmedHandler(object sender, ReservationEventArgs e)
        {
            if (e.Reservation.City == "Paris")
            {
                Console.WriteLine("Paris'de rezervasyon işlemi tamamlandı...");
            }
            else
            {
                Next.ReservationConfirmedHandler(this, e);
            }
        }
    }

    public class RomaMeeting : Responsible
    {
        public override void ReservationConfirmedHandler(object sender, ReservationEventArgs e)
        {
            if (e.Reservation.City == "Roma")
            {
                Console.WriteLine("Roma'da rezervasyon işlemi tamamlandı...");
            }
        }
    }

}

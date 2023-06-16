namespace LiskovSubstution
{
    public interface IValidateReservation
    {
        bool IsValid();
    }
    public class ReservationSystem
    {


        public static IValidateReservation GetReservation(DateOnly checkIn, DateOnly? checkOut = null)
        {
            //bir biçimde geriye simple factory olarak Araç kiralama döndürüyorsunuz.
            if (checkOut.HasValue)
            {
                return new Reservation { CheckIn = checkIn, CheckOut = checkOut.Value };
            }
            else
            {
                return new DailyRentACarReservation { CheckIn = checkIn };
            }

            //return new RentACarReservation();

        }

    }




    public class Reservation : IValidateReservation
    {
        //ilk düşünceniz otel üzerine
        public decimal Deposit { get; set; }
        public virtual DateOnly CheckIn { get; set; }
        public virtual DateOnly CheckOut { get; set; }

        public bool IsValid()
        {
            return isDepositValid() && dateIsValid();
        }


        bool isDepositValid() => Deposit > 0;
        bool dateIsValid() => CheckIn < CheckOut;
    }

    public class DailyRentACarReservation : IValidateReservation //: Reservation
    {
        //public override DateOnly CheckOut { get => base.CheckOut; set => throw new ArgumentException("Check in tarihi ile aynı olmalıdır"); }

        public DateOnly CheckIn { get; set; }

        public bool IsValid()
        {
            return CheckIn.Month == DateTime.Now.Month;
        }
    }


}

// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");

/*
 *  Bir sınıf (derived), bir başkasını (base) inherit alıyorsa; derived sınıf, base'in davranışını DEĞİŞTİREMEZ!
 *  Bir base class ile derived class birbirlerinin yerine kullanılabiliyor olmalı.
 *  
 *  
 */
var reserv = ReservationSystem.GetReservation(new DateOnly(2023, 6, 23));
//reserv.CheckOut = new DateOnly(2023, 8, 1);
Console.WriteLine(reserv.IsValid() ? "Uygun" : "Uygun değil");
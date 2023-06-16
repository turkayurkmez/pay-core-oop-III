// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *     Bir oda tasarım uygulaması geliştiriyorsunuz:
 *     -- Salon
 *        1. Klasik Fabrika
 *             Sehpa,
 *             Koltuk,
 *             Kanepe
 *        2. Modern Fabrika
 *             Sehpa,
 *             Koltuk,
 *             Kanepe
 *        3. Ahşap Fabrika
 *             Sehpa,
 *             Koltuk,
 *             Kanepe
 * 
 * 
 * Salon s = new KlasikSalon
 * 
 * 
 */
SalonOlusturucu<KlasikSalonFactory> salonOlusturucu = new SalonOlusturucu<KlasikSalonFactory>();
salonOlusturucu.SalonuOlustur();

SalonOlusturucu<ModernSalonFactory> modern = new SalonOlusturucu<ModernSalonFactory>();
modern.SalonuOlustur();
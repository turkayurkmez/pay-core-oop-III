// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");
/*
 * Problem: 
 *    Bir nesne, bellekte oluştuğu anda o nesneye bağlı başka kompleks nesne(ler) de oluşmak zorunda ise 
 *    bu ilişkisel birlikteliği nasıl sağlarsınız?
 *    
 *  Senaryo: 
 *    Bir lojistik uygulaması geliştiriyorsunuz ve sadece kamyonlar ile çalışmaktasınız.
 */

/*
 * EglenceHaritasi harita = new EglenceHaritasi();
 * harita.ZiyaretNoktalariniGoster();
 * 
 * KulturHaritasi kHarita 
 * 
 * MssqlHelper  sql = new MssqlHelper();
 * sql.Execute();
 * 
 * OracleHelper helper = new OracleHelper();
 * oracle.Execute();
 * 
 * 
 */

OracleHelper oracleHelper = new OracleHelper();
oracleHelper.ExecuteCommand();

SqlHelper sqlHelper = new SqlHelper();
sqlHelper.ExecuteCommand();

PostgreHelper postgreHelper = new PostgreHelper();
postgreHelper.ExecuteCommand();
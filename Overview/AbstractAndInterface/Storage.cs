namespace AbstractAndInterface
{
    public abstract class Storage
    {
        public int MaxCapacity { get; set; }
        public string Tag { get; set; }

        public void Backup()
        {
            Console.WriteLine("Yedeği oluşturuldu");
        }

        public abstract void RecordData();
        public abstract void ReadData();


    }

    public class ExcelStorage : Storage
    {
        public override void ReadData()
        {
            Console.WriteLine("Excel'den okunuyor");
        }

        public override void RecordData()
        {
            throw new NotImplementedException();
        }
    }

    public class DBStorage : Storage
    {
        public override void ReadData()
        {
            Console.WriteLine("DB'den okunuyor");

        }

        public override void RecordData()
        {
            throw new NotImplementedException();
        }
    }

    public class XMLStorage : Storage
    {
        public override void ReadData()
        {
            Console.WriteLine("XML'den okunuyor");

        }

        public override void RecordData()
        {
            throw new NotImplementedException();
        }
    }



}

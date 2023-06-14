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


        public abstract void ReadData();


    }

    public interface IRecordable
    {
        void RecordData();
    }

    public class ExcelStorage : Storage, IRecordable
    {
        public override void ReadData()
        {
            Console.WriteLine("Excel'den okunuyor");
        }

        public void RecordData()
        {
            Console.WriteLine("Excel'e yazılıyor");
        }
    }

    public class DBStorage : Storage, IRecordable
    {
        public override void ReadData()
        {
            Console.WriteLine("DB'den okunuyor");

        }

        public void RecordData()
        {
            Console.WriteLine("DB'e yazılıyor");

        }
    }

    public class XMLStorage : Storage
    {
        public override void ReadData()
        {
            Console.WriteLine("XML'den okunuyor");

        }


    }

    public class DataRecorder
    {
        public void Record(IRecordable storage)
        {
            storage.RecordData();
        }
    }



}

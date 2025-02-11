namespace OOP_DOGA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tantargy tantargy = new Tantargy("matek", 5);
            Diak diak = new Diak("Nem", "11.D", 1);
            Diak diak2 = new Diak("Nem", "11.D", 2);
            Diak diak3 = new Diak("Nem", "11.D", 3);
            Diak diak4 = new Diak("Nem", "11.D", 4);
            Diak diak5 = new Diak("Nem", "11.D", 5);
            Diak diak6 = new Diak("Nem", "11.D", 6);
            Diak diak7 = new Diak("Nem", "11.D", 7);
            Diak diak8 = new Diak("Nem", "11.D", 8);
            Diak diak9 = new Diak("Nem", "11.D", 9);
            Diak diak10 = new Diak("Nem", "11.D", 10);
            Diak diak11 = new Diak("Nem", "11.D", 11);
            Ertekeles ertekeles = new Ertekeles(diak, tantargy, 5);
            Tanar tanar = new Tanar("Hitler", 1);
            Osztaly osztaly = new Osztaly("11.D", diak3, tanar);
            Console.WriteLine(tantargy.TantargyAdatok());
            Console.WriteLine(diak.TeljesNevKiirasa());
            Console.WriteLine(ertekeles.JegyKiirasa());
            tanar.HozzaadTantargy(tantargy);
            Console.WriteLine(tanar.OktatottTantargyak());
            osztaly.HozzaadDiak(diak4);
            osztaly.OsszesDiakListazasa();
            Console.WriteLine(osztaly.OsztalyfonokKiirasa());

        }
    }
}

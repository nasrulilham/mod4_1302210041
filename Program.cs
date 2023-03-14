// See https://aka.ms/new-console-template for more information
using static kodebuah;

public class mian
{
    enum state { tengkurap, jongkok, berdiri, terbang };
    static void Main(string[] args)
    {
        kodebuah k = new kodebuah();
        kodebuah.buah Buah;
        Console.WriteLine("buah" + buah.Apel + kodebuah.getKodebuah(kodebuah.buah.Apel));

    }

}
public class kodebuah
{
    public enum buah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka };
    public static String getKodebuah(buah BUAH)
    {
        String[] kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        return kodebuah[(int)BUAH];
    }
}



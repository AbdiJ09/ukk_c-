Console.Write("Nama : ");
string nama  = Console.ReadLine();
Console.Write("Nilai Harian : ");
int nilHarian = Convert.ToInt32(Console.ReadLine());
Console.Write("Nilai UTS : ");
int nilUts = Convert.ToInt32(Console.ReadLine());
Console.Write("Nilai UAS : ");
int nilUas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("=====================");
int rata = (nilHarian + nilUts + nilUas) / 3;
Console.WriteLine("Nama : " + nama);
Console.WriteLine("Nilai Harian : " + nilHarian);
Console.WriteLine("Nilai UTS : " + nilUts);
Console.WriteLine("Nilai UAS : " + nilUas);
Console.WriteLine("Rata-rata :" + rata.ToString());

if(rata >= 80)
{
    Console.WriteLine("Predikat : A");
}else if(rata >= 70)
{
    Console.WriteLine("Predikat : B");
}else if(rata >= 60)
{
    Console.WriteLine("Predikat : C");
}else if(rata >= 50)
{

    Console.WriteLine("Predikat : D");
}
else
{

    Console.WriteLine("Predikat : E");
}
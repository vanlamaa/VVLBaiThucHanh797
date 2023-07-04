internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap vao du lieu: ");
        string str = Console.ReadLine();
        Console.WriteLine("du lieu vua nhap vao la:" + str);
        string hoTen = "Vu Van Lam";
        int tuoi = 22;
        Console.WriteLine("sinh viên:{0} - {1}tuổi", hoTen,tuoi);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap vao du lieu: ");
        string str = Console.ReadLine();
        Console.WriteLine("du lieu vua nhap vao la:" + str);
        Console.Write("Nhap vao ten sinh viên: ");
        string ten = Console.ReadLine();
        Console.Write("Nhap vao tuoi sinh vien: ");
        string tuoi2 = Console.ReadLine();
        Console.WriteLine("du lieu vua nhap vao la:{0}- ten sinh vien: {1}- {2}tuoi",str,ten,tuoi2.ToString());
    }
}
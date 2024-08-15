using System.Text;

namespace _13_2
{
    class SinhVien
    {
        public string TenSV { get; set; }
        public int TuoiSV { get; set; }
        public double DiemSV { get; set; }

        public SinhVien(string ten, int tuoi, double diem)
        {
            TenSV = ten;
            TuoiSV = tuoi;
            DiemSV = diem;
        }

        public override string ToString()
        {
            return $"{TenSV}\t{TuoiSV}\t{DiemSV}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string filePath = "D:\\Training_D2\\Chuong13\\Chuong13\\13_2\\sv.txt";
            int choice;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("--------------------------");
                Console.WriteLine("11. Save to File");
                Console.WriteLine("12. Read File");
                Console.WriteLine("13. Exit");
                Console.Write("Your choice: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 11:
                            SaveToFile(filePath);
                            break;
                        case 12:
                            ReadFile(filePath);
                            break;
                        case 13:
                            Console.WriteLine("Exiting program...");
                            break;
                        default:
                            Console.WriteLine("Nhập sai, Hãy nhập lại");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Nhập sai, Hãy nhập lại");
                }

            } while (choice != 13);
        }

        static void SaveToFile(string filePath)
        {
            Console.Write("Nhập tên sinh viên: ");
            string ten = Console.ReadLine();

            Console.Write("Nhập tuổi sinh viên: ");
            int tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhập điểm sinh viên: ");
            double diem = double.Parse(Console.ReadLine());

            SinhVien sv = new SinhVien(ten, tuoi, diem);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(sv.ToString());
            }

            Console.WriteLine("Thông tin sinh viên đã được ghi vào file sv.txt.");
        }

        static void ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("File sv.txt không tồn tại.");
            }
        }
   
    }
}

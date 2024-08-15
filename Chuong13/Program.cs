using System.Text;

namespace Chuong13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập đường dẫn tệp nguồn: ");
            string sourceFilePath = Console.ReadLine();

            Console.Write("Nhập đường dẫn tệp đích: ");
            string destinationFilePath = Console.ReadLine();

            try
            {
                // Sao chép tệp tin từ nguồn sang đích
                File.Copy(sourceFilePath, destinationFilePath, true);

                Console.WriteLine($"Tệp đã được sao chép thành công từ {sourceFilePath} đến {destinationFilePath}");
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}

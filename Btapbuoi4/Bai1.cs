using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Btapbuoi4
{
    internal class Bai1
    {
        static void Main1()
        {
            // Đọc hàng 1 và tách thành mảng
            string[] line1 = Console.ReadLine().Split(' ');
            if (line1.Length < 2) return;
            // Đọc số lượng n và khóa key 
            long n = long.Parse(line1[0]);
            long key = long.Parse(line1[1]);
            string[] line2 = Console.ReadLine().Split(' ');
            long result = -1;
            // Khởi tạo mảng a và đưa dữ liệu vào
            long[] a = new long[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = long.Parse(line2[i]);
                if (a[i] == key)
                {
                    result = i; // Lưu lại chỉ số đầu tiên tìm thấy
                    break;      // Thoát vòng lặp ngay
                }
            }
            // In ra kết quả cuối cùng 
            Console.WriteLine(result);
        }
    }
}

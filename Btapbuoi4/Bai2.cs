using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Btapbuoi4
{
    internal class Bai2
    {
        static void Main2()
        {
            // Đọc hàng 1 và tách thành mảng
            string[] line1 = Console.ReadLine().Split(' ');
            if (line1.Length < 2) return;
            // Đọc số lượng n và khóa key 
            long n = long.Parse(line1[0]);
            long key = long.Parse(line1[1]);
            string[] line2 = Console.ReadLine().Split(' ');
            // Khởi tạo mảng a và đưa dữ liệu vào
            long[] a = new long[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = long.Parse(line2[i]);
            }
            // Khởi tạo các biến theo đúng thuật toán tìm kiếm nhị phân
            int left = 0;
            int right = (int)(n - 1);
            int iterations = 0; // Biến đếm số lần lặp
            int result = -1;    // Vị trí tìm thấy (mặc định -1 nếu không có)
                                // Vòng lặp while 
            while (left <= right)
            {
                iterations++;
                int mid = left + (right - left) / 2;
                if (a[mid] == key)
                {
                    result = mid; // Tìm thấy thì lưu vị trí
                    break;        // Thoát vòng lặp
                }
                else if (a[mid] < key)
                {
                    // Khoá lớn hơn phần tử giữa, tìm nửa bên phải
                    left = mid + 1;
                }
                else
                {
                    // Khoá nhỏ hơn phần tử giữa, tìm nửa bên trái
                    right = mid - 1;
                }
            }
            // In ra kết quả với định dạng "vị_trí số_lần_lặp" cách nhau bởi dấu cách
            Console.WriteLine(result + " " + iterations);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Btapbuoi4
{
    internal class Bai3
    {
        static void Main3()
        {
            // Đọc chuỗi và tách thành mảng tokens
            // Đọc hàng 1 và tách thành mảng
            string[] line1 = Console.ReadLine().Split(' ');
            if (line1.Length < 2) return;
            // Đọc số lượng n và khóa key 
            long n = long.Parse(line1[0]);
            long q = long.Parse(line1[1]);
            string[] line2 = Console.ReadLine().Split(' ');
            // Khởi tạo mảng a và đưa dữ liệu vào
            long[] a = new long[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = long.Parse(line2[i]);
            }
            // Khởi tạo StringBuilder để chứa toàn bộ kết quả, in ra 1 lần 
            StringBuilder output = new StringBuilder();
            // Xử lý q truy vấn
            string[] line3 = Console.ReadLine().Split(' ');
            long[] b = new long[q];
            for (int i = 0; i < q; i++)
            {
                b[i] = long.Parse(line3[i]);
            }
            for (int i = 0; i < q; i++)
            {
                // THUẬT TOÁN TÌM KIẾM NHỊ PHÂN
                int left = 0;
                int right = (int)(n - 1);
                int result = -1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (a[mid] == b[i])
                    {
                        result = mid;
                        break;
                    }
                    else if (a[mid] < b[i])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                // Ghi kết quả tìm được vào bộ đệm (kèm lệnh xuống dòng)
                output.AppendLine(result.ToString());
            }
            // 4. In toàn bộ q dòng kết quả ra màn hình cùng một lúc
            Console.Write(output.ToString());
        }
    }
}

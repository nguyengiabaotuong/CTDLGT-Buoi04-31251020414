using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Btapbuoi4
{
    internal class Bai4
    {
        static void Main()
        {
            // Đọc dòng 1: Lấy n và q, kèm bộ lọc khoảng trắng
            string[] line1 = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (line1.Length < 2) return;
            long n = long.Parse(line1[0]);
            long q = long.Parse(line1[1]);
            // Khởi tạo 2 mảng song song để lưu khóa và dữ liệu
            long[] keys = new long[n];
            long[] data = new long[n];
            // Đọc n dòng tiếp theo: Mỗi dòng chứa 1 cặp (khóa, dữ_liệu)
            for (int i = 0; i < n; i++)
            {
                string[] line2 = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                keys[i] = long.Parse(line2[0]);
                data[i] = long.Parse(line2[1]);
            }
            // Đọc dòng cuối cùng chứa q khóa cần tra cứu
            string[] queryline = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            long[] queries = new long[q];
            for (int i = 0; i < q; i++)
            {
                queries[i] = long.Parse(queryline[i]);
            }
            // Dùng StringBuilder để gom kết quả in ra một lần
            StringBuilder output = new StringBuilder();
            // Xử lý q truy vấn
            for (int i = 0; i < q; i++)
            {
                long queryKey = queries[i];
                // THUẬT TOÁN TÌM KIẾM NHỊ PHÂN
                int left = 0;
                int right = (int)(n - 1);
                bool found = false;
                long foundData = 0;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (keys[mid] == queryKey)
                    {
                        found = true;
                        foundData = data[mid]; 
                        break;
                    }
                    else if (keys[mid] < queryKey)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                // Ghi kết quả vào 
                if (found)
                {
                    output.AppendLine(foundData.ToString());
                }
                else
                {
                    output.AppendLine("NOT FOUND");
                }
            }
            // In toàn bộ kết quả ra màn hình
            Console.Write(output.ToString());
        }
    }
}

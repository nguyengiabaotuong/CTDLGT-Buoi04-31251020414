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
            // Đọc dữ liệu:
            string[] tokens = Console.In.ReadToEnd().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length < 2) return;
            int n = int.Parse(tokens[0]);
            int q = int.Parse(tokens[1]);
            long[] keys = new long[n];
            long[] data = new long[n];
            int ptr = 2; // Con trỏ chạy dọc theo mảng tokens để bốc dữ liệu
            // Nạp dữ liệu:
            for (int i = 0; i < n; i++)
            {
                keys[i] = long.Parse(tokens[ptr++]);
                data[i] = long.Parse(tokens[ptr++]);
            }
            StringBuilder output = new StringBuilder();
            // Xử lý truy vấn
            for (int i = 0; i < q; i++)
            {
                long query = long.Parse(tokens[ptr++]);
                // Dùng thuật toán BinarySearch 
                // Hàm này trả về chỉ số (>= 0) nếu tìm thấy, và số âm nếu không tìm thấy
                int index = Array.BinarySearch(keys, query);
                if (index >= 0)
                {
                    output.AppendLine(data[index].ToString());
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

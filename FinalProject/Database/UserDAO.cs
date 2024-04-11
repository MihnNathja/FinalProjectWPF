using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
    public class UserDAO
    {
        DBConnections db = new DBConnections();
        public UserDAO() { }
        public string GetID()
        {
            // chỗ này sau khi có database của user sẽ tiến hành lấy thông tin từ bảng rồi tạo một id mới
            return (Int32.Parse(Utility.GenerateGetID("user")) + 1).ToString();
        }
    }
}

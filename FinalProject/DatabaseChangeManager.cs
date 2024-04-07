using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class DatabaseChangeManager
    {
        // Định nghĩa sự kiện để thông báo sự thay đổi
        public event EventHandler DatabaseChanged;

        // Phương thức này được gọi khi có sự thay đổi trong cơ sở dữ liệu
        public void NotifyDatabaseChanged()
        {
            
            DatabaseChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

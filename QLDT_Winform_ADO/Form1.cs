using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLDT_Winform_ADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.;Database=QUANLYDIENTHOAI_DTT;Integrated Security=true");
        SqlDataAdapter adap;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        // hàm xuất thông tin cột được nhấn vào
        private string[] currentRow(string cmd)
        {
            // hai biến cho đơn giá và tồn kho
            string dg = dataGV_dt.CurrentRow.Cells["DonGia"].Value.ToString();
            string tk = dataGV_dt.CurrentRow.Cells["TonKho"].Value.ToString();
            // nếu cmd là get thì giá trị tham chiếu là mảng có giá trị (dg, tk)
            if (cmd == "get")
            {
                return new string[] { dg, tk };
            }
            // ngược lại, nó sẽ chỉ là mảng rỗng
            else
            {
                txt_gia.Text = dg;
                nud_tonkho.Text = tk;
                return new string[] {};
            }       
        }
        // hàm điều khiển thông báo
        private bool HandleAlerts(string type)
        {
            bool Check = false;
            string alert = "";
            // kiểm tra dạng thông báo
            switch (type)
            {
                // nếu là update thì sẽ thay đổi thông báo dựa trên đơn giá
                case "Update":
                     alert = (Convert.ToInt64(txt_gia.Text) > Convert.ToInt64(currentRow("get")[0])) ?
                        String.Format("Mặt hàng điện thoại {0} sẽ tăng giá?",
                        dataGV_dt.CurrentRow.Cells["TenDongDT"].Value.ToString())
                        :
                        String.Format("Mặt hàng điện thoại {0} sẽ giảm giá?",
                        dataGV_dt.CurrentRow.Cells["TenDongDT"].Value.ToString());

                        if (txt_gia.Text == currentRow("get")[0])
                            alert = String.Format("Mặt hàng điện thoại {0} vẫn sẽ giữ nguyên?",
                            dataGV_dt.CurrentRow.Cells["TenDongDT"].Value.ToString());
                    DialogResult dialogResult = MessageBox.Show(alert, "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        nud_tonkho.Focus();
                        Check = true;
                    }
                    break;
                // ngược lại, delete sẽ thay đổi thông báo phụ thuộc vào tồn kho
                default:
                    if (Convert.ToInt32(currentRow("get")[1]) > 0)
                    {
                        MessageBox.Show(String.Format(
                       "Bạn không thể xóa vì mặt hàng điện thoại {0} vì vẫn còn tồn kho",
                        dataGV_dt.CurrentRow.Cells["TenDongDT"].Value.ToString()));
                    }
                    else
                    {
                        alert = String.Format("Bạn có chắc chắn muốn xóa mặt hàng điện thoại {0}?",
                        dataGV_dt.CurrentRow.Cells["TenDongDT"].Value.ToString());
                        DialogResult dialogDelete = MessageBox.Show(alert, "Thông báo", MessageBoxButtons.YesNo);
                        Check = (dialogDelete == DialogResult.Yes) ? true : false;
                    }
                    break;
            }
            return Check;
        }
        // hàm kích hoạt lệnh SQL (Update và Delete, vv...)
        private void commandDataBTN(string type)
        {
            // Mã dòng ĐT 
            string idData = dataGV_dt.CurrentRow.Cells["Ma"].Value.ToString();
            // lệnh SQL và Thông báo
            string query, alert = "";
            query = (type == "Update") ?
            String.Format("UPDATE DIENTHOAI SET DonGia={0}, " +
                "TonKho={1} WHERE Ma='{2}'", txt_gia.Text, nud_tonkho.Text, idData) :
            // Delete
            String.Format("DELETE FROM DIENTHOAI WHERE Ma='{0}'", idData);
            alert = (type == "Update") ? "Đã cập nhật thành công" : "Đã xóa thành công";

            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(alert);
                activeDataGridSQL();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Connection.Close();
        }
        // Hàm truyền dữ liệu SQL vào ComboBox
        private void activeDataSQL()
        {
            string query = String.Format("SELECT * FROM HANGSX");
            adap = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            adap.Fill(dt);
            // Lấy giá trị là mã hàng
            cb_chonhang.DataSource = dt;
            cb_chonhang.ValueMember = "MaHang";
            cb_chonhang.DisplayMember = "MaHang";
        }
        // Hàm truyền dữ liệu SQL vào DataGridView
        private void activeDataGridSQL()
        {
            string query = String.Format("SELECT Ma,TenDT,DonGia,TonKho FROM DIENTHOAI WHERE MaHang='{0}'", cb_chonhang.Text.Trim());
            adap = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            adap.Fill(dt);
            dataGV_dt.DataSource = dt;
            lb_soluongdt.Text = (dataGV_dt.RowCount - 1).ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            activeDataSQL();
            cb_chonhang.SelectedIndex = -1;
            btn_capnhat.Enabled = false;
            btn_xoadongdienthoai.Enabled = false;
            if (!checkb_cngia.Checked)
            {
                txt_gia.Enabled = false;
            }
        }
        // Kết nối sự kiện với activeDataGridSQL để in ra bảng dữ liệu chính xác của từng loại mã 
        private void cb_chonhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeDataGridSQL();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            // Nếu HandleAlerts trả về true thì hàm kích hoạt lệnh SQL sẽ được triển khai
            if (HandleAlerts("Update"))
            {
                commandDataBTN("Update");  
            } 
        }

        private void dataGV_dt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGV_dt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa lỗi ở phần cập nhật và xóa
            currentRow("show");
            btn_xoadongdienthoai.Enabled = true;
            btn_capnhat.Enabled = false;
        }

        private void checkb_cngia_CheckedChanged(object sender, EventArgs e)
        {
            txt_gia.Enabled = (checkb_cngia.Checked) ? true : false;
        }

        private void lb_soluongdt_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoadongdienthoai_Click(object sender, EventArgs e)
        {
            if (HandleAlerts("Delete")) commandDataBTN("Delete");  
        }

        private void txt_gia_TextChanged(object sender, EventArgs e)
        {
            if (txt_gia.Text != currentRow("get")[0])
            {
                btn_capnhat.Enabled = true;
                checkb_cngia.Checked = true;
            }
        }
        private void nud_tonkho_ValueChanged(object sender, EventArgs e)
        {
            if (nud_tonkho.Text != currentRow("get")[1])
            {
                btn_capnhat.Enabled = true;
            }
        }

    }
}

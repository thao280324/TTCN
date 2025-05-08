using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thutap.Class;
using COMExecl = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace thutap
{
    public partial class FormPhieutra : Form
    {
        private string vaiTro;
        DataTable tblSachTam;
        bool isAdding = false;
        public FormPhieutra(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void FormPhieutra_Load(object sender, EventArgs e)
        {
            PhanQuyenChucNang();
            resetvalue();
            LoadPhieuMuon();
            dtpNgaytra.Format = DateTimePickerFormat.Custom;
            dtpNgaytra.CustomFormat = "dd/MM/yyyy";  // Định dạng ngày mong muốn
            btnThemmoi.Enabled = true;
            //btnSua.Enabled = true;
            btnXoaphieu.Enabled = true;
            btnLuuphieu.Enabled = false;
            btnThoat.Enabled = true;
            txtTenvipham.Enabled = false ;
            LoadPhieuMuon();

            // Load danh sách phiếu trả lên dataGridView3
            LoadPhieuTra();

            // Đăng ký event khi chọn 1 dòng trên dataGridView1
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // Grid2 chọn sách để thêm vào phiếu trả
            dataGridView2.CellClick += dataGridView2_CellClick;
            Class.function.FillCombo2("select Maphieutra from phieutra", cboPhieutra, "Maphieutra", "Maphieutra");
            cboPhieutra.SelectedIndex = -1;

            function.FillCombo("SELECT Manhanvien FROM nhanvien", cboManhanvien, "MaNhanVien"); cboManhanvien.SelectedIndex = -1;
            Class.function.FillCombo2("SELECT Mavipham FROM vipham", cboMavipham, "Mavipham","Tenvipham"); cboMavipham.SelectedIndex = -1;
        }
        private void LoadPhieuMuon()
        {
            string sql = @"
        SELECT 
            Maphieumuon, Mathanhvien, Ngaymuon, Manhanvien 
        FROM phieumuon";
            dataGridView1.DataSource = function.LoadDataToTable(sql);

            // Thiết lập cho chắc auto-generate hoặc custom header
            dataGridView1.AutoGenerateColumns = true;
        }

        private void PhanQuyenChucNang()
        {
            vaiTro = vaiTro.Trim();  // Loại bỏ khoảng trắng

            // Kiểm tra vai trò và phân quyền cho các nút
            if (vaiTro == "Nhân viên thủ thư")
            {
                // Nhân viên thủ thư có quyền thao tác tất cả các nút
                btnThemmoi.Enabled = true;
                btnXoaphieu.Enabled = true;
                btnLuuphieu.Enabled = true;
                btnThoat.Enabled = true;
                btnTimphieutra.Enabled=true;
            }
            else if (vaiTro == "Phó ban thủ thư")
            {
                // Phó ban và Trưởng ban chỉ có quyền tìm kiếm và in danh sách
                btnThemmoi.Enabled = false;
                btnXoaphieu.Enabled = false;
                btnLuuphieu.Enabled = false;
                btnThoat.Enabled = true;
                btnTimphieutra.Enabled = true;
                cboManhanvien.Enabled = false;
                txtMathanhvien.Enabled = false;
                mskNgaymuon.Enabled = false;
                dtpNgaytra.Enabled = false; 
                chkVipham.Enabled = false;
                cboMavipham.Enabled = false;
                txtTenvipham.Enabled = false;
                txtSongaymuon.Enabled = false;
                txtMaphieumuon.Enabled = false;
                txtMaphieutra.Enabled=false;
                cboPhieutra.Enabled=true;
                btnIn.Enabled = true;
            }
            else
            {
                // Nếu không có vai trò hợp lệ, đóng form
                MessageBox.Show("Bạn không có quyền truy cập vào form này!");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
      "Bạn đang thao tác trên dữ liệu.\nNếu bạn đóng lại bây giờ, mọi thay đổi chưa lưu sẽ bị mất.\n\nBạn có chắc chắn muốn thoát không?",
      "Xác nhận thoát",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question
  );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void resetvalue()
        {
            txtMathanhvien.Text = string.Empty;
            txtMaphieutra.Text = string.Empty;
            mskNgaymuon.Text = string.Empty;
            dtpNgaytra.Text = string.Empty;
            cboManhanvien.Text = string.Empty;
            chkVipham.Checked = false;
            cboMavipham.Enabled = false;
            txtTenvipham.Text = string.Empty;
            dtpNgaytra.Text = "";
            txtMathanhvien.Enabled = false;
            mskNgaymuon.Enabled = false;
            dtpNgaytra.Enabled = false;
            txtMaphieutra.Enabled = false;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            isAdding = true;
            // sinh tự động mã phiếu trả
            txtMaphieutra.Text = "PT" + DateTime.Now.ToString("yyyyMMddHHmmss");
            // reset form
            txtMaphieumuon.Text = "";
            txtMathanhvien.Clear();
            mskNgaymuon.Clear();
            dtpNgaytra.Text = "";
            txtSongaymuon.Clear();
            mskNgayphaitra.Clear();
            cboManhanvien.SelectedIndex = -1;
            chkVipham.Checked = false;
            cboMavipham.Text = "";
            cboMavipham.Enabled=false;
            txtTenvipham.Clear();
            mskNgayphaitra.Enabled=true;
            // khởi tạo DataTable tạm
            tblSachTam = new DataTable();
            tblSachTam.Columns.Add("Masach");
            tblSachTam.Columns.Add("Tensach");
            tblSachTam.Columns.Add("NgayMuon");
            tblSachTam.Columns.Add("NgayTra");
            tblSachTam.Columns.Add("SoNgayMuon", typeof(int));
            tblSachTam.Columns.Add("NgayPhaiTra");

            dataGridView2.DataSource = tblSachTam;
            dataGridView3.DataSource = tblSachTam.Copy();

            btnThemmoi.Enabled = false;
            btnLuuphieu.Enabled = btnXoaphieu.Enabled = true;
            dtpNgaytra.Enabled = true;
        }
        private void btnLuuphieu_Click(object sender, EventArgs e)
        {
            if (dtpNgaytra.Text == "  /  /")
            {
                MessageBox.Show("Bạn cần nhập ngày trả", "thongtbao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaytra.Focus();
                return;
            }
            if (cboManhanvien.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboManhanvien.Focus();
                return;
            }
            if (tblSachTam == null || tblSachTam.Rows.Count == 0)
            {
                MessageBox.Show("Không có sách nào để trả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboManhanvien.Text))
            {
                MessageBox.Show("Vui lòng chọn Mã nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboManhanvien.Focus();
                return;
            }
            if (dtpNgaytra.Text == "")
            {
                MessageBox.Show("Bạn cần nhập ngày trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaytra.Focus();
                return;
            }

            // Lấy ngày trả và các thông tin khác từ form
            string ngayTra = dtpNgaytra.Value.ToString("dd/MM/yyyy");
            string maphieutra = txtMaphieutra.Text.Trim();

            // Kiểm tra nếu có sách nào để trả
            if (tblSachTam.Rows.Count == 0)
            {
                MessageBox.Show("Không có sách để trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1. Lưu thông tin phiếu trả vào cơ sở dữ liệu
            string sqlPT = $@"
        INSERT INTO phieutra (Maphieutra, Maphieumuon, Ngaymuon, Ngaytra, Manhanvien)
        VALUES (N'{maphieutra}', N'{txtMaphieumuon.Text.Trim()}', '{mskNgaymuon.Text}', '{ngayTra}', N'{cboManhanvien.Text.Trim()}')
    ";
            function.RunSql(sqlPT);

            // 2. Lưu chi tiết trả sách
            foreach (DataRow r in tblSachTam.Rows)
            {
                string masach = r["Masach"].ToString();
                int soLuongTra = Convert.ToInt32(r["SoNgayMuon"]);  // Lấy số lượng trả từ bảng chi tiết tạm

                // Chèn chi tiết trả
                string sqlCT = $@"
            INSERT INTO chitietphieutra (Maphieutra, Masach, Soluong)
            VALUES (N'{maphieutra}', N'{masach}', {soLuongTra})
        ";
                function.RunSql(sqlCT);

                // Cập nhật tình trạng sách
                string sqlUpdateTinhTrang = $@"
            UPDATE chitietmuon
            SET Matinhtrang = 'TT01'  -- Mã tình trạng là 'Đã trả'
            WHERE Masach = N'{masach}' AND Maphieumuon = N'{txtMaphieumuon.Text.Trim()}'
        ";
                function.RunSql(sqlUpdateTinhTrang);

                // Cập nhật số lượng sách trong bảng sach
                string sqlUpdateSoluong = $@"
            UPDATE sach
            SET Soluong = Soluong + {soLuongTra}
            WHERE Masach = N'{masach}'
        ";
                function.RunSql(sqlUpdateSoluong);
            }

            MessageBox.Show("Lưu phiếu trả thành công và cập nhật tình trạng sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Làm mới các dữ liệu
            LoadPhieuTra();
            LoadPhieuMuon();
            function.FillCombo(       // Làm mới combobox tìm phiếu trả nếu bạn có
              "SELECT Maphieutra FROM phieutra",
              cboPhieutra,
              "Maphieutra");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1) Bỏ qua khi click header hoặc ngoài vùng dữ liệu
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
                return;

            // 2) Lấy Maphieumuon từ cột đúng tên trong grid1
            string mapm = dataGridView1.Rows[e.RowIndex]
                               .Cells["Maphieumuon"]
                               .Value?
                               .ToString();
            if (string.IsNullOrEmpty(mapm))
                return;

            // 3) Hiển thị Maphieumuon lên combobox tìm kiếm (nếu cần)
            txtMaphieumuon.Text = mapm;

            // 4) Điền tự động Mã thành viên và Ngày mượn
            txtMathanhvien.Text = dataGridView1.Rows[e.RowIndex]
                                      .Cells["Mathanhvien"]
                                      .Value?
                                      .ToString();
            mskNgaymuon.Text = dataGridView1.Rows[e.RowIndex]
                                   .Cells["Ngaymuon"]
                                   .Value?
                                   .ToString();

            // 5) Load chi tiết mượn (Masach, Tensach, Soluong, Matinhtrang, Tentinhtrang) lên grid2
            LoadChiTietMuon(mapm);

            // 6) Reset tạm bàn sách trả (nếu bạn muốn mỗi lần chọn phiếu mượn mới thì xóa bảng tạm cũ)
            tblSachTam = null;
            dataGridView3.DataSource = null;

            // 7) Kích hoạt nút Thêm mới để chuẩn bị chọn sách trả
            btnThemmoi.Enabled = true;
            btnLuuphieu.Enabled = btnXoaphieu.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1) Kiểm tra có dữ liệu
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Không có sách để chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2) Phải đang ở chế độ Thêm mới
            if (!isAdding)
            {
                MessageBox.Show("Bạn phải vào chế độ Thêm mới để chọn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3) Nhập Ngày trả trước
            if (dtpNgaytra.Value == null)
            {
                MessageBox.Show("Vui lòng chọn ngày trả hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaytra.Focus();
                return;
            }


            // 4) Lấy dữ liệu từ grid2
            string masach = dataGridView2.CurrentRow.Cells["Masach"].Value.ToString();
            string tensach = dataGridView2.CurrentRow.Cells["Tensach"].Value.ToString();
            // Lấy ngày mượn từ mskNgaymuon, không từ grid2
            DateTime ngayMuon = DateTime.Parse(mskNgaymuon.Text);
           // DateTime ngayTra = DateTime.Parse(dtpNgaytra.Text);
            // Lấy ngày trả từ dtpNgaytra
            DateTime ngayTra = dtpNgaytra.Value;

            // 5) Khởi tạo DataTable tạm nếu null
            if (tblSachTam == null)
            {
                tblSachTam = new DataTable();
                tblSachTam.Columns.Add("Masach");
                tblSachTam.Columns.Add("Tensach");
                tblSachTam.Columns.Add("NgayMuon");
                tblSachTam.Columns.Add("NgayTra");
                tblSachTam.Columns.Add("SoNgayMuon", typeof(int));
                tblSachTam.Columns.Add("NgayPhaiTra");
            }

            // 6) Kiểm tra đã chọn trước đó
            if (tblSachTam.Rows.Cast<DataRow>().Any(r => r["Masach"].ToString() == masach))
            {
                MessageBox.Show("Quyển sách này đã được chọn rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 7) Tính toán
            int soNgay = (ngayTra - ngayMuon).Days;
            DateTime phaiTra = ngayMuon.AddDays(10);
            txtSongaymuon.Text = soNgay.ToString();
            mskNgayphaitra.Text = phaiTra.ToShortDateString();

            // 8) Thêm vào tblSachTam
            var row = tblSachTam.NewRow();
            row["Masach"] = dataGridView2.CurrentRow.Cells["Masach"].Value;
            row["Tensach"] = dataGridView2.CurrentRow.Cells["Tensach"].Value;
            row["NgayMuon"] = ngayMuon.ToShortDateString();
            row["NgayTra"] = ngayTra.ToShortDateString();
            row["SoNgayMuon"] = soNgay;
            row["NgayPhaiTra"] = phaiTra.ToShortDateString();
            tblSachTam.Rows.Add(row);


            // 9) Update 2 grid: grid2 vẫn giữ chi tiết mượn, grid3 show tạm
            dataGridView3.DataSource = tblSachTam.Copy();

            // 10) Điền tự động
            txtMathanhvien.Text = dataGridView1.CurrentRow.Cells["Mathanhvien"].Value.ToString();
            mskNgaymuon.Text = dataGridView1.CurrentRow.Cells["Ngaymuon"].Value.ToString();

            // 11) Bật nút Lưu / Xóa
            btnLuuphieu.Enabled = true;
            btnXoaphieu.Enabled = true;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            // Lấy mã phiếu mượn đang chọn
            string mapm = dataGridView1.CurrentRow.Cells["Maphieumuon"].Value?.ToString();
            if (string.IsNullOrEmpty(mapm)) return;

            // Đổ chi tiết mượn tương ứng lên dataGridView2
            LoadChiTietMuon(mapm);
        }
        private void LoadChiTietMuon(string mapm)
        {
            // Đưa lên dataGridView2 các cột: Masach, Tensach, Soluong, Matinhtrang, Tentinhtrang
            string sql = $@"
        SELECT 
            ct.Masach,
            s.Tensach,
            ct.Soluong,
            ct.Matinhtrang,
            tt.Tentinhtrang
        FROM chitietmuon ct
        JOIN sach s         ON ct.Masach      = s.Masach
        JOIN tinhtrang tt   ON ct.Matinhtrang = tt.Matinhtrang
        WHERE ct.Maphieumuon = N'{mapm}' 
          AND ct.Matinhtrang != 'TT01'";  // Điều kiện loại bỏ sách có tình trạng TT01
            dataGridView2.DataSource = function.LoadDataToTable(sql);
            dataGridView2.AutoGenerateColumns = true;
        }
        private void LoadPhieuTra()
        {
            string sql = @"
        SELECT
            p.Maphieutra,
            p.Maphieumuon,
            p.Ngaytra,
            p.Manhanvien,
            p.Mavipham,
            v.Tenvipham
        FROM phieutra p
        LEFT JOIN vipham v
            ON p.Mavipham = v.Mavipham";
            dataGridView3.DataSource = function.LoadDataToTable(sql);
            dataGridView3.AutoGenerateColumns = true;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;  // tránh chọn header

            DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

            // Đảm bảo kiểm tra xem các giá trị từ các cột có tồn tại
            if (row.Cells["Maphieutra"].Value != null)
                txtMaphieutra.Text = row.Cells["Maphieutra"].Value.ToString();
            if (row.Cells["Maphieumuon"].Value != null)
                txtMaphieumuon.Text = row.Cells["Maphieumuon"].Value.ToString();
            if (row.Cells["Ngaytra"].Value != null)
                dtpNgaytra.Value = DateTime.Parse(row.Cells["Ngaytra"].Value.ToString());  // Sử dụng .Value thay vì .Text
            if (row.Cells["Manhanvien"].Value != null)
                cboManhanvien.Text = row.Cells["Manhanvien"].Value.ToString();
            if (row.Cells["Mavipham"].Value != DBNull.Value)
            {
                chkVipham.Checked = true;
                cboMavipham.Text = row.Cells["Mavipham"].Value.ToString();
                txtTenvipham.Text = row.Cells["Tenvipham"].Value.ToString();
            }
            else
            {
                chkVipham.Checked = false;
                cboMavipham.SelectedIndex = -1;
                txtTenvipham.Clear();
            }
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã chọn
                string maPhieuTra = dataGridView3.Rows[e.RowIndex].Cells["Maphieu"].Value.ToString();
                string maThanhVien = dataGridView3.Rows[e.RowIndex].Cells["Mathanhvien"].Value.ToString();
                string ngayMuon = dataGridView3.Rows[e.RowIndex].Cells["Ngaymuon"].Value.ToString();
                string ngayTra = dataGridView3.Rows[e.RowIndex].Cells["Ngaytra"].Value.ToString();
                string soNgayMuon = dataGridView3.Rows[e.RowIndex].Cells["Songaymuon"].Value.ToString();

                // Điền thông tin vào các trường của form
                txtMaphieutra.Text = maPhieuTra;
                txtMathanhvien.Text = maThanhVien;
                mskNgaymuon.Text = ngayMuon;
                dtpNgaytra.Text = ngayTra;
                txtSongaymuon.Text = soNgayMuon;

                // 2. Tùy chọn: bạn có thể load lại grid2 hoặc grid1 dựa trên Maphieumuon
                //    nếu muốn cho phép xem chi tiết mượn lại.
                LoadChiTietMuon(txtMaphieumuon.Text);
            }
        }

        private void cboMavipham_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMavipham.Text == "")
            {
                txtTenvipham.Text = "";
            }
            str = "select Tenvipham from vipham where Mavipham=N'" + cboMavipham.SelectedValue + "'";
            txtTenvipham.Text = Class.function.GetFieldValues(str);
        }

        private void btnTimphieutra_Click(object sender, EventArgs e)
        {
            // 1) Kiểm tra đã chọn mã phiếu trả chưa
            if (string.IsNullOrWhiteSpace(cboPhieutra.Text))
            {
                MessageBox.Show("Vui lòng chọn mã phiếu trả để tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhieutra.Focus();
                return;
            }
            string mapt = cboPhieutra.Text.Trim();

            // 2) Load thông tin master từ phieutra
            string sqlPT = $@"
        SELECT 
            pt.Maphieumuon,
            pt.Ngaytra,
            pt.Manhanvien,
            pt.Mavipham,
            v.Tenvipham
        FROM phieutra pt
        LEFT JOIN vipham v
            ON pt.Mavipham = v.Mavipham
        WHERE pt.Maphieutra = N'{mapt}'";
            DataTable dtPT = function.LoadDataToTable(sqlPT);
            if (dtPT.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phiếu trả này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRow rPT = dtPT.Rows[0];

            // 3) Điền lên form: mã mượn → từ PHIEUTRA
            string mapm = rPT["Maphieumuon"].ToString();
            cboPhieutra.Text = mapm;

            // 4) Lấy thêm Họ tên thành viên + Ngày mượn từ PHIEUMUON
            string sqlPM = $@"
        SELECT Mathanhvien, Ngaymuon 
        FROM phieumuon 
        WHERE Maphieumuon = N'{mapm}'";
            DataTable dtPM = function.LoadDataToTable(sqlPM);
            if (dtPM.Rows.Count > 0)
            {
                txtMathanhvien.Text = dtPM.Rows[0]["Mathanhvien"].ToString();
                mskNgaymuon.Text = Convert.ToDateTime(dtPM.Rows[0]["Ngaymuon"]).ToShortDateString();
            }
            else
            {
                txtMathanhvien.Clear();
                mskNgaymuon.Clear();
            }

            // 5) Ngày trả + NV thủ thư + vi phạm
            dtpNgaytra.Text = Convert.ToDateTime(rPT["Ngaytra"]).ToShortDateString();
            cboManhanvien.Text = rPT["Manhanvien"].ToString();
            if (rPT["Mavipham"] != DBNull.Value && !string.IsNullOrEmpty(rPT["Mavipham"].ToString()))
            {
                chkVipham.Checked = true;
                cboMavipham.Text = rPT["Mavipham"].ToString();
                txtTenvipham.Text = rPT["Tenvipham"].ToString();
            }
            else
            {
                chkVipham.Checked = false;
                cboMavipham.SelectedIndex = -1;
                txtTenvipham.Clear();
            }

            // 6) Load lại chi tiết mượn lên grid2
            LoadChiTietMuon(mapm);

            // 7) Load chi tiết trả lên grid3
            string sqlCTPT = $@"
        SELECT 
            ct.Masach,
            s.Tensach,
            pm.Ngaymuon,
            pt.Ngaytra,
            DATEDIFF(DAY, pm.Ngaymuon, pt.Ngaytra) AS SoNgayMuon,
            DATEADD(DAY, 10, pm.Ngaymuon)         AS NgayPhaiTra
        FROM chitietphieutra ct
        JOIN sach s       ON ct.Masach = s.Masach
        JOIN phieutra pt  ON ct.Maphieutra = pt.Maphieutra
        JOIN phieumuon pm ON pt.Maphieumuon = pm.Maphieumuon
        WHERE ct.Maphieutra = N'{mapt}'";
            dataGridView3.DataSource = function.LoadDataToTable(sqlCTPT);
            dataGridView3.AutoGenerateColumns = true;
        }

        private void btnXoaphieu_Click(object sender, EventArgs e)
        {
            // Kiểm tra có mã phiếu trả nào đã chọn không
            if (string.IsNullOrEmpty(txtMaphieutra.Text))
            {
                MessageBox.Show("Vui lòng chọn mã phiếu trả để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã phiếu trả cần xóa
            string mapt = txtMaphieutra.Text.Trim();

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn chắc chắn muốn xóa phiếu trả này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu người dùng chọn Yes, thực hiện xóa
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Bước 1: Lấy số lượng sách đã trả từ chitietphieutra
                    string sqlGetBooks = $@"
                SELECT Masach, Soluong 
                FROM chitietphieutra
                WHERE Maphieutra = N'{mapt}'";
                    DataTable dtBooks = function.LoadDataToTable(sqlGetBooks);

                    // Bước 2: Cập nhật lại số lượng sách trong bảng sach
                    foreach (DataRow row in dtBooks.Rows)
                    {
                        string masach = row["Masach"].ToString();
                        int soluong = Convert.ToInt32(row["Soluong"]);

                        string sqlUpdate = $@"
                    UPDATE sach
                    SET Soluong = Soluong + {soluong}
                    WHERE Masach = N'{masach}'";
                        function.RunSql(sqlUpdate);
                    }

                    // Bước 3: Xóa chi tiết phiếu trả
                    string sqlCT = $@"
                DELETE FROM chitietphieutra
                WHERE Maphieutra = N'{mapt}'";
                    function.RunSql(sqlCT);

                    // Bước 4: Xóa phiếu trả khỏi bảng phieutra
                    string sqlPT = $@"
                DELETE FROM phieutra
                WHERE Maphieutra = N'{mapt}'";
                    function.RunSql(sqlPT);

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Xóa phiếu trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Bước 5: Tải lại danh sách phiếu trả và reset các trường
                    LoadPhieuTra();
                    resetvalue();
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi nếu có vấn đề khi xóa
                    MessageBox.Show("Lỗi khi xóa phiếu trả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkVipham_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVipham.Checked)  // Khi checkbox "Vi phạm" được tích
            {
                cboMavipham.Enabled = true;  // Bật mã vi phạm
                txtTenvipham.Enabled = false;  // Bật tên vi phạm
            }
            else  // Khi checkbox "Vi phạm" không được tích
            {
                cboMavipham.Enabled = false;  // Tắt mã vi phạm
                txtTenvipham.Enabled = false;  // Tắt tên vi phạm
                cboMavipham.SelectedIndex = -1;  // Xóa mã vi phạm đã chọn
                txtTenvipham.Clear();  // Xóa tên vi phạm
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            COMExecl.Application exApp = new COMExecl.Application();
            COMExecl.Workbook exBook;
            COMExecl.Worksheet exSheet;
            COMExecl.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinPhieuTra, tblThongtinSach;
            exBook = exApp.Workbooks.Add(COMExecl.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];

            // Set the title for the Excel sheet
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Font.Name = "Times New Roman";
            exRange.Range["A1:B1"].Font.Size = 16;
            exRange.Range["A1:B1"].Font.Bold = true;
            exRange.Range["A1:B1"].Value = "D FREE BOOK";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Font.Size = 10;
            exRange.Range["A2:B2"].Value = "Địa chỉ: Đại La-Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Font.Size = 10;
            exRange.Range["A3:B3"].Value = "Hotline: 0233222299";
            exRange.Range["C2:E2"].Font.Size = 14;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3;
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "PHIẾU TRẢ SÁCH";

            // Add extra information: Mã phiếu trả, Mã nhân viên, Ngày mượn, Ngày trả
            exRange.Range["A6:A6"].MergeCells = true;
            exRange.Range["A6:A6"].Font.Size = 12;
            exRange.Range["A6:A6"].Font.Bold = true;
            exRange.Range["A6:A6"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:A6"].Value = "Mã phiếu trả:";

            exRange.Range["B6:B6"].MergeCells = true;
            exRange.Range["B6:B6"].Font.Size = 12;
            exRange.Range["B6:B6"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["B6:B6"].Value = txtMaphieutra.Text;

            exRange.Range["A7:A7"].MergeCells = true;
            exRange.Range["A7:A7"].Font.Size = 12;
            exRange.Range["A7:A7"].Font.Bold = true;
            exRange.Range["A7:A7"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A7:A7"].Value = "Mã nhân viên:";

            exRange.Range["B7:B7"].MergeCells = true;
            exRange.Range["B7:B7"].Font.Size = 12;
            exRange.Range["B7:B7"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["B7:B7"].Value = cboManhanvien.Text;

            exRange.Range["A9:A9"].MergeCells = true;
            exRange.Range["A9:A9"].Font.Size = 12;
            exRange.Range["A9:A9"].Font.Bold = true;
            exRange.Range["A9:A9"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A9:A9"].Value = "Ngày trả:";

            exRange.Range["B9:B9"].MergeCells = true;
            exRange.Range["B9:B9"].Font.Size = 12;
            exRange.Range["B9:B9"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["B9:B9"].Value = dtpNgaytra.Text;

            // Add the title for the books list section
            exRange.Range["A10:B10"].MergeCells = true;
            exRange.Range["A10:B10"].Font.Size = 12;
            exRange.Range["A10:B10"].Font.Bold = true;
            exRange.Range["A10:B10"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A10:B10"].Value = "DANH SÁCH CÁC CUỐN SÁCH TRẢ";

            // Query to get the loan details
            sql = "SELECT a.MaPhieuTra, a.MaNhanVien, a.NgayTra, b.MaSach, c.TenSach, b.Soluong " +
                  "FROM phieutra a " +
                  "JOIN chitietphieutra b ON a.MaPhieuTra = b.MaPhieuTra " +
                  "JOIN sach c ON b.MaSach = c.MaSach " +
                  "WHERE a.MaPhieuTra = N'" + txtMaphieutra.Text + "'";
            tblThongtinPhieuTra = Class.function.GetDataToTable(sql);

            // Adding header for books list
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Mã sách";
            exRange.Range["C11:C11"].Value = "Tên sách";
            exRange.Range["D11:D11"].Value = "Số lượng trả";
            exRange.Range["A11:D11"].Font.Bold = true;
            exRange.Range["A11:D11"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;

            // Insert the books list
            for (hang = 0; hang < tblThongtinPhieuTra.Rows.Count; hang++)
            {
                exSheet.Cells[hang + 12, 1].Value = hang + 1;  // STT
                exSheet.Cells[hang + 12, 2].Value = tblThongtinPhieuTra.Rows[hang]["MaSach"].ToString(); // Mã sách
                exSheet.Cells[hang + 12, 3].Value = tblThongtinPhieuTra.Rows[hang]["TenSach"].ToString(); // Tên sách
                exSheet.Cells[hang + 12, 4].Value = tblThongtinPhieuTra.Rows[hang]["Soluong"].ToString(); // Số lượng trả
            }

            // Adjust column widths
            exSheet.Columns["A:D"].AutoFit();

            // Finalize and display the Excel file
            exSheet.Name = "Phiếu Trả Sách";
            exApp.Visible = true;

            // Finalize and display the Excel file
            exSheet.Name = "Phiếu Trả Sách";
            exApp.Visible = true;

        }
    }
}

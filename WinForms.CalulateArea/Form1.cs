namespace WinForms.CalulateArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับผู้ใช้งาน", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("จะออกจริงๆหย๋อ", "Go away.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            double Radius = 0;
            //Radius = Convert.ToDouble(this.txtRadius.Text);
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("นั้นตั๋ว");
                txtRadius.Focus();     //ให้มี cursor มี Textbox
                txtRadius.SelectAll();  // ให้มี selected ข้อความใน textbox
                return;
            }
            double CircleArea = Math.PI * Math.Pow(Radius, 2);

            lblResult.Text = CircleArea.ToString("0.00");
            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void butnTriangleArea_Click(object sender, EventArgs e)
        {
            double Base = 0, Height = 0;

            // ตรวจสอบค่า Base
            if (double.TryParse(txtWidht.Text, out Base) == false)
            {
                MessageBox.Show("กรุณากรอกค่าฐานให้ถูกต้อง");
                txtWidht.Focus();     // ให้ cursor อยู่ใน TextBox ของ Base
                txtWidht.SelectAll();  // ให้เลือกข้อความใน TextBox ของ Base
                return;
            }

            // ตรวจสอบค่า Height
            if (double.TryParse(txtHeight.Text, out Height) == false)
            {
                MessageBox.Show("กรุณากรอกค่าสูงให้ถูกต้อง");
                txtHeight.Focus();   // ให้ cursor อยู่ใน TextBox ของ Height
                txtHeight.SelectAll(); // ให้เลือกข้อความใน TextBox ของ Height
                return;
            }

            // คำนวณพื้นที่สามเหลี่ยม
            double TriangleArea = 0.5 * Base * Height;

            // แสดงผลลัพธ์ใน Label
            lblResult2.Text = TriangleArea.ToString("0.00");

            // ให้ focus กลับมาที่ TextBox ของ Base เพื่อแก้ไขหรือกรอกค่าใหม่
            txtWidht.Focus();
            txtWidht.SelectAll();
            txtHeight.Focus();
            txtHeight.SelectAll();

        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double Side = 0;

            // ตรวจสอบค่าความยาวด้าน
            if (double.TryParse(txtHexagonWidth.Text, out Side) == false)
            {
                MessageBox.Show("กรุณากรอกค่าความยาวด้านให้ถูกต้อง");
                txtHexagonWidth.Focus();     // ให้ cursor อยู่ใน TextBox ของ Side
                txtHexagonWidth.SelectAll(); // ให้เลือกข้อความใน TextBox
                return;
            }

            // คำนวณพื้นที่สี่เหลี่ยมด้านเท่า
            double HexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(Side, 2);

            // แสดงผลลัพธ์ใน Label
            lblResult3.Text = HexagonArea.ToString("0.00");

            // ให้ focus กลับมาที่ TextBox ของ Side เพื่อแก้ไขหรือกรอกค่าใหม่
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();

        }
    }

}

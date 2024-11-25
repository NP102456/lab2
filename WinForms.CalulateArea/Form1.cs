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
            MessageBox.Show("�Թ�յ�͹�Ѻ�����ҹ", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("���͡��ԧ�����", "Go away.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
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
                MessageBox.Show("��鹵���");
                txtRadius.Focus();     //����� cursor �� Textbox
                txtRadius.SelectAll();  // ����� selected ��ͤ���� textbox
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

            // ��Ǩ�ͺ��� Base
            if (double.TryParse(txtWidht.Text, out Base) == false)
            {
                MessageBox.Show("��سҡ�͡��Ұҹ���١��ͧ");
                txtWidht.Focus();     // ��� cursor ����� TextBox �ͧ Base
                txtWidht.SelectAll();  // ������͡��ͤ���� TextBox �ͧ Base
                return;
            }

            // ��Ǩ�ͺ��� Height
            if (double.TryParse(txtHeight.Text, out Height) == false)
            {
                MessageBox.Show("��سҡ�͡����٧���١��ͧ");
                txtHeight.Focus();   // ��� cursor ����� TextBox �ͧ Height
                txtHeight.SelectAll(); // ������͡��ͤ���� TextBox �ͧ Height
                return;
            }

            // �ӹǳ��鹷������������
            double TriangleArea = 0.5 * Base * Height;

            // �ʴ����Ѿ��� Label
            lblResult2.Text = TriangleArea.ToString("0.00");

            // ��� focus ��Ѻ�ҷ�� TextBox �ͧ Base ����������͡�͡�������
            txtWidht.Focus();
            txtWidht.SelectAll();
            txtHeight.Focus();
            txtHeight.SelectAll();

        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double Side = 0;

            // ��Ǩ�ͺ��Ҥ�����Ǵ�ҹ
            if (double.TryParse(txtHexagonWidth.Text, out Side) == false)
            {
                MessageBox.Show("��سҡ�͡��Ҥ�����Ǵ�ҹ���١��ͧ");
                txtHexagonWidth.Focus();     // ��� cursor ����� TextBox �ͧ Side
                txtHexagonWidth.SelectAll(); // ������͡��ͤ���� TextBox
                return;
            }

            // �ӹǳ��鹷��������������ҹ���
            double HexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(Side, 2);

            // �ʴ����Ѿ��� Label
            lblResult3.Text = HexagonArea.ToString("0.00");

            // ��� focus ��Ѻ�ҷ�� TextBox �ͧ Side ����������͡�͡�������
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();

        }
    }

}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab02_03
{
    public partial class Form1 : Form
    {
        private readonly int[] ticketPrices = { 30000, 40000, 50000, 80000 };
        private Button[] seats = new Button[20];
        private int totalAmount = 0;
        private int selectedSeats = 0;

        private Label lblTotalAmount;

        public Form1()
        {
            InitializeComponent();
            InitializeSeatLayout();
        }

        private void InitializeSeatLayout()
        {
            int rows = 4; 
            int cols = 5; 
            int xPos = 10;
            int yPos = 10; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int seatNumber = i * cols + j;
                    Button seatButton = new Button
                    {
                        Size = new Size(60, 60),
                        Location = new Point(xPos + j * 70, yPos + i * 70),
                        Text = (seatNumber + 1).ToString(),
                        Tag = seatNumber,
                        BackColor = Color.White
                    };
                    seatButton.Click += SeatButton_Click;
                    seats[seatNumber] = seatButton;
                    this.Controls.Add(seatButton);
                }
            }

            lblTotalAmount = new Label
            {
                Text = "Tổng tiền: 0 VND",
                Location = new Point(10, yPos + rows * 70 + 10),
                Size = new Size(200, 30),
                Name = "lblTotalAmount" 
            };
            this.Controls.Add(lblTotalAmount);

            Button btnSelect = new Button
            {
                Text = "CHỌN",
                Location = new Point(10, lblTotalAmount.Bottom + 10),
                Size = new Size(100, 40)
            };
            btnSelect.Click += BtnSelect_Click;
            this.Controls.Add(btnSelect);

            Button btnCancel = new Button
            {
                Text = "HỦY BỎ",
                Location = new Point(120, lblTotalAmount.Bottom + 10),
                Size = new Size(100, 40)
            };
            btnCancel.Click += BtnCancel_Click;
            this.Controls.Add(btnCancel);

            Button btnExit = new Button
            {
                Text = "Kết Thúc",
                Location = new Point(230, lblTotalAmount.Bottom + 10),
                Size = new Size(100, 40)
            };
            btnExit.Click += BtnExit_Click;
            this.Controls.Add(btnExit);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
          this.Hide();
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int seatNumber = (int)btn.Tag;

            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                selectedSeats++;
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                selectedSeats--;
            }
            else if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = 0;

                foreach (Button seatButton in seats)
                {
                    if (seatButton.BackColor == Color.Blue)
                    {
                        seatButton.BackColor = Color.Yellow;
                        int seatNumber = (int)seatButton.Tag;
                        int row = seatNumber / 5;
                        amount += ticketPrices[row];
                    }
                }

                totalAmount += amount;
                lblTotalAmount.Text = $"Tổng tiền: {totalAmount} VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            foreach (Button seatButton in seats)
            {
                if (seatButton.BackColor == Color.Blue)
                {
                    seatButton.BackColor = Color.White;
                }
            }

            selectedSeats = 0;
            lblTotalAmount.Text = $"Tổng tiền: {totalAmount} VND";
        }
    }
}

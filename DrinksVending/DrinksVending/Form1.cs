using static System.Windows.Forms.LinkLabel;

namespace DrinksVending
{
    public partial class Form1 : Form
    {
        private List<Drink> drinkQueue = new List<Drink>();
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            UpdateQueueDisplay();
        }

        private void UpdateDrinksCounts() //����� ��� ������� ��������
        {
            int juiseCount = 0;
            int sodaCount = 0;
            int alkoCount = 0;

            foreach (Drink drinks in drinkQueue)
            {
                if (drinks is Juice)
                    juiseCount++;
                else if (drinks is Soda)
                    sodaCount++;
                else if (drinks is Alcohol)
                    alkoCount++;
            }

            lbJuise.Text = juiseCount.ToString();
            lbGaz.Text = sodaCount.ToString();
            lbAlko.Text = alkoCount.ToString();
        }

        private void LoadRandomDrink(int count)
        {
            // ���������� ��������� �������� � �������
            for (int i = 0; i < count; i++)
            {
                switch (random.Next(3)) // ���������� ���� �� ���� ����� ��������
                {
                    case 0:
                        drinkQueue.Add(new Juice
                        {
                            Volume = random.Next(250, 500),
                            Fruit = "������",
                            HasPulp = random.Next(2) == 0
                        });
                        break;
                    case 1:
                        drinkQueue.Add(new Soda
                        {
                            Volume = random.Next(250, 500),
                            Type = "����",
                            BubblesCount = random.Next(10000, 20000)
                        });
                        break;
                    case 2:
                        drinkQueue.Add(new Alcohol
                        {
                            Volume = random.Next(50, 200),
                            Strength = random.Next(5, 40),
                            Type = "�����"
                        });
                        break;
                }
            }
        }

        private void UpdateQueueDisplay()
        {
            txtQueue.Clear();
            foreach (Drink drink in drinkQueue)
            {
                txtQueue.AppendText(drink.GetDescription() + "\n\n");
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadRandomDrink(10); // �������� ��������� �������
            UpdateQueueDisplay();
            UpdateDrinksCounts();
        }

        private void btnGetDrink_Click(object sender, EventArgs e)
        {
            if (drinkQueue.Count > 0)
            {
                Drink drink = drinkQueue[0];
                drinkQueue.RemoveAt(0);
                txtInfo.Text = drink.GetDescription();
                UpdateQueueDisplay();
                UpdateDrinksCounts();
            }
            else
            {
                txtInfo.Text = "������� ����";
            }
        }
    }
}
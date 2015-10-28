using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card
{
    public partial class Form1 : Form
    {
        private List<ACard> all;
        private Player Player1;
        private Player Player2; 

        private ACard a;
        private ACard b;
        private ACard pilea;
        private ACard pileb;

        private Boolean checkFirstCompare;
        private Boolean checkManyHitCompare;
        private Boolean checkManyHitDraw;
        private Boolean checkFirstPileA;
        private Boolean checkFirstPileB;

        //Form function
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            deckA.Image = Image.FromFile("back.jpg");
            deckB.Image = Image.FromFile("back.jpg");
            Prepare();
        }

        //Prepare Function
        public void Prepare()
        {
            checkFirstCompare = true;
            checkFirstPileA = true;
            checkFirstPileB = true;
            all = new List<ACard>();
            Player1 = new Player("A");
            Player2 = new Player("B");
            for (int i = 1; i <= 13; i++) for (int j = 1; j <= 4; j++) all.Add(new ACard(i, j));
            all = ShuffleList(all);
            for (int i=0;i<52;i+=2)
            {
                Player1.addDeck(all[i]);
                Player2.addDeck(all[i+1]);
            }
        }

        //Shuffle Function
        private List<ACard> ShuffleList(List<ACard> inputList)
        {
            List<ACard> randomList = new List<ACard>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count);
                randomList.Add(inputList[randomIndex]);
                inputList.RemoveAt(randomIndex);
            }

            return randomList;
        }

        //Click to Draw card
        private void hit_Click(object sender, EventArgs e)
        {
            if (Player1.getNumdeck() == 1)
            {
                deckA.Hide();
                deckB.Hide();
            }
            if (!checkManyHitDraw)
            {
                if (Player1.getNumdeck() > 0) Draw();
                else
                {
                    if (Player1.getNumpile() > Player2.getNumpile()) MessageBox.Show("All cards were drawed! Player A is !!!WINNER!!!");
                    else MessageBox.Show("All cards were drawed! Player B is !!!WINNER!!!");
                    System.Threading.Thread.Sleep(2000);
                }
            }
        }

        //Draw Function
        public void Draw()
        {
            checkFirstCompare = false;
            checkManyHitCompare = false;
            checkManyHitDraw = true;
            a = Player1.getCard();
            b = Player2.getCard();

            if (!checkFirstPileA) pileA.Image = Image.FromFile(getAddress(pilea.getRank(), pilea.getSuit()));
            if (!checkFirstPileB) pileB.Image = Image.FromFile(getAddress(pileb.getRank(), pileb.getSuit()));
            showA.Image = Image.FromFile(getAddress(a.getRank(), a.getSuit()));
            showB.Image = Image.FromFile("back.jpg");
        }

        //Click to compare Card
        private void com_Click(object sender, EventArgs e)
        {
            if (!checkManyHitCompare && !checkFirstCompare) Compare();
        }

        //Compare Function
        public void Compare()
        {
            checkManyHitCompare = true;
            checkManyHitDraw = false;
            showB.Image = Image.FromFile(getAddress(b.getRank(), b.getSuit()));
            int rankA = a.getRank();
            int rankB = b.getRank();

            if (rankA > rankB)
            {
                Player2.addPile(a);
                Player2.addPile(b);
                pileb = b;
                listB.Items.Add(Convert.ToString(a.getRank()) + " " + Convert.ToString(a.getSuit()));
                listB.Items.Add(Convert.ToString(b.getRank()) + " " + Convert.ToString(b.getSuit()));
                checkFirstPileB = false;
            }
            else if (rankB > rankA)
            {
                Player1.addPile(b);
                Player1.addPile(a);
                listA.Items.Add(Convert.ToString(b.getRank()) + " " + Convert.ToString(b.getSuit()));
                listA.Items.Add(Convert.ToString(a.getRank()) + " " + Convert.ToString(a.getSuit()));
                pilea = a;
                checkFirstPileA = false;
            }
            else
            {
                MessageBox.Show("Rank is Equal at Rank " + Convert.ToString(a.getRank()));
                if (Player1.getNumdeck() - a.getRank() <= 0)
                {
                    if (Player1.getNumpile() > Player2.getNumpile()) MessageBox.Show("All cards were drawed! Player A is !!!WINNER!!!");
                    else MessageBox.Show("All cards were drawed! Player B is !!!WINNER!!!");
                    System.Threading.Thread.Sleep(2000);
                }
                List<ACard> tmp1 = new List<ACard>();
                List<ACard> tmp2 = new List<ACard>();
                int num = a.getRank(), i;

                for (i = 0; i < num; i++)
                {
                    tmp1.Add(Player1.getCard());
                    tmp2.Add(Player2.getCard());
                }
                showA.Image = Image.FromFile(getAddress(tmp1[i - 1].getRank(), tmp1[i - 1].getSuit()));
                showB.Image = Image.FromFile(getAddress(tmp2[i - 1].getRank(), tmp2[i - 1].getSuit()));
                if (tmp1[i - 1].getRank() > tmp2[i - 1].getRank())
                {
                    MessageBox.Show("Player2 Win " + num * 2 + " Cards!!!");
                    for (i = 0; i < num; i++)
                    {
                        Player2.addPile(tmp1[i]);
                        Player2.addPile(tmp2[i]);
                        pileb = b;
                        listB.Items.Add(Convert.ToString(tmp1[i].getRank()) + " " + Convert.ToString(tmp1[i].getSuit()));
                        listB.Items.Add(Convert.ToString(tmp2[i].getRank()) + " " + Convert.ToString(tmp2[i].getSuit()));
                        checkFirstPileB = false;
                    }
                }
                else if (tmp1[i - 1].getRank() < tmp2[i - 1].getRank())
                {
                    MessageBox.Show("Player1 Win " + num * 2 + " Cards!!!");
                    for (i = 0; i < num; i++)
                    {
                        Player1.addPile(tmp2[i]);
                        Player1.addPile(tmp1[i]);
                        pilea = a;
                        listA.Items.Add(Convert.ToString(tmp2[i].getRank()) + " " + Convert.ToString(tmp2[i].getSuit()));
                        listA.Items.Add(Convert.ToString(tmp1[i].getRank()) + " " + Convert.ToString(tmp1[i].getSuit()));
                        checkFirstPileA = false;
                    }
                }
                else
                {
                    MessageBox.Show("Equal again!!! Return card to your deck and shuffle");
                    for (i = 0; i < num; i++)
                    {
                        Player1.addDeck(tmp1[i]);
                        Player2.addDeck(tmp2[i]);
                    }
                    Player1.inDeck(ShuffleList(Player1.getDeck()));
                    Player2.inDeck(ShuffleList(Player2.getDeck()));
                }
            }
            numpileA.Text = Convert.ToString(Player1.getNumpile());
            numpileB.Text = Convert.ToString(Player2.getNumpile());
        }

        //Generate name of card to use for call card's image
        public string getAddress(int rank,int suit)
        {
            string str = Convert.ToString(rank)+"-"+Convert.ToString(suit)+".png";
            return str;
        }
    }
}

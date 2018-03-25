using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        PictureBox[] SEQUENCEDISPLAY = new PictureBox[4];
        int counter = 0;
        int MAINBORDCOUNTER = 0;
        int KEYPEGCOUNTER = 0;
        int KEYPEGSUSEDINTURN = 0;
        Color[] MAINCODE = new Color[] { Color.Red, Color.Yellow, Color.Magenta, Color.Green } ;
        PictureBox[] KEYPEGS = new PictureBox[44] ;
        Color[] PLAYERTWOGUESS = new Color[4];

        PictureBox[] MAINBORD = new PictureBox[44];


        int TURNNUMBER = 0;
        bool guessed = false;

        public Form2()
        {
            InitializeComponent();
            SEQUENCEDISPLAY[0] = pictureBox9;
            SEQUENCEDISPLAY[1] = pictureBox10;
            SEQUENCEDISPLAY[2] = pictureBox11;
            SEQUENCEDISPLAY[3] = pictureBox12;

            MAINBORD[0] = pictureBox13;
            MAINBORD[1] = pictureBox14;
            MAINBORD[2] = pictureBox15;
            MAINBORD[3] = pictureBox16;
            MAINBORD[4] = pictureBox17;
            MAINBORD[5] = pictureBox18;
            MAINBORD[6] = pictureBox19;
            MAINBORD[7] = pictureBox20;
            MAINBORD[8] = pictureBox21;
            MAINBORD[9] = pictureBox22;
            MAINBORD[10] = pictureBox23;
            MAINBORD[11] = pictureBox24;
            MAINBORD[12] = pictureBox25;
            MAINBORD[13] = pictureBox26;
            MAINBORD[14] = pictureBox27;
            MAINBORD[15] = pictureBox28;
            MAINBORD[16] = pictureBox29;
            MAINBORD[17] = pictureBox30;
            MAINBORD[18] = pictureBox31;
            MAINBORD[19] = pictureBox32;
            MAINBORD[20] = pictureBox33;
            MAINBORD[21] = pictureBox34;
            MAINBORD[22] = pictureBox35;
            MAINBORD[23] = pictureBox36;
            MAINBORD[24] = pictureBox37;
            MAINBORD[25] = pictureBox38;
            MAINBORD[26] = pictureBox39;
            MAINBORD[27] = pictureBox40;
            MAINBORD[28] = pictureBox41;
            MAINBORD[29] = pictureBox42;
            MAINBORD[30] = pictureBox43;
            MAINBORD[31] = pictureBox44;
            MAINBORD[32] = pictureBox45;
            MAINBORD[33] = pictureBox46;
            MAINBORD[34] = pictureBox47;
            MAINBORD[35] = pictureBox48;
            MAINBORD[36] = pictureBox49;
            MAINBORD[37] = pictureBox50;
            MAINBORD[38] = pictureBox51;
            MAINBORD[39] = pictureBox52;
            MAINBORD[40] = pictureBox53;
            MAINBORD[41] = pictureBox54;
            MAINBORD[42] = pictureBox55;
            MAINBORD[43] = pictureBox56;

            KEYPEGS[0] = pictureBox57;
            KEYPEGS[1] = pictureBox58;
            KEYPEGS[2] = pictureBox59;
            KEYPEGS[3] = pictureBox60;
            KEYPEGS[4] = pictureBox61;
            KEYPEGS[5] = pictureBox62;
            KEYPEGS[6] = pictureBox63;
            KEYPEGS[7] = pictureBox64;
            KEYPEGS[8] = pictureBox65;
            KEYPEGS[9] = pictureBox66;
            KEYPEGS[10] = pictureBox67;
            KEYPEGS[11] = pictureBox68;
            KEYPEGS[12] = pictureBox69;
            KEYPEGS[13] = pictureBox70;
            KEYPEGS[14] = pictureBox71;
            KEYPEGS[15] = pictureBox72;
            KEYPEGS[16] = pictureBox73;
            KEYPEGS[17] = pictureBox74;
            KEYPEGS[18] = pictureBox75;
            KEYPEGS[19] = pictureBox76;
            KEYPEGS[20] = pictureBox77;
            KEYPEGS[21] = pictureBox78;
            KEYPEGS[22] = pictureBox79;
            KEYPEGS[23] = pictureBox80;
            KEYPEGS[24] = pictureBox81;
            KEYPEGS[25] = pictureBox82;
            KEYPEGS[26] = pictureBox83;
            KEYPEGS[27] = pictureBox84;
            KEYPEGS[28] = pictureBox85;
            KEYPEGS[29] = pictureBox86;
            KEYPEGS[30] = pictureBox87;
            KEYPEGS[31] = pictureBox88;
            KEYPEGS[32] = pictureBox89;
            KEYPEGS[33] = pictureBox90;
            KEYPEGS[34] = pictureBox91;
            KEYPEGS[35] = pictureBox92;
            KEYPEGS[36] = pictureBox93;
            KEYPEGS[37] = pictureBox94;
            KEYPEGS[38] = pictureBox95;
            KEYPEGS[39] = pictureBox96;
            KEYPEGS[40] = pictureBox97;
            KEYPEGS[41] = pictureBox98;
            KEYPEGS[42] = pictureBox99;
            KEYPEGS[43] = pictureBox100;
        }

        public void INPUTSEQUENCE(Color COLORTOBE)
        {
            SEQUENCEDISPLAY[counter].BackColor = COLORTOBE;
            counter++;
            if (counter == 4)
            {
                counter=0;
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            INPUTSEQUENCE(Color.Red);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            INPUTSEQUENCE(Color.Blue);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            INPUTSEQUENCE(Color.Green);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            INPUTSEQUENCE(Color.Purple);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            INPUTSEQUENCE(Color.Yellow);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            INPUTSEQUENCE(Color.Orange);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            INPUTSEQUENCE(Color.Magenta);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            INPUTSEQUENCE(Color.Crimson);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            GAMERUN();
        }

        private void GAMERUN()
        {
            for (int i = 0; i <= 3; i++)
            {
                PLAYERTWOGUESS[i] = SEQUENCEDISPLAY[i].BackColor;
            }


          
            for (int i = 0; i <= 3; i++)
            {
                if (MAINCODE[i] == PLAYERTWOGUESS[i])
                {
                    KEYPEGS[KEYPEGCOUNTER].BackColor = Color.Black;
                    KEYPEGCOUNTER++;
                    KEYPEGSUSEDINTURN++;
                    
                }
            }


            //generating white pegs
            for (int x = 0; x <= 3; x++)
            {
                for (int i = 0; i <= 3; i++)
                {
                    if (MAINCODE[i] == PLAYERTWOGUESS[x] & i != x)
                    {
                       KEYPEGS[KEYPEGCOUNTER].BackColor = Color.White;
                        KEYPEGCOUNTER++;
                        KEYPEGSUSEDINTURN++;
                    }
                }
            }
            int Sparepegs = 4;
            Sparepegs = Sparepegs - KEYPEGSUSEDINTURN;
            KEYPEGCOUNTER = KEYPEGCOUNTER + Sparepegs;
            KEYPEGSUSEDINTURN = 0;

            //writing to MAINBORD
            for (int x = 0; x <= 3; x++)
            {
                MAINBORD[MAINBORDCOUNTER].BackColor = SEQUENCEDISPLAY[x].BackColor;
                MAINBORDCOUNTER++;
            }

        }

        private void PrintMAINBORD(string[,] MAINBORD)
        {
            String ALLTEXT = "";

            ALLTEXT=ALLTEXT+"your guess:     /      your score";
            for (int i = 0; i <= 12; i++)
            {
                ALLTEXT = ALLTEXT + MAINBORD[i, 0];
                ALLTEXT = ALLTEXT + MAINBORD[i, 1];

            }
           
        
        }
    }
}

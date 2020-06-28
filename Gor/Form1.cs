using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Gor
{

    public partial class Form1 : Form
    {
        private int[] color = new int[82];
        private int[] tedad = new int[82];
        private int[] halat = new int[82];
        private int[] shekl = new int[82];
        private int[] cod = new int[3334];
        private int tamam = 0;
        private int secend = 0;
        private int shim1 = 0;
        private int shim2 = 0;
        private int shim3 = 0;
        private int shim11 = 0;
        private int shim22 = 0;
        private int shim33 = 0;
        private int kartha = 0;
        private int kartha2 = 0;
       // private int dagh = 0, san = 0;
        private string pic1 = "";
        private string pic2 = "";
        private string pic3 = "";
        private string pic11 = "";
        private string pic22 = "";
        private string pic33 = "";
        private string pic111 = "";
        private string pic222 = "";
        private string pic333 = "";
        private ArrayList kartamad = new ArrayList();
        private ArrayList nafaraval = new ArrayList();
        private ArrayList nafardovom = new ArrayList();
        private bool com = true;
        private bool click = true;
        public Form1()
        {
            InitializeComponent();
        }

        private bool gorhast(int shoimg1, int shoimg2, int shoimg3)
        {
            if ((color[shoimg1] == color[shoimg2] && color[shoimg2] == color[shoimg3]) || (color[shoimg1] != color[shoimg2] && color[shoimg1] != color[shoimg3] && color[shoimg2] != color[shoimg3]))
            {
                if ((tedad[shoimg1] == tedad[shoimg2] && tedad[shoimg2] == tedad[shoimg3]) || (tedad[shoimg1] != tedad[shoimg2] && tedad[shoimg1] != tedad[shoimg3] && tedad[shoimg2] != tedad[shoimg3]))
                {
                    if ((halat[shoimg1] == halat[shoimg2] && halat[shoimg2] == halat[shoimg3]) || (halat[shoimg1] != halat[shoimg2] && halat[shoimg1] != halat[shoimg3] && halat[shoimg2] != halat[shoimg3]))
                    {
                        if ((shekl[shoimg1] == shekl[shoimg2] && shekl[shoimg2] == shekl[shoimg3]) || (shekl[shoimg1] != shekl[shoimg2] && shekl[shoimg1] != shekl[shoimg3] && shekl[shoimg2] != shekl[shoimg3]))
                        {
                            return true;
                        }
                    }

                }
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            color[1] = 1;
            color[2] = 1;
            color[3] = 1;
            color[4] = 1;
            color[5] = 1;
            color[6] = 1;
            color[7] = 1;
            color[8] = 1;
            color[9] = 1;
            color[10] = 2;
            color[11] = 2;
            color[12] = 2;
            color[13] = 2;
            color[14] = 2;
            color[15] = 2;
            color[16] = 2;
            color[17] = 2;
            color[18] = 2;
            color[19] = 3;
            color[20] = 3;
            color[21] = 3;
            color[22] = 3;
            color[23] = 3;
            color[24] = 3;
            color[25] = 3;
            color[26] = 3;
            color[27] = 3;
            color[28] = 1;
            color[29] = 1;
            color[30] = 1;
            color[31] = 1;
            color[32] = 1;
            color[33] = 1;
            color[34] = 1;
            color[35] = 1;
            color[36] = 1;
            color[37] = 2;
            color[38] = 2;
            color[39] = 2;
            color[40] = 2;
            color[41] = 2;
            color[42] = 2;
            color[43] = 2;
            color[44] = 2;
            color[45] = 2;
            color[46] = 3;
            color[47] = 3;
            color[48] = 3;
            color[49] = 3;
            color[50] = 3;
            color[51] = 3;
            color[52] = 3;
            color[53] = 3;
            color[54] = 3;
            color[55] = 1;
            color[56] = 1;
            color[57] = 1;
            color[58] = 1;
            color[59] = 1;
            color[60] = 1;
            color[61] = 1;
            color[62] = 1;
            color[63] = 1;
            color[64] = 2;
            color[65] = 2;
            color[66] = 2;
            color[67] = 2;
            color[68] = 2;
            color[69] = 2;
            color[70] = 2;
            color[71] = 2;
            color[72] = 2;
            color[73] = 3;
            color[74] = 3;
            color[75] = 3;
            color[76] = 3;
            color[77] = 3;
            color[78] = 3;
            color[79] = 3;
            color[80] = 3;
            color[81] = 3;

            //tedad
            tedad[1] = 1;
            tedad[2] = 2;
            tedad[3] = 3;
            tedad[4] = 1;
            tedad[5] = 2;
            tedad[6] = 3;
            tedad[7] = 1;
            tedad[8] = 2;
            tedad[9] = 3;
            tedad[10] = 1;
            tedad[11] = 2;
            tedad[12] = 3;
            tedad[13] = 1;
            tedad[14] = 2;
            tedad[15] = 3;
            tedad[16] = 1;
            tedad[17] = 2;
            tedad[18] = 3;
            tedad[19] = 1;
            tedad[20] = 2;
            tedad[21] = 3;
            tedad[22] = 1;
            tedad[23] = 2;
            tedad[24] = 3;
            tedad[25] = 1;
            tedad[26] = 2;
            tedad[27] = 3;
            tedad[28] = 1;
            tedad[29] = 2;
            tedad[30] = 3;
            tedad[31] = 1;
            tedad[32] = 2;
            tedad[33] = 3;
            tedad[34] = 1;
            tedad[35] = 2;
            tedad[36] = 3;
            tedad[37] = 1;
            tedad[38] = 2;
            tedad[39] = 3;
            tedad[40] = 1;
            tedad[41] = 2;
            tedad[42] = 3;
            tedad[43] = 1;
            tedad[44] = 2;
            tedad[45] = 3;
            tedad[46] = 1;
            tedad[47] = 2;
            tedad[48] = 3;
            tedad[49] = 1;
            tedad[50] = 2;
            tedad[51] = 3;
            tedad[52] = 1;
            tedad[53] = 2;
            tedad[54] = 3;
            tedad[55] = 1;
            tedad[56] = 2;
            tedad[57] = 3;
            tedad[58] = 1;
            tedad[59] = 2;
            tedad[60] = 3;
            tedad[61] = 1;
            tedad[62] = 2;
            tedad[63] = 3;
            tedad[64] = 1;
            tedad[65] = 2;
            tedad[66] = 3;
            tedad[67] = 1;
            tedad[68] = 2;
            tedad[69] = 3;
            tedad[70] = 1;
            tedad[71] = 2;
            tedad[72] = 3;
            tedad[73] = 1;
            tedad[74] = 2;
            tedad[75] = 3;
            tedad[76] = 1;
            tedad[77] = 2;
            tedad[78] = 3;
            tedad[79] = 1;
            tedad[80] = 2;
            tedad[81] = 3;
            //
            //halat
            halat[1] = 1;
            halat[2] = 1;
            halat[3] = 1;
            halat[4] = 2;
            halat[5] = 2;
            halat[6] = 2;
            halat[7] = 3;
            halat[8] = 3;
            halat[9] = 3;
            halat[10] = 1;
            halat[11] = 1;
            halat[12] = 1;
            halat[13] = 2;
            halat[14] = 2;
            halat[15] = 2;
            halat[16] = 3;
            halat[17] = 3;
            halat[18] = 3;
            halat[19] = 1;
            halat[20] = 1;
            halat[21] = 1;
            halat[22] = 2;
            halat[23] = 2;
            halat[24] = 2;
            halat[25] = 3;
            halat[26] = 3;
            halat[27] = 3;
            halat[28] = 1;
            halat[29] = 1;
            halat[30] = 1;
            halat[31] = 2;
            halat[32] = 2;
            halat[33] = 2;
            halat[34] = 3;
            halat[35] = 3;
            halat[36] = 3;
            halat[37] = 1;
            halat[38] = 1;
            halat[39] = 1;
            halat[40] = 2;
            halat[41] = 2;
            halat[42] = 2;
            halat[43] = 3;
            halat[44] = 3;
            halat[45] = 3;
            halat[46] = 1;
            halat[47] = 1;
            halat[48] = 1;
            halat[49] = 2;
            halat[50] = 2;
            halat[51] = 2;
            halat[52] = 3;
            halat[53] = 3;
            halat[54] = 3;
            halat[55] = 1;
            halat[56] = 1;
            halat[57] = 1;
            halat[58] = 2;
            halat[59] = 2;
            halat[60] = 2;
            halat[61] = 3;
            halat[62] = 3;
            halat[63] = 3;
            halat[64] = 1;
            halat[65] = 1;
            halat[66] = 1;
            halat[67] = 2;
            halat[68] = 2;
            halat[69] = 2;
            halat[70] = 3;
            halat[71] = 3;
            halat[72] = 3;
            halat[73] = 1;
            halat[74] = 1;
            halat[75] = 1;
            halat[76] = 2;
            halat[77] = 2;
            halat[78] = 2;
            halat[79] = 3;
            halat[80] = 3;
            halat[81] = 3;
            //
            //shekl
            shekl[1] = 1;
            shekl[2] = 1;
            shekl[3] = 1;
            shekl[4] = 1;
            shekl[5] = 1;
            shekl[6] = 1;
            shekl[7] = 1;
            shekl[8] = 1;
            shekl[9] = 1;
            shekl[10] = 1;
            shekl[11] = 1;
            shekl[12] = 1;
            shekl[13] = 1;
            shekl[14] = 1;
            shekl[15] = 1;
            shekl[16] = 1;
            shekl[17] = 1;
            shekl[18] = 1;
            shekl[19] = 1;
            shekl[20] = 1;
            shekl[21] = 1;
            shekl[22] = 1;
            shekl[23] = 1;
            shekl[24] = 1;
            shekl[25] = 1;
            shekl[26] = 1;
            shekl[27] = 1;
            shekl[28] = 2;
            shekl[29] = 2;
            shekl[30] = 2;
            shekl[31] = 2;
            shekl[32] = 2;
            shekl[33] = 2;
            shekl[34] = 2;
            shekl[35] = 2;
            shekl[36] = 2;
            shekl[37] = 2;
            shekl[38] = 2;
            shekl[39] = 2;
            shekl[40] = 2;
            shekl[41] = 2;
            shekl[42] = 2;
            shekl[43] = 2;
            shekl[44] = 2;
            shekl[45] = 2;
            shekl[46] = 2;
            shekl[47] = 2;
            shekl[48] = 2;
            shekl[49] = 2;
            shekl[50] = 2;
            shekl[51] = 2;
            shekl[52] = 2;
            shekl[53] = 2;
            shekl[54] = 2;
            shekl[55] = 3;
            shekl[56] = 3;
            shekl[57] = 3;
            shekl[58] = 3;
            shekl[59] = 3;
            shekl[60] = 3;
            shekl[61] = 3;
            shekl[62] = 3;
            shekl[63] = 3;
            shekl[64] = 3;
            shekl[65] = 3;
            shekl[66] = 3;
            shekl[67] = 3;
            shekl[68] = 3;
            shekl[69] = 3;
            shekl[70] = 3;
            shekl[71] = 3;
            shekl[72] = 3;
            shekl[73] = 3;
            shekl[74] = 3;
            shekl[75] = 3;
            shekl[76] = 3;
            shekl[77] = 3;
            shekl[78] = 3;
            shekl[79] = 3;
            shekl[80] = 3;
            shekl[81] = 3;
            //
            cod[int.Parse(color[1].ToString() + tedad[1].ToString() + halat[1].ToString() + shekl[1].ToString())] = 1;
            cod[int.Parse(color[2].ToString() + tedad[2].ToString() + halat[2].ToString() + shekl[2].ToString())] = 2;
            cod[int.Parse(color[3].ToString() + tedad[3].ToString() + halat[3].ToString() + shekl[3].ToString())] = 3;
            cod[int.Parse(color[4].ToString() + tedad[4].ToString() + halat[4].ToString() + shekl[4].ToString())] = 4;
            cod[int.Parse(color[5].ToString() + tedad[5].ToString() + halat[5].ToString() + shekl[5].ToString())] = 5;
            cod[int.Parse(color[6].ToString() + tedad[6].ToString() + halat[6].ToString() + shekl[6].ToString())] = 6;
            cod[int.Parse(color[7].ToString() + tedad[7].ToString() + halat[7].ToString() + shekl[7].ToString())] = 7;
            cod[int.Parse(color[8].ToString() + tedad[8].ToString() + halat[8].ToString() + shekl[8].ToString())] = 8;
            cod[int.Parse(color[9].ToString() + tedad[9].ToString() + halat[9].ToString() + shekl[9].ToString())] = 9;
            cod[int.Parse(color[10].ToString() + tedad[10].ToString() + halat[10].ToString() + shekl[10].ToString())] = 10;
            cod[int.Parse(color[11].ToString() + tedad[11].ToString() + halat[11].ToString() + shekl[11].ToString())] = 11;
            cod[int.Parse(color[12].ToString() + tedad[12].ToString() + halat[12].ToString() + shekl[12].ToString())] = 12;
            cod[int.Parse(color[13].ToString() + tedad[13].ToString() + halat[13].ToString() + shekl[13].ToString())] = 13;
            cod[int.Parse(color[14].ToString() + tedad[14].ToString() + halat[14].ToString() + shekl[14].ToString())] = 14;
            cod[int.Parse(color[15].ToString() + tedad[15].ToString() + halat[15].ToString() + shekl[15].ToString())] = 15;
            cod[int.Parse(color[16].ToString() + tedad[16].ToString() + halat[16].ToString() + shekl[16].ToString())] = 16;
            cod[int.Parse(color[17].ToString() + tedad[17].ToString() + halat[17].ToString() + shekl[17].ToString())] = 17;
            cod[int.Parse(color[18].ToString() + tedad[18].ToString() + halat[18].ToString() + shekl[18].ToString())] = 18;
            cod[int.Parse(color[19].ToString() + tedad[19].ToString() + halat[19].ToString() + shekl[19].ToString())] = 19;
            cod[int.Parse(color[20].ToString() + tedad[20].ToString() + halat[20].ToString() + shekl[20].ToString())] = 20;
            cod[int.Parse(color[21].ToString() + tedad[21].ToString() + halat[21].ToString() + shekl[21].ToString())] = 21;
            cod[int.Parse(color[22].ToString() + tedad[22].ToString() + halat[22].ToString() + shekl[22].ToString())] = 22;
            cod[int.Parse(color[23].ToString() + tedad[23].ToString() + halat[23].ToString() + shekl[23].ToString())] = 23;
            cod[int.Parse(color[24].ToString() + tedad[24].ToString() + halat[24].ToString() + shekl[24].ToString())] = 24;
            cod[int.Parse(color[25].ToString() + tedad[25].ToString() + halat[25].ToString() + shekl[25].ToString())] = 25;
            cod[int.Parse(color[26].ToString() + tedad[26].ToString() + halat[26].ToString() + shekl[26].ToString())] = 26;
            cod[int.Parse(color[27].ToString() + tedad[27].ToString() + halat[27].ToString() + shekl[27].ToString())] = 27;
            cod[int.Parse(color[28].ToString() + tedad[28].ToString() + halat[28].ToString() + shekl[28].ToString())] = 28;
            cod[int.Parse(color[29].ToString() + tedad[29].ToString() + halat[29].ToString() + shekl[29].ToString())] = 29;
            cod[int.Parse(color[30].ToString() + tedad[30].ToString() + halat[30].ToString() + shekl[30].ToString())] = 30;
            cod[int.Parse(color[31].ToString() + tedad[31].ToString() + halat[31].ToString() + shekl[31].ToString())] = 31;
            cod[int.Parse(color[32].ToString() + tedad[32].ToString() + halat[32].ToString() + shekl[32].ToString())] = 32;
            cod[int.Parse(color[33].ToString() + tedad[33].ToString() + halat[33].ToString() + shekl[33].ToString())] = 33;
            cod[int.Parse(color[34].ToString() + tedad[34].ToString() + halat[34].ToString() + shekl[34].ToString())] = 34;
            cod[int.Parse(color[35].ToString() + tedad[35].ToString() + halat[35].ToString() + shekl[35].ToString())] = 35;
            cod[int.Parse(color[36].ToString() + tedad[36].ToString() + halat[36].ToString() + shekl[36].ToString())] = 36;
            cod[int.Parse(color[37].ToString() + tedad[37].ToString() + halat[37].ToString() + shekl[37].ToString())] = 37;
            cod[int.Parse(color[38].ToString() + tedad[38].ToString() + halat[38].ToString() + shekl[38].ToString())] = 38;
            cod[int.Parse(color[39].ToString() + tedad[39].ToString() + halat[39].ToString() + shekl[39].ToString())] = 39;
            cod[int.Parse(color[40].ToString() + tedad[40].ToString() + halat[40].ToString() + shekl[40].ToString())] = 40;
            cod[int.Parse(color[41].ToString() + tedad[41].ToString() + halat[41].ToString() + shekl[41].ToString())] = 41;
            cod[int.Parse(color[42].ToString() + tedad[42].ToString() + halat[42].ToString() + shekl[42].ToString())] = 42;
            cod[int.Parse(color[43].ToString() + tedad[43].ToString() + halat[43].ToString() + shekl[43].ToString())] = 43;
            cod[int.Parse(color[44].ToString() + tedad[44].ToString() + halat[44].ToString() + shekl[44].ToString())] = 44;
            cod[int.Parse(color[45].ToString() + tedad[45].ToString() + halat[45].ToString() + shekl[45].ToString())] = 45;
            cod[int.Parse(color[46].ToString() + tedad[46].ToString() + halat[46].ToString() + shekl[46].ToString())] = 46;
            cod[int.Parse(color[47].ToString() + tedad[47].ToString() + halat[47].ToString() + shekl[47].ToString())] = 47;
            cod[int.Parse(color[48].ToString() + tedad[48].ToString() + halat[48].ToString() + shekl[48].ToString())] = 48;
            cod[int.Parse(color[49].ToString() + tedad[49].ToString() + halat[49].ToString() + shekl[49].ToString())] = 49;
            cod[int.Parse(color[50].ToString() + tedad[50].ToString() + halat[50].ToString() + shekl[50].ToString())] = 50;
            cod[int.Parse(color[51].ToString() + tedad[51].ToString() + halat[51].ToString() + shekl[51].ToString())] = 51;
            cod[int.Parse(color[52].ToString() + tedad[52].ToString() + halat[52].ToString() + shekl[52].ToString())] = 52;
            cod[int.Parse(color[53].ToString() + tedad[53].ToString() + halat[53].ToString() + shekl[53].ToString())] = 53;
            cod[int.Parse(color[54].ToString() + tedad[54].ToString() + halat[54].ToString() + shekl[54].ToString())] = 54;
            cod[int.Parse(color[55].ToString() + tedad[55].ToString() + halat[55].ToString() + shekl[55].ToString())] = 55;
            cod[int.Parse(color[56].ToString() + tedad[56].ToString() + halat[56].ToString() + shekl[56].ToString())] = 56;
            cod[int.Parse(color[57].ToString() + tedad[57].ToString() + halat[57].ToString() + shekl[57].ToString())] = 57;
            cod[int.Parse(color[58].ToString() + tedad[58].ToString() + halat[58].ToString() + shekl[58].ToString())] = 58;
            cod[int.Parse(color[59].ToString() + tedad[59].ToString() + halat[59].ToString() + shekl[59].ToString())] = 59;
            cod[int.Parse(color[60].ToString() + tedad[60].ToString() + halat[60].ToString() + shekl[60].ToString())] = 60;
            cod[int.Parse(color[61].ToString() + tedad[61].ToString() + halat[61].ToString() + shekl[61].ToString())] = 61;
            cod[int.Parse(color[62].ToString() + tedad[62].ToString() + halat[62].ToString() + shekl[62].ToString())] = 62;
            cod[int.Parse(color[63].ToString() + tedad[63].ToString() + halat[63].ToString() + shekl[63].ToString())] = 63;
            cod[int.Parse(color[64].ToString() + tedad[64].ToString() + halat[64].ToString() + shekl[64].ToString())] = 64;
            cod[int.Parse(color[65].ToString() + tedad[65].ToString() + halat[65].ToString() + shekl[65].ToString())] = 65;
            cod[int.Parse(color[66].ToString() + tedad[66].ToString() + halat[66].ToString() + shekl[66].ToString())] = 66;
            cod[int.Parse(color[67].ToString() + tedad[67].ToString() + halat[67].ToString() + shekl[67].ToString())] = 67;
            cod[int.Parse(color[68].ToString() + tedad[68].ToString() + halat[68].ToString() + shekl[68].ToString())] = 68;
            cod[int.Parse(color[69].ToString() + tedad[69].ToString() + halat[69].ToString() + shekl[69].ToString())] = 69;
            cod[int.Parse(color[70].ToString() + tedad[70].ToString() + halat[70].ToString() + shekl[70].ToString())] = 70;
            cod[int.Parse(color[71].ToString() + tedad[71].ToString() + halat[71].ToString() + shekl[71].ToString())] = 71;
            cod[int.Parse(color[72].ToString() + tedad[72].ToString() + halat[72].ToString() + shekl[72].ToString())] = 72;
            cod[int.Parse(color[73].ToString() + tedad[73].ToString() + halat[73].ToString() + shekl[73].ToString())] = 73;
            cod[int.Parse(color[74].ToString() + tedad[74].ToString() + halat[74].ToString() + shekl[74].ToString())] = 74;
            cod[int.Parse(color[75].ToString() + tedad[75].ToString() + halat[75].ToString() + shekl[75].ToString())] = 75;
            cod[int.Parse(color[76].ToString() + tedad[76].ToString() + halat[76].ToString() + shekl[76].ToString())] = 76;
            cod[int.Parse(color[77].ToString() + tedad[77].ToString() + halat[77].ToString() + shekl[77].ToString())] = 77;
            cod[int.Parse(color[78].ToString() + tedad[78].ToString() + halat[78].ToString() + shekl[78].ToString())] = 78;
            cod[int.Parse(color[79].ToString() + tedad[79].ToString() + halat[79].ToString() + shekl[79].ToString())] = 79;
            cod[int.Parse(color[80].ToString() + tedad[80].ToString() + halat[80].ToString() + shekl[80].ToString())] = 80;
            cod[int.Parse(color[81].ToString() + tedad[81].ToString() + halat[81].ToString() + shekl[81].ToString())] = 81;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox10.Tag = 0;
            pictureBox11.Tag = 0;
            pictureBox12.Tag = 0;
            porpic();
            //
           
        }
        private void porpic()
        {
            int rnd3 = rndimg();
            pictureBox1.Image = imageList1.Images[rnd3];
            pictureBox1.Tag = rnd3;
            rnd3 = rndimg();
            pictureBox2.Image = imageList1.Images[rnd3];
            pictureBox2.Tag = rnd3;
            rnd3 = rndimg();
            pictureBox3.Image = imageList1.Images[rnd3];
            pictureBox3.Tag = rnd3;
            rnd3 = rndimg();
            pictureBox4.Image = imageList1.Images[rnd3];
            pictureBox4.Tag = rnd3;
            rnd3 = rndimg();
            pictureBox5.Image = imageList1.Images[rnd3];
            pictureBox5.Tag = rnd3;
            rnd3 = rndimg();
            pictureBox6.Image = imageList1.Images[rnd3];
            pictureBox6.Tag = rnd3;
            rnd3 = rndimg();
            pictureBox7.Image = imageList1.Images[rnd3];
            pictureBox7.Tag = rnd3;
            rnd3 = rndimg();
            pictureBox8.Image = imageList1.Images[rnd3];
            pictureBox8.Tag = rnd3;
            rnd3 = rndimg();
            pictureBox9.Image = imageList1.Images[rnd3];
            pictureBox9.Tag = rnd3;
            secend = Convert.ToInt32(DateTime.Now.TimeOfDay.TotalSeconds);
        }
        private int rndimg()
        {
            if (kartamad.Count < 81)
            {
                Random rnd2 = new Random();
            rrr:
                int sh = rnd2.Next(1, 82);

                if (kartamad.Contains(sh) == false)
                {
                    kartamad.Add(sh);
                    return sh;
                }
                else
                {
                    goto rrr;
                }
            }
            return 0;
        }
        private void pedagor()
        {
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox2.Tag)), "pictureBox1", Convert.ToInt32(pictureBox1.Tag), "pictureBox2", Convert.ToInt32(pictureBox2.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox3.Tag)), "pictureBox1", Convert.ToInt32(pictureBox1.Tag), "pictureBox3", Convert.ToInt32(pictureBox3.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox4.Tag)), "pictureBox1", Convert.ToInt32(pictureBox1.Tag), "pictureBox4", Convert.ToInt32(pictureBox4.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox5.Tag)), "pictureBox1", Convert.ToInt32(pictureBox1.Tag), "pictureBox5", Convert.ToInt32(pictureBox5.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox6.Tag)), "pictureBox1", Convert.ToInt32(pictureBox1.Tag), "pictureBox6", Convert.ToInt32(pictureBox6.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox1", Convert.ToInt32(pictureBox1.Tag), "pictureBox7", Convert.ToInt32(pictureBox7.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox1", Convert.ToInt32(pictureBox1.Tag), "pictureBox8", Convert.ToInt32(pictureBox8.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox1", Convert.ToInt32(pictureBox1.Tag), "pictureBox9", Convert.ToInt32(pictureBox9.Tag)))
            {
                goto RR;
            }

            if (kodampic(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox3.Tag)), "pictureBox2", Convert.ToInt32(pictureBox2.Tag), "pictureBox3", Convert.ToInt32(pictureBox3.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox4.Tag)), "pictureBox2", Convert.ToInt32(pictureBox2.Tag), "pictureBox4", Convert.ToInt32(pictureBox4.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox5.Tag)), "pictureBox2", Convert.ToInt32(pictureBox2.Tag), "pictureBox5", Convert.ToInt32(pictureBox5.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox6.Tag)), "pictureBox2", Convert.ToInt32(pictureBox2.Tag), "pictureBox6", Convert.ToInt32(pictureBox6.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox2", Convert.ToInt32(pictureBox2.Tag), "pictureBox7", Convert.ToInt32(pictureBox7.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox2", Convert.ToInt32(pictureBox2.Tag), "pictureBox8", Convert.ToInt32(pictureBox8.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox2", Convert.ToInt32(pictureBox2.Tag), "pictureBox9", Convert.ToInt32(pictureBox9.Tag)))
            {
                goto RR;
            }

            if (kodampic(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox4.Tag)), "pictureBox3", Convert.ToInt32(pictureBox3.Tag), "pictureBox4", Convert.ToInt32(pictureBox4.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox5.Tag)), "pictureBox3", Convert.ToInt32(pictureBox3.Tag), "pictureBox5", Convert.ToInt32(pictureBox5.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox6.Tag)), "pictureBox3", Convert.ToInt32(pictureBox3.Tag), "pictureBox6", Convert.ToInt32(pictureBox6.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox3", Convert.ToInt32(pictureBox3.Tag), "pictureBox7", Convert.ToInt32(pictureBox7.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox3", Convert.ToInt32(pictureBox3.Tag), "pictureBox8", Convert.ToInt32(pictureBox8.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox3", Convert.ToInt32(pictureBox3.Tag), "pictureBox9", Convert.ToInt32(pictureBox9.Tag)))
            {
                goto RR;
            }

            if (kodampic(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox5.Tag)), "pictureBox4", Convert.ToInt32(pictureBox4.Tag), "pictureBox5", Convert.ToInt32(pictureBox5.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox6.Tag)), "pictureBox4", Convert.ToInt32(pictureBox4.Tag), "pictureBox6", Convert.ToInt32(pictureBox6.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox4", Convert.ToInt32(pictureBox4.Tag), "pictureBox7", Convert.ToInt32(pictureBox7.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox4", Convert.ToInt32(pictureBox4.Tag), "pictureBox8", Convert.ToInt32(pictureBox8.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox4", Convert.ToInt32(pictureBox4.Tag), "pictureBox9", Convert.ToInt32(pictureBox9.Tag)))
            {
                goto RR;
            }

            if (kodampic(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox6.Tag)), "pictureBox5", Convert.ToInt32(pictureBox5.Tag), "pictureBox6", Convert.ToInt32(pictureBox6.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox5", Convert.ToInt32(pictureBox5.Tag), "pictureBox7", Convert.ToInt32(pictureBox7.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox5", Convert.ToInt32(pictureBox5.Tag), "pictureBox8", Convert.ToInt32(pictureBox8.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox5", Convert.ToInt32(pictureBox5.Tag), "pictureBox9", Convert.ToInt32(pictureBox9.Tag)))
            {
                goto RR;
            }

            if (kodampic(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox6", Convert.ToInt32(pictureBox6.Tag), "pictureBox7", Convert.ToInt32(pictureBox7.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox6", Convert.ToInt32(pictureBox6.Tag), "pictureBox8", Convert.ToInt32(pictureBox8.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox6", Convert.ToInt32(pictureBox6.Tag), "pictureBox9", Convert.ToInt32(pictureBox9.Tag)))
            {
                goto RR;
            }

            if (kodampic(kartsevom(Convert.ToInt32(pictureBox7.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox7", Convert.ToInt32(pictureBox7.Tag), "pictureBox8", Convert.ToInt32(pictureBox8.Tag)))
            {
                goto RR;
            }
            if (kodampic(kartsevom(Convert.ToInt32(pictureBox7.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox7", Convert.ToInt32(pictureBox7.Tag), "pictureBox9", Convert.ToInt32(pictureBox9.Tag)))
            {
                goto RR;
            }

            if (kodampic(kartsevom(Convert.ToInt32(pictureBox8.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox8", Convert.ToInt32(pictureBox8.Tag), "pictureBox9", Convert.ToInt32(pictureBox9.Tag)))
            {
                goto RR;
            }


            if (pictureBox10.Image != null && pictureBox11.Image != null && pictureBox12.Image != null)
            {
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox2", Convert.ToInt32(pictureBox2.Tag), "pictureBox10", Convert.ToInt32(pictureBox10.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox2", Convert.ToInt32(pictureBox2.Tag), "pictureBox11", Convert.ToInt32(pictureBox11.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox2", Convert.ToInt32(pictureBox2.Tag), "pictureBox12", Convert.ToInt32(pictureBox12.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox3", Convert.ToInt32(pictureBox3.Tag), "pictureBox10", Convert.ToInt32(pictureBox10.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox3", Convert.ToInt32(pictureBox3.Tag), "pictureBox11", Convert.ToInt32(pictureBox11.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox3", Convert.ToInt32(pictureBox3.Tag), "pictureBox12", Convert.ToInt32(pictureBox12.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox5", Convert.ToInt32(pictureBox5.Tag), "pictureBox10", Convert.ToInt32(pictureBox10.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox5", Convert.ToInt32(pictureBox5.Tag), "pictureBox11", Convert.ToInt32(pictureBox11.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox5", Convert.ToInt32(pictureBox5.Tag), "pictureBox12", Convert.ToInt32(pictureBox12.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox4", Convert.ToInt32(pictureBox4.Tag), "pictureBox10", Convert.ToInt32(pictureBox10.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox4", Convert.ToInt32(pictureBox4.Tag), "pictureBox11", Convert.ToInt32(pictureBox11.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox4", Convert.ToInt32(pictureBox4.Tag), "pictureBox12", Convert.ToInt32(pictureBox12.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox6", Convert.ToInt32(pictureBox6.Tag), "pictureBox10", Convert.ToInt32(pictureBox10.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox6", Convert.ToInt32(pictureBox6.Tag), "pictureBox11", Convert.ToInt32(pictureBox11.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox6", Convert.ToInt32(pictureBox6.Tag), "pictureBox12", Convert.ToInt32(pictureBox12.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox7.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox7", Convert.ToInt32(pictureBox7.Tag), "pictureBox10", Convert.ToInt32(pictureBox10.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox7.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox7", Convert.ToInt32(pictureBox7.Tag), "pictureBox11", Convert.ToInt32(pictureBox11.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox7.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox7", Convert.ToInt32(pictureBox7.Tag), "pictureBox12", Convert.ToInt32(pictureBox12.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox1", Convert.ToInt32(pictureBox1.Tag), "pictureBox10", Convert.ToInt32(pictureBox10.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox1", Convert.ToInt32(pictureBox1.Tag), "pictureBox11", Convert.ToInt32(pictureBox11.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox1", Convert.ToInt32(pictureBox1.Tag), "pictureBox12", Convert.ToInt32(pictureBox12.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox8.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox8", Convert.ToInt32(pictureBox8.Tag), "pictureBox10", Convert.ToInt32(pictureBox10.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox8.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox8", Convert.ToInt32(pictureBox8.Tag), "pictureBox11", Convert.ToInt32(pictureBox11.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox8.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox8", Convert.ToInt32(pictureBox8.Tag), "pictureBox12", Convert.ToInt32(pictureBox12.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox9.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox9", Convert.ToInt32(pictureBox9.Tag), "pictureBox10", Convert.ToInt32(pictureBox10.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox9.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox9", Convert.ToInt32(pictureBox9.Tag), "pictureBox11", Convert.ToInt32(pictureBox11.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox9.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox9", Convert.ToInt32(pictureBox9.Tag), "pictureBox12", Convert.ToInt32(pictureBox12.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox10.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox10", Convert.ToInt32(pictureBox10.Tag), "pictureBox11", Convert.ToInt32(pictureBox11.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox10.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox10", Convert.ToInt32(pictureBox10.Tag), "pictureBox12", Convert.ToInt32(pictureBox12.Tag)))
                {
                    goto RR;
                }
                if (kodampic(kartsevom(Convert.ToInt32(pictureBox11.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox11", Convert.ToInt32(pictureBox11.Tag), "pictureBox12", Convert.ToInt32(pictureBox12.Tag)))
                {
                    goto RR;
                }
            }
        RR:
            ;
        }
        private bool kodampic(int on3, string pic01, int on1, string pic02, int on2)
        {
            if (on3 != 0)
            {
                if (Convert.ToInt32(pictureBox1.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox1.Tag), "pictureBox1");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox2.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox2.Tag), "pictureBox2");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox3.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox3.Tag), "pictureBox3");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox4.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox4.Tag), "pictureBox4");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox5.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox5.Tag), "pictureBox5");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox6.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox6.Tag), "pictureBox6");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox7.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox7.Tag), "pictureBox7");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox8.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox8.Tag), "pictureBox8");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox9.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox9.Tag), "pictureBox9");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox10.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox10.Tag), "pictureBox10");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox11.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox11.Tag), "pictureBox11");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox12.Tag) == on3)
                {
                    shokart2(Convert.ToInt32(pictureBox12.Tag), "pictureBox12");
                    shokart2(on1, pic01);
                    shokart2(on2, pic02);
                    return true;
                }
            }
                return false;
            
        }
        private int tashkhisadadsevom(int a, int b)
        {
            if (a == b)
                return a;
            else if (a + b == 3)
                return 3;
            else if (a + b == 4)
                return 2;
            else if (a + b == 5)
                return 1;
            return 0;
        }
        private int kartsevom(int on1, int on2)
        {
            string code = "";
            code += tashkhisadadsevom(color[on1], color[on2]).ToString();
            code += tashkhisadadsevom(tedad[on1], tedad[on2]).ToString();
            code += tashkhisadadsevom(halat[on1], halat[on2]).ToString();
            code += tashkhisadadsevom(shekl[on1], shekl[on2]).ToString();
            return cod[int.Parse(code)];
        }

        private void shokart(int sho, string pic,int user)
        {
            if (shim1 == 0)
            {
                shim1 = sho;
                pic1 = pic;

            }
            else if (shim2 == 0)
            {
                if (sho != shim1)
                {
                    shim2 = sho;
                    pic2 = pic;
                }
            }
            else if (shim3 == 0 && sho != shim1 && sho != shim2)
            {
                shim3 = sho;
                pic3 = pic;
                int rnd4;
                if (gorhast(shim1, shim2, shim3) == true)
                {
                    if (user == 1)
                    {
                        if (int.Parse(label1.Text) >= 0)
                        {
                            nafaraval.Add(shim1);
                            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
                        }
                        else
                        {
                            nafardovom.Add(shim1);
                            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();


                        }
                        if (int.Parse(label1.Text) >= 0)
                        {
                            nafaraval.Add(shim2);
                            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
                        }
                        else
                        {
                            nafardovom.Add(shim2);
                            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();

                        }
                        if (int.Parse(label1.Text) >= 0)
                        {
                            nafaraval.Add(shim3);
                            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
                        }
                        else
                        {
                            nafardovom.Add(shim3);
                            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();

                        }
                    }
                    else
                    {
                        if (int.Parse(label2.Text) >= 0)
                        {
                            nafardovom.Add(shim1);
                            label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                        }
                        else
                        {
                            nafaraval.Add(shim1);
                            label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();


                        }
                        if (int.Parse(label2.Text) >= 0)
                        {
                            nafardovom.Add(shim2);
                            label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                        }
                        else
                        {
                            nafaraval.Add(shim2);
                            label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();

                        }
                        if (int.Parse(label2.Text) >= 0)
                        {
                            nafardovom.Add(shim3);
                            label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                        }
                        else
                        {
                            nafaraval.Add(shim3);
                            label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();

                        }
                    }
                    shim1 = 0;
                    shim2 = 0;
                    shim3 = 0;
                    visfa();
                    if (pic1 == "pictureBox10" || pic2 == "pictureBox10" || pic3 == "pictureBox10")
                    {

                        pictureBox10.Image = null;
                        pictureBox10.Tag = 0;
                    }
                    if (pic1 == "pictureBox11" || pic2 == "pictureBox11" || pic3 == "pictureBox11")
                    {

                        pictureBox11.Image = null;
                        pictureBox11.Tag = 0;
                    }
                    if (pic1 == "pictureBox12" || pic2 == "pictureBox12" || pic3 == "pictureBox12")
                    {

                        pictureBox12.Image = null;
                        pictureBox12.Tag = 0;
                    }
                    if (pic1 == "pictureBox1" || pic2 == "pictureBox1" || pic3 == "pictureBox1")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox1.Image = pictureBox10.Image;
                            pictureBox1.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox1.Image = pictureBox11.Image;
                            pictureBox1.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox1.Image = pictureBox12.Image;
                            pictureBox1.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox1.Image = imageList1.Images[rnd4];
                            pictureBox1.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox1.Image = null;
                            pictureBox1.Tag = 0;
                        }
                    aa:
                        ;
                    }
                    if (pic1 == "pictureBox2" || pic2 == "pictureBox2" || pic3 == "pictureBox2")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox2.Image = pictureBox10.Image;
                            pictureBox2.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox2.Image = pictureBox11.Image;
                            pictureBox2.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox2.Image = pictureBox12.Image;
                            pictureBox2.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox2.Image = imageList1.Images[rnd4];
                            pictureBox2.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox2.Image = null;
                            pictureBox2.Tag = 0;
                        }
                    aa:
                        ;
                    }
                    if (pic1 == "pictureBox3" || pic2 == "pictureBox3" || pic3 == "pictureBox3")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox3.Image = pictureBox10.Image;
                            pictureBox3.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox3.Image = pictureBox11.Image;
                            pictureBox3.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox3.Image = pictureBox12.Image;
                            pictureBox3.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox3.Image = imageList1.Images[rnd4];
                            pictureBox3.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox3.Image = null;
                            pictureBox3.Tag = 0;
                        }
                    aa:
                        ;

                    }
                    if (pic1 == "pictureBox4" || pic2 == "pictureBox4" || pic3 == "pictureBox4")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox4.Image = pictureBox10.Image;
                            pictureBox4.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox4.Image = pictureBox11.Image;
                            pictureBox4.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox4.Image = pictureBox12.Image;
                            pictureBox4.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox4.Image = imageList1.Images[rnd4];
                            pictureBox4.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox4.Image = null;
                            pictureBox4.Tag = 0;
                        }
                    aa:
                        ;
                    }
                    if (pic1 == "pictureBox5" || pic2 == "pictureBox5" || pic3 == "pictureBox5")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox5.Image = pictureBox10.Image;
                            pictureBox5.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox5.Image = pictureBox11.Image;
                            pictureBox5.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox5.Image = pictureBox12.Image;
                            pictureBox5.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox5.Image = imageList1.Images[rnd4];
                            pictureBox5.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox5.Image = null;
                            pictureBox5.Tag = 0;
                        }
                    aa:
                        ;
                    }
                    if (pic1 == "pictureBox6" || pic2 == "pictureBox6" || pic3 == "pictureBox6")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox6.Image = pictureBox10.Image;
                            pictureBox6.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox6.Image = pictureBox11.Image;
                            pictureBox6.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox6.Image = pictureBox12.Image;
                            pictureBox6.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox6.Image = imageList1.Images[rnd4];
                            pictureBox6.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox6.Image = null;
                            pictureBox6.Tag = 0;
                        }
                    aa:
                        ;
                    }
                    if (pic1 == "pictureBox7" || pic2 == "pictureBox7" || pic3 == "pictureBox7")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox7.Image = pictureBox10.Image;
                            pictureBox7.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox7.Image = pictureBox11.Image;
                            pictureBox7.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox7.Image = pictureBox12.Image;
                            pictureBox7.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox7.Image = imageList1.Images[rnd4];
                            pictureBox7.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox7.Image = null;
                            pictureBox7.Tag = 0;
                        }
                    aa:
                        ;
                    }
                    if (pic1 == "pictureBox8" || pic2 == "pictureBox8" || pic3 == "pictureBox8")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox8.Image = pictureBox10.Image;
                            pictureBox8.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox8.Image = pictureBox11.Image;
                            pictureBox8.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox8.Image = pictureBox12.Image;
                            pictureBox8.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox8.Image = imageList1.Images[rnd4];
                            pictureBox8.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox8.Image = null;
                            pictureBox8.Tag = 0;
                        }
                    aa:
                        ;
                    }
                    if (pic1 == "pictureBox9" || pic2 == "pictureBox9" || pic3 == "pictureBox9")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox9.Image = pictureBox10.Image;
                            pictureBox9.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox9.Image = pictureBox11.Image;
                            pictureBox9.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox9.Image = pictureBox12.Image;
                            pictureBox9.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox9.Image = imageList1.Images[rnd4];
                            pictureBox9.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox9.Image = null;
                            pictureBox9.Tag = 0;
                        }
                    aa:
                        ;
                    }
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                }
                else
                {
                    if (user == 1)
                    {
                        label1.Text = (Convert.ToInt32(label1.Text) - 1).ToString();

                        label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                        if (nafaraval.Count != 0)
                        {
                            nafardovom.Add(nafaraval[0]);
                            nafaraval.Remove(nafaraval[0]);
                        }
                    }
                    else
                    {
                        label2.Text = (Convert.ToInt32(label2.Text) - 1).ToString();

                        label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
                        if (nafardovom.Count != 0)
                        {
                            nafaraval.Add(nafardovom[0]);
                            nafardovom.Remove(nafardovom[0]);
                        }
                    }
                    shim1 = 0;
                    shim2 = 0;
                    shim3 = 0;
                    visfa();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (shim1 != 0 && shim3 == 0)
            {
                label1.Text = (Convert.ToInt32(label1.Text) - 1).ToString();
                label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                if (nafaraval.Count != 0)
                {
                    nafardovom.Add(nafaraval[0]);
                    nafaraval.Remove(nafaraval[0]);
                }
                shim1 = 0;
                shim2 = 0;
                shim3 = 0;
                timer1.Enabled = false;
                visfa();
            }
        }
        private void visfa()
        {
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(timer2.Tag) != 1)
            {
                if (pictureBox10.Image == null && pictureBox11.Image == null && pictureBox12.Image == null)
                {

                    if (kartamad.Count < 81)
                    {
                        int rnd5;
                        rnd5 = rndimg();
                        pictureBox10.Image = imageList1.Images[rnd5];
                        pictureBox10.Tag = rnd5;
                        rnd5 = rndimg();
                        pictureBox11.Image = imageList1.Images[rnd5];
                        pictureBox11.Tag = rnd5;
                        rnd5 = rndimg();
                        pictureBox12.Image = imageList1.Images[rnd5];
                        pictureBox12.Tag = rnd5;
                        pictureBox10.Visible = true;
                        pictureBox11.Visible = true;
                        pictureBox12.Visible = true;
                    }
                    else
                    {
                        timer2.Tag = 1;
                        timer4.Enabled = false;
                        timer5.Enabled = false;
                        timer1.Enabled = false;
                        visfa();
                        click = false;
                        if (int.Parse(label1.Text) > int.Parse(label2.Text))
                        {
                            MessageBox.Show("User1 Win", "", MessageBoxButtons.OK
                                , MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
                        }
                        else if (int.Parse(label1.Text) == int.Parse(label2.Text))
                        {
                            MessageBox.Show("User1 and User2 Win", "", MessageBoxButtons.OK
                                , MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
                        }
                        else
                        {

                            MessageBox.Show("User2 Win", "", MessageBoxButtons.OK
                             , MessageBoxIcon.Information,
                             MessageBoxDefaultButton.Button1);
                        }

                    }
                }
                else
                {
                    kartamad.Remove(pictureBox10.Tag);
                    kartamad.Remove(pictureBox11.Tag);
                    kartamad.Remove(pictureBox12.Tag);
                    int rnd6;
                    rnd6 = rndimg();
                    pictureBox10.Image = imageList1.Images[rnd6];
                    pictureBox10.Tag = rnd6;
                    rnd6 = rndimg();
                    pictureBox11.Image = imageList1.Images[rnd6];
                    pictureBox11.Tag = rnd6;
                    rnd6 = rndimg();
                    pictureBox12.Image = imageList1.Images[rnd6];
                    pictureBox12.Tag = rnd6;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button.ToString() == "Right")
            //{
            //    pictureBox1_Click(sender, e);
            //}
            //else
            //{

            //}
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
       /*     if (nafaraval.Count != 0)
            {*/
                
                if (kartha < nafaraval.Count)
                {
                    picuser1.Image = imageList1.Images[Convert.ToInt32(nafaraval[kartha])];
                }
                else
                {
                    picuser1.Image = null;
                }
                if (kartha+1 < nafaraval .Count )
                {
                    picuser2.Image = imageList1.Images[Convert.ToInt32(nafaraval[kartha + 1])];
                }
                else
                {
                    picuser2.Image = null;
                }
                if (kartha+2 < nafaraval .Count )
                {
                    picuser3.Image = imageList1.Images[Convert.ToInt32(nafaraval[kartha + 2])];
                }
                else
                {
                    picuser3.Image = null;
                }
                    kartha += 3;
                if (kartha > nafaraval.Count - 1)
                    kartha = 0;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer3.Enabled = true;
            }
            else
            {
                timer3.Enabled = false;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int da = ((int)((Convert.ToInt32(DateTime.Now.TimeOfDay.TotalSeconds) - secend) / 60));
            int sec = (Convert.ToInt32(DateTime.Now.TimeOfDay.TotalSeconds) - secend) - (da * 60);
            toolStripStatusLabel2.Text = "Time = " +
               da.ToString() + ":" + sec.ToString();
            this.button1.Focus();
            if (da >= (int)numericUpDown1.Value && sec >= (int)numericUpDown2.Value)
            {
                timer10.Enabled = true;
            }
            
            
        }
        private void shokart2(int sho, string pic)
        {
            if (shim11 == 0)
            {
                shim11 = sho;
                pic11 = pic;

            }
            else if (shim22 == 0)
            {
                if (sho != shim1)
                {
                    shim22 = sho;
                    pic22 = pic;
                }
            }
            else if (shim33 == 0 && sho != shim11 && sho != shim22)
            {
                shim33 = sho;
                pic33 = pic;
                int rnd4;
                if (gorhast(shim11, shim22, shim33) == true)
                {
                    if (int.Parse(label2.Text) >= 0)
                    {
                        nafardovom.Add(shim11);
                        label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                    }
                    else
                    {
                        nafaraval.Add(shim11);
                        label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                    }
                    if (int.Parse(label2.Text) >= 0)
                    {
                        nafardovom.Add(shim22);
                        label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                    }
                    else
                    {
                        nafaraval.Add(shim22);
                        label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                    }
                    if (int.Parse(label2.Text) >= 0)
                    {
                        nafardovom.Add(shim33);
                        label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                    }
                    else
                    {
                        nafaraval.Add(shim33);
                        label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                    }

                    shim11 = 0;
                    shim22 = 0;
                    shim33 = 0;
                    if (pic11 == "pictureBox10" || pic22 == "pictureBox10" || pic33 == "pictureBox10")
                    {

                        pictureBox10.Image = null;
                        pictureBox10.Tag = 0;
                    }
                    if (pic11 == "pictureBox11" || pic22 == "pictureBox11" || pic33 == "pictureBox11")
                    {

                        pictureBox11.Image = null;
                        pictureBox11.Tag = 0;
                    }
                    if (pic11 == "pictureBox12" || pic22 == "pictureBox12" || pic33 == "pictureBox12")
                    {

                        pictureBox12.Image = null;
                        pictureBox12.Tag = 0;
                    }
                    if (pic11 == "pictureBox1" || pic22 == "pictureBox1" || pic33 == "pictureBox1")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox1.Image = pictureBox10.Image;
                            pictureBox1.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox1.Image = pictureBox11.Image;
                            pictureBox1.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox1.Image = pictureBox12.Image;
                            pictureBox1.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox1.Image = imageList1.Images[rnd4];
                            pictureBox1.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox1.Image = null;
                            pictureBox1.Tag = 0;
                            com = false;
                        }
                    aa:
                        ;
                    }
                    if (pic11 == "pictureBox2" || pic22 == "pictureBox2" || pic33 == "pictureBox2")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox2.Image = pictureBox10.Image;
                            pictureBox2.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox2.Image = pictureBox11.Image;
                            pictureBox2.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox2.Image = pictureBox12.Image;
                            pictureBox2.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox2.Image = imageList1.Images[rnd4];
                            pictureBox2.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox2.Image = null;
                            pictureBox2.Tag = 0;
                            com = false;
                        }
                    aa:
                        ;
                    }
                    if (pic11 == "pictureBox3" || pic22 == "pictureBox3" || pic33 == "pictureBox3")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox3.Image = pictureBox10.Image;
                            pictureBox3.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox3.Image = pictureBox11.Image;
                            pictureBox3.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox3.Image = pictureBox12.Image;
                            pictureBox3.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox3.Image = imageList1.Images[rnd4];
                            pictureBox3.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox3.Image = null;
                            pictureBox3.Tag = 0;
                            com = false;
                        }
                    aa:
                        ;

                    }
                    if (pic11 == "pictureBox4" || pic22 == "pictureBox4" || pic33 == "pictureBox4")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox4.Image = pictureBox10.Image;
                            pictureBox4.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox4.Image = pictureBox11.Image;
                            pictureBox4.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox4.Image = pictureBox12.Image;
                            pictureBox4.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox4.Image = imageList1.Images[rnd4];
                            pictureBox4.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox4.Image = null;
                            pictureBox4.Tag = 0;
                            com = false;
                        }
                    aa:
                        ;
                    }
                    if (pic11 == "pictureBox5" || pic22 == "pictureBox5" || pic33 == "pictureBox5")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox5.Image = pictureBox10.Image;
                            pictureBox5.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox5.Image = pictureBox11.Image;
                            pictureBox5.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox5.Image = pictureBox12.Image;
                            pictureBox5.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox5.Image = imageList1.Images[rnd4];
                            pictureBox5.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox5.Image = null;
                            pictureBox5.Tag = 0;
                            com = false;
                        }
                    aa:
                        ;
                    }
                    if (pic11 == "pictureBox6" || pic22 == "pictureBox6" || pic33 == "pictureBox6")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox6.Image = pictureBox10.Image;
                            pictureBox6.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox6.Image = pictureBox11.Image;
                            pictureBox6.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox6.Image = pictureBox12.Image;
                            pictureBox6.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox6.Image = imageList1.Images[rnd4];
                            pictureBox6.Tag = rnd4;
                  
                        }
                        else
                        {
                            pictureBox6.Image = null;
                            pictureBox6.Tag = 0;
                            com = false;
                        }
                    aa:
                        ;
                    }
                    if (pic11 == "pictureBox7" || pic22 == "pictureBox7" || pic33 == "pictureBox7")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox7.Image = pictureBox10.Image;
                            pictureBox7.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox7.Image = pictureBox11.Image;
                            pictureBox7.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox7.Image = pictureBox12.Image;
                            pictureBox7.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox7.Image = imageList1.Images[rnd4];
                            pictureBox7.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox7.Image = null;
                            pictureBox7.Tag = 0;
                            com = false;
                        }
                    aa:
                        ;
                    }
                    if (pic11 == "pictureBox8" || pic22 == "pictureBox8" || pic33 == "pictureBox8")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox8.Image = pictureBox10.Image;
                            pictureBox8.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox8.Image = pictureBox11.Image;
                            pictureBox8.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox8.Image = pictureBox12.Image;
                            pictureBox8.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox8.Image = imageList1.Images[rnd4];
                            pictureBox8.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox8.Image = null;
                            pictureBox8.Tag = 0;
                            com = false;
                        }
                    aa:
                        ;
                    }
                    if (pic11 == "pictureBox9" || pic22 == "pictureBox9" || pic33 == "pictureBox9")
                    {
                        if (pictureBox10.Image != null)
                        {
                            pictureBox9.Image = pictureBox10.Image;
                            pictureBox9.Tag = pictureBox10.Tag;
                            pictureBox10.Image = null;
                            pictureBox10.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox11.Image != null)
                        {
                            pictureBox9.Image = pictureBox11.Image;
                            pictureBox9.Tag = pictureBox11.Tag;
                            pictureBox11.Image = null;
                            pictureBox11.Tag = 0;
                            goto aa;
                        }
                        if (pictureBox12.Image != null)
                        {
                            pictureBox9.Image = pictureBox12.Image;
                            pictureBox9.Tag = pictureBox12.Tag;
                            pictureBox12.Image = null;
                            pictureBox12.Tag = 0;
                            goto aa;
                        }
                        if (kartamad.Count < 81)
                        {
                            rnd4 = rndimg();
                            pictureBox9.Image = imageList1.Images[rnd4];
                            pictureBox9.Tag = rnd4;
                        }
                        else
                        {
                            pictureBox9.Image = null;
                            pictureBox9.Tag = 0;
                            com = false;
                        }
                    aa:
                        ;
                    }
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                }
                else
                {
                    label2.Text = (Convert.ToInt32(label2.Text) - 1).ToString();

                    label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
                    if (nafardovom.Count != 0)
                    {
                        nafaraval.Add(nafardovom[0]);
                        nafardovom.Remove(nafardovom[0]);
                    }
                }
                shim11 = 0;
                shim22 = 0;
                shim33 = 0;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (com == true)
            {
                pedagor();
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            /*if (nafardovom.Count != 0)
            {*/

                if (kartha2 < nafardovom.Count)
                {
                    pu1.Image = imageList1.Images[Convert.ToInt32(nafardovom[kartha2])];
                }
                else
                {
                    pu1.Image = null;
                }
                if (kartha2 + 1 < nafardovom.Count)
                {
                    pu2.Image = imageList1.Images[Convert.ToInt32(nafardovom[kartha2 + 1])];
                }
                else
                {
                    pu2.Image = null;
                }
                if (kartha2+2 < nafardovom.Count)
                {
                    pu3.Image = imageList1.Images[Convert.ToInt32(nafardovom[kartha2 + 2])];
                }
                else
                {
                    pu3.Image = null;
                }
                    kartha2 += 3;
                if (kartha2 > nafardovom.Count - 1)
                    kartha2 = 0;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                timer6.Enabled = true;
            }
            else
            {
                timer6.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                timer5.Enabled = true;
            }
            else
            {
                timer5.Enabled = false;
            }
        }

        private void Hard_CheckedChanged(object sender, EventArgs e)
        {
            if (Hard.Checked)
                timer5.Interval = 4000;
        }

        private void Medium_CheckedChanged(object sender, EventArgs e)
        {
            if (Medium.Checked)
                timer5.Interval = 9000;
        }

        private void Easy_CheckedChanged(object sender, EventArgs e)
        {
            if (Easy.Checked)
                timer5.Interval = 14000;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Width += 2;
            pictureBox1.Height += 2;
            pictureBox1.Left += 2;
            pictureBox2.Width += 2;
            pictureBox2.Height += 2;
            pictureBox2.Left += 2;
            pictureBox3.Width += 2;
            pictureBox3.Height += 2;
            pictureBox3.Left += 2;
            pictureBox4.Width += 2;
            pictureBox4.Height += 2;
            pictureBox4.Left += 2;
            pictureBox5.Width += 2;
            pictureBox5.Height += 2;
            pictureBox5.Left += 2;
            pictureBox6.Width += 2;
            pictureBox6.Height += 2;
            pictureBox6.Left += 2;
            pictureBox7.Width += 2;
            pictureBox7.Height += 2;
            pictureBox7.Left += 2;
            pictureBox8.Width += 2;
            pictureBox8.Height += 2;
            pictureBox8.Left += 2;
            pictureBox9.Width += 2;
            pictureBox9.Height += 2;
            pictureBox9.Left += 2;
         
            if (pictureBox1.Height >= 150)
            {
                timer7.Enabled = false;
                if (checkBox3.Checked )
                timer5.Enabled = true;
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "H" && click)
            {
                pedagor2();
            }
        }
        private void pedagor2()
        {
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox2.Tag)), "pictureBox1", "pictureBox2"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox3.Tag)), "pictureBox1", "pictureBox3"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox4.Tag)), "pictureBox1", "pictureBox4"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox5.Tag)), "pictureBox1", "pictureBox5"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox6.Tag)), "pictureBox1", "pictureBox6"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox1",  "pictureBox7"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox1", "pictureBox8"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox1",  "pictureBox9"))
            {
                goto RR;
            }

            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox3.Tag)), "pictureBox2",  "pictureBox3"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox4.Tag)), "pictureBox2",  "pictureBox4"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox5.Tag)), "pictureBox2", "pictureBox5" ))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox6.Tag)), "pictureBox2", "pictureBox6"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox2", "pictureBox7"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox2",  "pictureBox8"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox2",  "pictureBox9"))
            {
                goto RR;
            }

            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox4.Tag)), "pictureBox3", "pictureBox4"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox5.Tag)), "pictureBox3", "pictureBox5"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox6.Tag)), "pictureBox3", "pictureBox6"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox3", "pictureBox7"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox3",  "pictureBox8"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox3",  "pictureBox9"))
            {
                goto RR;
            }

            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox5.Tag)), "pictureBox4","pictureBox5"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox6.Tag)), "pictureBox4", "pictureBox6"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox4",  "pictureBox7"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox4",  "pictureBox8"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox4",  "pictureBox9"))
            {
                goto RR;
            }

            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox6.Tag)), "pictureBox5", "pictureBox6"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox5", "pictureBox7"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox5",  "pictureBox8"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox5",  "pictureBox9"))
            {
                goto RR;
            }

            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox7.Tag)), "pictureBox6", "pictureBox7"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox6", "pictureBox8" ))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox6",  "pictureBox9"))
            {
                goto RR;
            }

            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox7.Tag), Convert.ToInt32(pictureBox8.Tag)), "pictureBox7", "pictureBox8"))
            {
                goto RR;
            }
            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox7.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox7",  "pictureBox9" ))
            {
                goto RR;
            }

            if (kodampic2(kartsevom(Convert.ToInt32(pictureBox8.Tag), Convert.ToInt32(pictureBox9.Tag)), "pictureBox8",  "pictureBox9"))
            {
                goto RR;
            }


            if (pictureBox10.Image != null && pictureBox11.Image != null && pictureBox12.Image != null)
            {
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox2", "pictureBox10"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox2", "pictureBox11"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox2.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox2",  "pictureBox12"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox3", "pictureBox10"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox3",  "pictureBox11"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox3.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox3","pictureBox12"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox5", "pictureBox10" ))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox5",  "pictureBox11" ))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox5.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox5", "pictureBox12"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox4",  "pictureBox10"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox4", "pictureBox11"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox4.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox4", "pictureBox12"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox6",  "pictureBox10"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox6", "pictureBox11"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox6.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox6",  "pictureBox12"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox7.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox7", "pictureBox10"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox7.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox7", "pictureBox11"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox7.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox7",  "pictureBox12"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox1", "pictureBox10"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox1",  "pictureBox11"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox1.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox1", "pictureBox12"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox8.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox8",  "pictureBox10"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox8.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox8", "pictureBox11"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox8.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox8", "pictureBox12" ))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox9.Tag), Convert.ToInt32(pictureBox10.Tag)), "pictureBox9",  "pictureBox10"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox9.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox9",  "pictureBox11"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox9.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox9", "pictureBox12"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox10.Tag), Convert.ToInt32(pictureBox11.Tag)), "pictureBox10", "pictureBox11"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox10.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox10", "pictureBox12"))
                {
                    goto RR;
                }
                if (kodampic2(kartsevom(Convert.ToInt32(pictureBox11.Tag), Convert.ToInt32(pictureBox12.Tag)), "pictureBox11",  "pictureBox12"))
                {
                    goto RR;
                }
            }
        RR:
            ;
        }
        private bool kodampic2(int on3, string pic01, string pic02)
        {
            if (on3 != 0)
            {
                if (Convert.ToInt32(pictureBox1.Tag) == on3)
                {
                    shokart3("pictureBox1");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox2.Tag) == on3)
                {
                    shokart3("pictureBox2");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox3.Tag) == on3)
                {
                    shokart3("pictureBox3");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox4.Tag) == on3)
                {
                    shokart3("pictureBox4");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox5.Tag) == on3)
                {
                    shokart3("pictureBox5");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox6.Tag) == on3)
                {
                    shokart3("pictureBox6");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox7.Tag) == on3)
                {
                    shokart3("pictureBox7");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox8.Tag) == on3)
                {
                    shokart3("pictureBox8");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox9.Tag) == on3)
                {
                    shokart3("pictureBox9");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox10.Tag) == on3)
                {
                    shokart3("pictureBox10");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox11.Tag) == on3)
                {
                    shokart3("pictureBox11");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
                else if (Convert.ToInt32(pictureBox12.Tag) == on3)
                {
                    shokart3("pictureBox12");
                    shokart3(pic01);
                    shokart3(pic02);
                    return true;
                }
            }
            return false;
        }

     

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[Convert.ToInt32(pictureBox1.Tag)];
            pictureBox2.Image = imageList1.Images[Convert.ToInt32(pictureBox2.Tag)];
            pictureBox3.Image = imageList1.Images[Convert.ToInt32(pictureBox3.Tag)];
            pictureBox4.Image = imageList1.Images[Convert.ToInt32(pictureBox4.Tag)];
            pictureBox5.Image = imageList1.Images[Convert.ToInt32(pictureBox5.Tag)];
            pictureBox6.Image = imageList1.Images[Convert.ToInt32(pictureBox6.Tag)];
            pictureBox7.Image = imageList1.Images[Convert.ToInt32(pictureBox7.Tag)];
            pictureBox8.Image = imageList1.Images[Convert.ToInt32(pictureBox8.Tag)];
            pictureBox9.Image = imageList1.Images[Convert.ToInt32(pictureBox9.Tag)];
            if (pictureBox10.Image != null && pictureBox11.Image != null && pictureBox12.Image != null)
            {
                pictureBox10.Image = imageList1.Images[Convert.ToInt32(pictureBox10.Tag)];
                pictureBox11.Image = imageList1.Images[Convert.ToInt32(pictureBox11.Tag)];
                pictureBox12.Image = imageList1.Images[Convert.ToInt32(pictureBox12.Tag)];
            }
                timer8.Enabled = false ;
        }
        private void shokart3( string pic)
        {
            if (pic111 == "")
            {
              
                pic111 = pic;

            }
            else if (pic222 == "")
            {
                if (pic != pic111)
                {
             
                    pic222 = pic;
                }
            }
            else if (pic333 == "" && pic != pic111 && pic != pic222)
            {
            
                pic333 = pic;

             
                    if (pic111 == "pictureBox10" || pic222 == "pictureBox10" || pic333 == "pictureBox10")
                    {
                        pictureBox10.Image = imageList1.Images[Convert.ToInt32(pictureBox10.Tag)+81];
                    }
                    if (pic111 == "pictureBox11" || pic222 == "pictureBox11" || pic333 == "pictureBox11")
                    {
                        pictureBox11.Image = imageList1.Images[Convert.ToInt32(pictureBox11.Tag) + 81];
                    }
                    if (pic111 == "pictureBox12" || pic222 == "pictureBox12" || pic333 == "pictureBox12")
                    {
                        pictureBox12.Image = imageList1.Images[Convert.ToInt32(pictureBox12.Tag) + 81];
                    }
                    if (pic111 == "pictureBox1" || pic222 == "pictureBox1" || pic333 == "pictureBox1")
                    {
                        pictureBox1.Image = imageList1.Images[Convert.ToInt32(pictureBox1.Tag) + 81];
                    }
                    if (pic111 == "pictureBox2" || pic222 == "pictureBox2" || pic333 == "pictureBox2")
                    {
                        pictureBox2.Image = imageList1.Images[Convert.ToInt32(pictureBox2.Tag) + 81];
                    }
                    if (pic111 == "pictureBox3" || pic222 == "pictureBox3" || pic333 == "pictureBox3")
                    {
                        pictureBox3.Image = imageList1.Images[Convert.ToInt32(pictureBox3.Tag) + 81];
                    }
                    if (pic111 == "pictureBox4" || pic222 == "pictureBox4" || pic333 == "pictureBox4")
                    {
                        pictureBox4.Image = imageList1.Images[Convert.ToInt32(pictureBox4.Tag) + 81];
                    }
                    if (pic111 == "pictureBox5" || pic222 == "pictureBox5" || pic333 == "pictureBox5")
                    {
                        pictureBox5.Image = imageList1.Images[Convert.ToInt32(pictureBox5.Tag) + 81];
                    }
                    if (pic111 == "pictureBox6" || pic222 == "pictureBox6" || pic333 == "pictureBox6")
                    {
                        pictureBox6.Image = imageList1.Images[Convert.ToInt32(pictureBox6.Tag) + 81];
                    }
                    if (pic111 == "pictureBox7" || pic222 == "pictureBox7" || pic333 == "pictureBox7")
                    {
                        pictureBox7.Image = imageList1.Images[Convert.ToInt32(pictureBox7.Tag) + 81];
                    }
                    if (pic111 == "pictureBox8" || pic222 == "pictureBox8" || pic333 == "pictureBox8")
                    {
                        pictureBox8.Image = imageList1.Images[Convert.ToInt32(pictureBox8.Tag) + 81];
                    }
                    if (pic111 == "pictureBox9" || pic222 == "pictureBox9" || pic333 == "pictureBox9")
                    {
                        pictureBox9.Image = imageList1.Images[Convert.ToInt32(pictureBox9.Tag) + 81];
                    }
                    pic111 = "";
                    pic222 = "";
                    pic333 = "";
                timer8.Enabled = true;
            }
        }


        private void timer9_Tick(object sender, EventArgs e)
        {
            int rnd7;
            if (Convert.ToInt32(pictureBox1.Tag) == 0)
            {
                rnd7 = rndimg();
                pictureBox1.Image = imageList1.Images[rnd7];
                pictureBox1.Tag = rnd7;
            }
            if (Convert.ToInt32(pictureBox2.Tag) == 0)
            {
                rnd7 = rndimg();
                pictureBox2.Image = imageList1.Images[rnd7];
                pictureBox2.Tag = rnd7;
            }
            if (Convert.ToInt32(pictureBox3.Tag) == 0)
            {
                rnd7 = rndimg();
                pictureBox3.Image = imageList1.Images[rnd7];
                pictureBox3.Tag = rnd7;
            }
            if (Convert.ToInt32(pictureBox4.Tag) == 0)
            {
                rnd7 = rndimg();
                pictureBox4.Image = imageList1.Images[rnd7];
                pictureBox4.Tag = rnd7;
            }
            if (Convert.ToInt32(pictureBox5.Tag) == 0)
            {
                rnd7 = rndimg();
                pictureBox5.Image = imageList1.Images[rnd7];
                pictureBox5.Tag = rnd7;
            }
            if (Convert.ToInt32(pictureBox6.Tag) == 0)
            {
                rnd7 = rndimg();
                pictureBox6.Image = imageList1.Images[rnd7];
                pictureBox6.Tag = rnd7;
            }
            if (Convert.ToInt32(pictureBox7.Tag) == 0)
            {
                rnd7 = rndimg();
                pictureBox7.Image = imageList1.Images[rnd7];
                pictureBox7.Tag = rnd7;
            }
            if (Convert.ToInt32(pictureBox8.Tag) == 0)
            {
                rnd7 = rndimg();
                pictureBox8.Image = imageList1.Images[rnd7];
                pictureBox8.Tag = rnd7;
            }
            if (Convert.ToInt32(pictureBox9.Tag) == 0)
            {
                rnd7 = rndimg();
                pictureBox9.Image = imageList1.Images[rnd7];
                pictureBox9.Tag = rnd7;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult a =MessageBox.Show("Are you sure?","New", MessageBoxButtons.YesNo  , MessageBoxIcon.Question , MessageBoxDefaultButton.Button2 );
            if (a == DialogResult.Yes)
            {
                shim1 = 0;
                shim2 = 0;
                shim3 = 0;
                visfa();
                shim11 = 0;
                shim22 = 0;
                shim33 = 0;
                kartha = 0;
                kartha2 = 0;
                pic1 = "";
                pic2 = "";
                pic3 = "";
                pic11 = "";
                pic22 = "";
                pic33 = "";
                pic111 = "";
                pic222 = "";
                pic333 = "";
                kartamad = new ArrayList();
                nafaraval = new ArrayList();
                nafardovom = new ArrayList();
                com = true;
                picuser1.Image = null;
                picuser2.Image = null;
                picuser3.Image = null;
                pu1.Image = null;
                pu2.Image = null;
                pu3.Image = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                Medium.Checked = true;
                label1.Text = "0";
                label2.Text = "0";
              // toolStripStatusLabel1.Text= "Time = 0:0";
                toolStripStatusLabel2.Text = "Time = 0:0";
               pictureBox10.Tag = 0;
               pictureBox10.Image = null;
               pictureBox10.Visible = false;
               pictureBox11.Tag = 0;
               pictureBox11.Image = null;
               pictureBox11.Visible = false;
               pictureBox12.Tag = 0;
               pictureBox12.Image = null;
           
               pictureBox13.Visible = false;
               pictureBox14.Visible = false;
               pictureBox15.Visible = false;
               pictureBox16.Visible = false;
               pictureBox17.Visible = false;
               pictureBox18.Visible = false;
               pictureBox19.Visible = false;
               numericUpDown1.Value = 7;
               numericUpDown2.Value = 0;
               tamam = 0;
                timer1.Enabled = false;
                timer2.Enabled = true;
                timer3.Enabled = false;
                timer6.Enabled = false;
                timer5.Enabled = false ;
                timer5.Enabled = checkBox3.Checked;
                timer5.Interval = 8000;
                timer4.Enabled = true;
                click = true;
                porpic();

            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            tamam++;
            timer2.Tag = 1;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer5.Enabled = false;
            timer4.Enabled = false;
            click = false;
            visfa();
            if (tamam == 1)
            {
                pictureBox13.Visible = true;
                timer1.Enabled = false;
            }
            else if (tamam == 2)
            {
                pictureBox13.Visible = false;
                pictureBox14.Visible = true;
                timer1.Enabled = false;
            }
            else if (tamam == 3)
            {
                pictureBox14.Visible = false;
                pictureBox15.Visible = true;
            }
            else if (tamam == 4)
            {
                pictureBox15.Visible = false;
                pictureBox16.Visible = true;
                timer1.Enabled = false;
            }
            else if (tamam == 5)
            {
                pictureBox16.Visible = false;
                pictureBox17.Visible = true;
            }
            else if (tamam == 6)
            {
                pictureBox17.Visible = false;
                pictureBox18.Visible = true;
                timer1.Enabled = false;
            }
            else if (tamam == 7)
            {
                pictureBox18.Visible = false;
                pictureBox19.Visible = true;
            }
            if (tamam == 8)
            {
                timer1.Enabled = false;
                timer10.Enabled = false;
                if (int.Parse(label1.Text) > int.Parse(label2.Text))
                {
                    MessageBox.Show("User1 Win", "", MessageBoxButtons.OK
                        , MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                else if (int.Parse(label1.Text) == int.Parse(label2.Text))
                {
                    MessageBox.Show("User1 and User2 Win", "", MessageBoxButtons.OK
                        , MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {

                    MessageBox.Show("User2 Win", "", MessageBoxButtons.OK
                     , MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button1);
                }
                pictureBox19.Visible = false ;
            }

        }

    

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog(this);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
      /*      MessageBox.Show("برای انتخاب کردن کارت های مناسب ابتدا چهار ویژگی را مورد بررسی قرار دهید" +
                "\n" + "به این صورت که یا هر سه کارت آن ویژگی را دارند یا هیچ کدام ندارند مثلاً هرسه" 
                + "\n" + "تعدادشان سه تا است یا تعداد آن ها به صورت یک دو سه است" +
                "\n\n" + "را که بر روی صفحه کلید است فشار دهید سه کارتی که با هم جور هستند نشان داده می شوند H درضمن اگر حرف ", "راهنمایی", MessageBoxButtons.OK,
                MessageBoxIcon.Information , 
            MessageBoxDefaultButton.Button1 , MessageBoxOptions .RightAlign  );*/
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
          
         
            if (kartamad.Count == 81)
            {
                if (Convert.ToInt32(pictureBox1.Tag) == 0)
                {
                    pictureBox1.Visible = false;
                }
                if (Convert.ToInt32(pictureBox2.Tag) == 0)
                {
                    pictureBox2.Visible = false;
                }
                if (Convert.ToInt32(pictureBox3.Tag) == 0)
                {
                    pictureBox3.Visible = false;
                }
                if (Convert.ToInt32(pictureBox4.Tag) == 0)
                {
                    pictureBox4.Visible = false;
                }
                if (Convert.ToInt32(pictureBox5.Tag) == 0)
                {
                    pictureBox5.Visible = false;
                }
                if (Convert.ToInt32(pictureBox6.Tag) == 0)
                {
                    pictureBox6.Visible = false;
                }
                if (Convert.ToInt32(pictureBox7.Tag) == 0)
                {
                    pictureBox7.Visible = false;
                }
                if (Convert.ToInt32(pictureBox8.Tag) == 0)
                {
                    pictureBox8.Visible = false;
                }
                if (Convert.ToInt32(pictureBox9.Tag) == 0)
                {
                    pictureBox9.Visible = false;
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        
        }

        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                timer2.Enabled = false;
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer1.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox29.Image = Properties.Resources.Click1;
                else
                    pictureBox29.Image = Properties.Resources.Click2;
                pictureBox29.Visible = true;
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                shokart(Convert.ToInt32(pictureBox10.Tag), "pictureBox10", 1);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                timer1.Enabled = false;
                timer1.Enabled = true;
                timer2.Enabled = false;
                timer2.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox20.Image = Properties.Resources.Click1;
                else
                    pictureBox20.Image = Properties.Resources.Click2;
                pictureBox20.Visible = true;
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    shokart(Convert.ToInt32(pictureBox1.Tag), "pictureBox1", 1);
                else
                    shokart(Convert.ToInt32(pictureBox1.Tag), "pictureBox1", 2);
            }
        }

        private void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                timer2.Enabled = false;
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer1.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox30.Image = Properties.Resources.Click1;
                else
                    pictureBox30.Image = Properties.Resources.Click2;
                pictureBox30.Visible = true;
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    shokart(Convert.ToInt32(pictureBox11.Tag), "pictureBox11", 1);
                else
                    shokart(Convert.ToInt32(pictureBox11.Tag), "pictureBox11", 2);
            }
        }
        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                timer2.Enabled = false;
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer1.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox31.Image = Properties.Resources.Click1;
                else
                    pictureBox31.Image = Properties.Resources.Click2;
                pictureBox31.Visible = true;
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    shokart(Convert.ToInt32(pictureBox12.Tag), "pictureBox12", 1);
                else
                    shokart(Convert.ToInt32(pictureBox12.Tag), "pictureBox12", 2);
            }
        }
        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                timer2.Enabled = false;
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer1.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox26.Image = Properties.Resources.Click1;
                else
                    pictureBox26.Image = Properties.Resources.Click2;
                pictureBox26.Visible = true;
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    shokart(Convert.ToInt32(pictureBox7.Tag), "pictureBox7", 1);
                else
                    shokart(Convert.ToInt32(pictureBox7.Tag), "pictureBox7", 2);
            }
        }
        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                timer2.Enabled = false;
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer1.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox23.Image = Properties.Resources.Click1;
                else
                    pictureBox23.Image = Properties.Resources.Click2;
                pictureBox23.Visible = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    shokart(Convert.ToInt32(pictureBox4.Tag), "pictureBox4", 1);
                else
                    shokart(Convert.ToInt32(pictureBox4.Tag), "pictureBox4", 2);
            }
        }
        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                timer2.Enabled = false;
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer1.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox24.Image = Properties.Resources.Click1;
                else
                    pictureBox24.Image = Properties.Resources.Click2;
                pictureBox24.Visible = true;
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    shokart(Convert.ToInt32(pictureBox5.Tag), "pictureBox5", 1);
                else
                    shokart(Convert.ToInt32(pictureBox5.Tag), "pictureBox5", 2);
            }
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                timer2.Enabled = false;
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer1.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox25.Image = Properties.Resources.Click1;
                else
                    pictureBox25.Image = Properties.Resources.Click2;
                pictureBox25.Visible = true;
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    shokart(Convert.ToInt32(pictureBox6.Tag), "pictureBox6", 1);
                else
                    shokart(Convert.ToInt32(pictureBox6.Tag), "pictureBox6", 2);
            }
        }
        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                timer2.Enabled = false;
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer1.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox27.Image = Properties.Resources.Click1;
                else
                    pictureBox27.Image = Properties.Resources.Click2;
                pictureBox27.Visible = true;
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    shokart(Convert.ToInt32(pictureBox8.Tag), "pictureBox8", 1);
                else
                    shokart(Convert.ToInt32(pictureBox8.Tag), "pictureBox8", 2);
            }
        }
        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                timer2.Enabled = false;
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer1.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox28.Image = Properties.Resources.Click1;
                else
                    pictureBox28.Image = Properties.Resources.Click2;
                pictureBox28.Visible = true;
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    shokart(Convert.ToInt32(pictureBox9.Tag), "pictureBox9", 1);
                else
                    shokart(Convert.ToInt32(pictureBox9.Tag), "pictureBox9", 2);
            }
        }
        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                timer2.Enabled = false;
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer1.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox22.Image = Properties.Resources.Click1;
                else
                    pictureBox22.Image = Properties.Resources.Click2;
                pictureBox22.Visible = true;
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    shokart(Convert.ToInt32(pictureBox3.Tag), "pictureBox3", 1);
                else
                    shokart(Convert.ToInt32(pictureBox3.Tag), "pictureBox3", 2);
            }
        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (click)
            {
                timer2.Enabled = false;
                timer2.Enabled = true;
                timer1.Enabled = false;

                timer1.Enabled = true;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    pictureBox21.Image = Properties.Resources.Click1;
                else
                    pictureBox21.Image = Properties.Resources.Click2;
                pictureBox21.Visible = true;
                if (checkBox3.Checked)
                {
                    timer5.Enabled = false;
                    timer5.Enabled = true;
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    shokart(Convert.ToInt32(pictureBox2.Tag), "pictureBox2", 1);
                else
                    shokart(Convert.ToInt32(pictureBox2.Tag), "pictureBox2", 2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2_Tick(sender, e);
        }

       
    }
}
namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki Soru";
            soruNo++;
            this.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "�lkemizin g�ney k�sm�ndaki k�y� b�lgesinin ad� nedir ? ";
                button1.BackColor = Color.Yellow;

            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Ye�illi�i ile �nl� marmarada bulunan ilimiz hangisidir ? ";
                button2.BackColor = Color.Yellow;
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "M�sl�manlar�n kutsal g�n� hangisidir ? ";
                button3.BackColor = Color.Yellow;
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Karpuzuyla �nl� ilimiz hangisidir ? ";
                button4.BackColor = Color.Yellow;
            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin z�t anlaml�s� nedir ? ";
                button5.BackColor = Color.Yellow;
            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Padi�ah�n emirlerinin haline ne ad verilir ? ";
                button6.BackColor = Color.Yellow;
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "D�nyan�n �s� kayna�� nedir ? ";
                button7.BackColor = Color.Yellow;
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "��renclerin k�t� karne al�nca bak��t��� nesne nedir ? ";
                button8.BackColor = Color.Yellow;
            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "G�l� ile �nl� ilimiz hangisidir ? ";
                button9.BackColor = Color.Yellow;
            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Mersinin di�er ismi nedir ? ";
                button10.BackColor = Color.Yellow;
            }
            if (soruNo == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk ad� nedir ?";
                button11.BackColor = Color.Yellow;
            }
            if (soruNo == 12)
            {
                richTextBox1.Text = "Malatyan�n me�ur meyvesinin ad� nedir ? ";
                button12.BackColor = Color.Yellow;
            }
            if (soruNo == 13)
            {
                richTextBox1.Text = "Her y�l bahar aylar�nda d�zenlenen me�ur �i�ek festivalinin ad� nedir ? ";
                button13.BackColor = Color.Yellow;
            }
            if (soruNo == 14)
            {
                richTextBox1.Text = "Y�l�n ���nc� ay� hangsidir ? ";
                button24.BackColor = Color.Yellow;
            }
            if (soruNo == 15)
            {
                richTextBox1.Text = "�flemeli bir m�zik aleti ? ";
                button14.BackColor = Color.Yellow;
            }
            if (soruNo == 16)
            {
                richTextBox1.Text = "Halk �airi ? ";
                button15.BackColor = Color.Yellow;
            }
            if (soruNo == 17)
            {
                richTextBox1.Text = "�ocuklar�n pek sevmedi�i pirin� havu� gibi sebzeler ile yap�lan yeme�in ad� nedir ? ";
                button16.BackColor = Color.Yellow;
            }
            if (soruNo == 18)
            {
                richTextBox1.Text = "11 Ay�n sultan� olan ay�n ad� nedir ?";
                button17.BackColor = Color.Yellow;
            }
            if (soruNo == 19)
            {
                richTextBox1.Text = "�ngilizcede y�lan ? ";
                button18.BackColor = Color.Yellow;
            }
            if (soruNo == 20)
            {
                richTextBox1.Text = "T�rkiyenin megastar� kimdir ? ";
                button19.BackColor = Color.Yellow;
            }
            if (soruNo == 21)
            {
                richTextBox1.Text = "�ans anlam�na gelen bir kelime ?";
                button20.BackColor = Color.Yellow;
            }
            if (soruNo == 22)
            {
                richTextBox1.Text = "Kahvalt�s� ile �nl� ilimiz hangisidir ? ";
                button21.BackColor = Color.Yellow;
            }
            if (soruNo == 23)
            {
                richTextBox1.Text = "�im�ek kelimesinin e� anlaml�s� olan kelime nedir ? ";
                button22.BackColor = Color.Yellow;
            }
            if (soruNo == 24)
            {
                richTextBox1.Text = "Ege b�lgesiinin en �ok a�ac� bulunan ya�� da yap�lan bir kahvalt� besini ? ";
                button23.BackColor = Color.Yellow;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    case 1: 
                        if(textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();

                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbak�r")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "g�ne�")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "hal�")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "�sparta")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "i�el")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 12:
                        if (textBox1.Text == "kay�s�")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "p�rasa")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "u�ur")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "y�ld�r�m")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                }
            }
        }
    }
}

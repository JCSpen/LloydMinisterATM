using System.Reflection.Metadata.Ecma335;
using System.Speech.Synthesis;
namespace LloydMinisterATM
{
    public partial class Form1 : Form
    {
        // HOME PAGE
        // - DISPLAY BALANCE
        // - WITHDRAW CASH
        // - WITHDRAW CASH W/ RECEIPT
        // - CHANGE YOUR PIN NUMBER
        // - OTHER

        // WITHDRAW PAGE
        // - £5
        // - £10
        // - £20
        // - £30
        // - £40
        // - £50
        // - £100
        // - OTHER

        public Card UserCard = new Card(123456789, 1111, new Account("Current Account",987654321,32500.79));
        public string Language = "English";
        public bool IsWithdraw { get; set; }
        public bool IsTransfer { get; set; }
        public bool PreventWithdrawl = false;
        public bool Authorised = false;
        public bool AudioAssistance = false;
        public string Destination { get; set; }
        public string KeypadEntry {get;set;}
        public Form1()
        {
            InitializeComponent();
            ClearTerminal();
            bn_Option_5.Text = "Change Language";
            bn_Option_6.Text = "Read Aloud";
            SpeakThis("Welcome to the LloydMinister ATM! If you require further audio assistance, the second button on the right side will enable text to speech...");
            PreventWithdrawl = AssignCard();
        }

        private bool AssignCard()
        {
            UserCard.NewAccountType(UserCard.GetAccountType());
            if(UserCard.LinkedAccount is LtDeposit)
            {
                return true;
            }
            return false;

        }

        private void ClearTerminal()
        {
            KeypadEntry = "";
            lbl_InputPin.Text = "";
        }

        private void SpeakThis(string text)
        {
            AudioNote Audio = new AudioNote(text);
        }

        private void SetDefaultCashAmounts()
        {
            bn_Option_1.Text = "£10";
            bn_Option_2.Text = "£20";
            bn_Option_3.Text = "£50";
            bn_Option_4.Text = "£100";
            bn_Option_5.Text = "£150";
            bn_Option_6.Text = "£200";
            bn_Option_7.Text = "£250";
            if(Language == "English") bn_Option_8.Text = "Menu";
            if (Language == "Français") bn_Option_8.Text = "Menu";
            if (Language == "Deutsch") bn_Option_8.Text = "Speisekarte";
            if (Language == "Español") bn_Option_8.Text = "Menú";
        }

        private void Withdraw(int amount)
        {
            UserCard.Withdraw(amount);
            MessageBox.Show("Remaining Balance: " + UserCard.GetBalance().ToString());
        }

        private void Transfer(int amount)
        {

        }

        private void ResetLanguageSelectors()
        {
            bn_Option_1.Text = "";
            bn_Option_2.Text = "";
            bn_Option_3.Text = "";
            bn_Option_4.Text = "";
        }

        private void SetDefaultMenu()
        {
            if (Language == "English")
            {
                if (Authorised)
                {
                    bn_Option_1.Text = "Transfer";
                    bn_Option_2.Text = "Withdraw";
                    bn_Option_3.Text = "Balance";
                    bn_Option_4.Text = "Statement";
                    bn_Option_5.Text = "Change Language";
                    bn_Option_6.Text = "Read Aloud";
                    bn_Option_7.Text = "Change Pin";
                    bn_Option_8.Text = "";
                }
                else
                {
                    ResetLanguageSelectors();
                    bn_Option_5.Text = "Change Language";
                    bn_Option_6.Text = "Read Aloud";
                }
            }
            if (Language == "Français")
            {
                if (Authorised)
                {
                    bn_Option_1.Text = "Transférer";
                    bn_Option_2.Text = "Se désister";
                    bn_Option_3.Text = "Solde";
                    bn_Option_4.Text = "Relevé bancaire";
                    bn_Option_5.Text = "Changer de langue";
                    bn_Option_6.Text = "Lit à voix haute";
                    bn_Option_7.Text = "Changer de broche";
                    bn_Option_8.Text = "";
                }
                else
                {
                    ResetLanguageSelectors();
                    bn_Option_5.Text = "Changer de langue";
                    bn_Option_6.Text = "Lit à voix haute";
                }
            }
            if (Language == "Deutsch")
            {
                if (Authorised)
                {
                    bn_Option_1.Text = "Transfer";
                    bn_Option_2.Text = "Abheben";
                    bn_Option_3.Text = "Gleichgewicht";
                    bn_Option_4.Text = "Kontoauszug";
                    bn_Option_5.Text = "Sprache ändern";
                    bn_Option_6.Text = "Vorlesen";
                    bn_Option_7.Text = "PIN ändern";
                    bn_Option_8.Text = "";
                }
                else
                {
                    ResetLanguageSelectors();
                    bn_Option_5.Text = "Sprache ändern";
                    bn_Option_6.Text = "Vorlesen";
                }
            }
            if (Language == "Español")
            {
                if (Authorised)
                {
                    bn_Option_1.Text = "Transferir";
                    bn_Option_2.Text = "Retirar";
                    bn_Option_3.Text = "Balance";
                    bn_Option_4.Text = "Extracto de cuenta";
                    bn_Option_5.Text = "Cambiar idioma";
                    bn_Option_6.Text = "Leer en voz alta";
                    bn_Option_7.Text = "Cambiar PIN";
                    bn_Option_8.Text = "";
                }
                else
                {
                    ResetLanguageSelectors();
                    bn_Option_5.Text = "Cambiar idioma";
                    bn_Option_6.Text = "Leer en voz alta";
                }
            }
        }

        private void btn_Keypad_Number_0_Click(object sender, EventArgs e)
        {
            KeypadEntry = KeypadEntry + "0";
            lbl_InputPin.Text = lbl_InputPin.Text + "*";
        }
        private void btn_Keypad_Number_1_Click(object sender, EventArgs e)
        {
            KeypadEntry = KeypadEntry + "1";
            lbl_InputPin.Text = lbl_InputPin.Text + "*";
        }
        private void btn_Keypad_Number_2_Click(object sender, EventArgs e)
        {
            KeypadEntry = KeypadEntry + "2";
            lbl_InputPin.Text = lbl_InputPin.Text + "*";

        }
        private void btn_Keypad_Number_3_Click(object sender, EventArgs e)
        {
            KeypadEntry = KeypadEntry + "3";
            lbl_InputPin.Text = lbl_InputPin.Text + "*";

        }

        private void btn_Keypad_Number_4_Click(object sender, EventArgs e)
        {
            KeypadEntry = KeypadEntry + "4";
            lbl_InputPin.Text = lbl_InputPin.Text + "*";

        }

        private void btn_Keypad_Number_5_Click(object sender, EventArgs e)
        {
            KeypadEntry = KeypadEntry + "5";
            lbl_InputPin.Text = lbl_InputPin.Text + "*";

        }

        private void btn_Keypad_Number_6_Click(object sender, EventArgs e)
        {
            KeypadEntry = KeypadEntry + "6";
            lbl_InputPin.Text = lbl_InputPin.Text + "*";

        }

        private void btn_Keypad_Number_7_Click(object sender, EventArgs e)
        {
            KeypadEntry = KeypadEntry + "7";
            lbl_InputPin.Text = lbl_InputPin.Text + "*";

        }

        private void btn_Keypad_Number_8_Click(object sender, EventArgs e)
        {
            KeypadEntry = KeypadEntry + "8";
            lbl_InputPin.Text = lbl_InputPin.Text + "*";

        }

        private void btn_Keypad_Number_9_Click(object sender, EventArgs e)
        {
            KeypadEntry = KeypadEntry + "9";
            lbl_InputPin.Text = lbl_InputPin.Text + "*";

        }

        private void btn_Keypad_Cancel_Click(object sender, EventArgs e)
        {
            string PreviousContents = KeypadEntry;
            int Index = 0;
            ClearTerminal();
            foreach(char c in PreviousContents)
            {
                if(Index != PreviousContents.Length - 1)
                {
                    lbl_InputPin.Text = lbl_InputPin.Text + "*";
                    KeypadEntry = KeypadEntry + c.ToString();
                    Index++;
                }
            }
        }

        private void btn_Keypad_Clear_Click(object sender, EventArgs e)
        {
            ClearTerminal();
        }

        private void btn_Keypad_Enter_Click(object sender, EventArgs e)
        {
            if (KeypadEntry == UserCard.GetPin().ToString())
            {
                Authorised = true;
                ClearTerminal();
                SetDefaultMenu();

            }
            else
            {
                MessageBox.Show("Incorrect Pin");
                ClearTerminal();
            }
        }

        private void bn_Option_1_Click(object sender, EventArgs e)
        {
            if (bn_Option_1.Text != "£10" && Authorised && bn_Option_1.Text != "English")
            {
                IsWithdraw = false;
                IsTransfer = true;
                SetDefaultCashAmounts();
            }
            else if (bn_Option_1.Text == "English")
            {
                Language = "English";
                SetDefaultMenu();
            }
            else if(bn_Option_1.Text == "CurrentAccount")
            {
                Destination = "CurrentAccount";
                SetDefaultCashAmounts();
            }
            if (bn_Option_1.Text == "£10")
            {
                if(IsWithdraw)
                {
                    Withdraw(10);
                }
                else
                {
                    UserCard.GetOtherAccounts();
                    int index = 0;
                    foreach(Account acc in UserCard.GetLinkedAccounts())
                    {
                        bn_Option_4.Text = "";
                        bn_Option_5.Text = "";
                        bn_Option_6.Text = "";
                        bn_Option_7.Text = "";
                        bn_Option_8.Text = "";
                        if (index == 0) bn_Option_1.Text = acc.GetType().ToString();
                        if (index == 1) bn_Option_2.Text = acc.GetType().ToString();
                        if (index == 2) bn_Option_3.Text = acc.GetType().ToString();
                        index++;
                    }
                }
            }
           
        }

        private void bn_Option_2_Click(object sender, EventArgs e)
        {
            if (bn_Option_2.Text == "£20")
            {
                if (IsWithdraw)
                {
                    Withdraw(20);
                }
            }
            if (bn_Option_2.Text != "£20" && Authorised && bn_Option_2.Text != "Français" && !PreventWithdrawl)
            {
                IsTransfer = false;
                IsWithdraw = true;
                SetDefaultCashAmounts();
            }
            else if (bn_Option_2.Text == "Français")
            {
                Language = "Français";
                SetDefaultMenu();
            }
            else if (bn_Option_2.Text == "SimpleDeposit")
            {
                Destination = "SimpleDeposit";
                SetDefaultCashAmounts();
            }
        }

        private void bn_Option_3_Click(object sender, EventArgs e)
        {
            if (bn_Option_3.Text == "£50")
            {
                if (IsWithdraw)
                {
                    Withdraw(50);
                }
            }
            if (bn_Option_3.Text != "£50" && Authorised && bn_Option_3.Text != "Deutsch")
            {
                MessageBox.Show(UserCard.GetBalance().ToString());
            }
            else if (bn_Option_3.Text == "Deutsch")
            {
                Language = "Deutsch";
                SetDefaultMenu();
            }
            else if (bn_Option_3.Text == "LtDeposit")
            {
                Destination = "LtDeposit";
                SetDefaultCashAmounts();
            }
        }

        private void bn_Option_4_Click(object sender, EventArgs e)
        {
            if (bn_Option_4.Text == "£100")
            {
                if (IsWithdraw)
                {
                    Withdraw(100);
                }
            }
            if (bn_Option_4.Text != "£100" && Authorised && bn_Option_4.Text != "Español")
            {
                List<string> Statements = UserCard.GetStatements();
                string statement = "";
                foreach(string str in Statements)
                {
                    statement = statement + "," + str;
                }
                MessageBox.Show(statement);
            }
            else if (bn_Option_4.Text == "Español")
            {
                Language = "Español";
                SetDefaultMenu();
            }
        }

        private void bn_Option_5_Click(object sender, EventArgs e)
        {
            if (bn_Option_5.Text == "£150")
            {
                if (IsWithdraw)
                {
                    Withdraw(150);
                }
            }
            if (bn_Option_5.Text != "£150")
            {
                bn_Option_1.Text = "English";
                bn_Option_2.Text = "Français";
                bn_Option_3.Text = "Deutsch";
                bn_Option_4.Text = "Español";
            }
        }

        private void bn_Option_6_Click(object sender, EventArgs e)
        {
            if (bn_Option_6.Text == "£200")
            {
                if (IsWithdraw)
                {
                    Withdraw(200);
                }
            }
            if (bn_Option_6.Text != "£200" && !AudioAssistance )
            {
                AudioAssistance = true;
                SpeakThis("Audio Assistance Enabled!");
            }
            else if ((bn_Option_6.Text != "£200" && AudioAssistance))
            {
                AudioAssistance = false;
                SpeakThis("Audio Assistance Disabled!");
            }
            

        }

        private void bn_Option_7_Click(object sender, EventArgs e)
        {
            if (bn_Option_7.Text == "£250")
            {
                if (IsWithdraw)
                {
                    Withdraw(2502);
                }
            }
        }

        private void bn_Option_8_Click(object sender, EventArgs e)
        {
            if(Authorised) SetDefaultMenu();
        }

        private void lbl_InputPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Keypad_Number_1_MouseHover(object sender, EventArgs e)
        {

        }

        private void bn_Option_1_MouseHover(object sender, EventArgs e)
        {
            if(AudioAssistance)
            {
                SpeakThis(bn_Option_1.Text);
            }
        }

        private void bn_Option_2_MouseHover(object sender, EventArgs e)
        {
            if (AudioAssistance)
            {
                SpeakThis(bn_Option_2.Text);
            }
        }

        private void bn_Option_3_MouseHover(object sender, EventArgs e)
        {
            if (AudioAssistance)
            {
                SpeakThis(bn_Option_3.Text);
            }
        }

        private void bn_Option_4_MouseHover(object sender, EventArgs e)
        {
            if (AudioAssistance)
            {
                SpeakThis(bn_Option_4.Text);
            }
        }

        private void bn_Option_5_MouseHover(object sender, EventArgs e)
        {
            if (AudioAssistance)
            {
                SpeakThis(bn_Option_5.Text);
            }
        }

        private void bn_Option_6_MouseHover(object sender, EventArgs e)
        {
            if (AudioAssistance)
            {
                SpeakThis(bn_Option_6.Text);
            }
        }

        private void bn_Option_7_MouseHover(object sender, EventArgs e)
        {
            if (AudioAssistance)
            {
                SpeakThis(bn_Option_7.Text);
            }
        }

        private void bn_Option_8_MouseHover(object sender, EventArgs e)
        {
            if (AudioAssistance)
            {
                SpeakThis(bn_Option_8.Text);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;



namespace Sheep_Farm
{



    public partial class Form1 : Form
    {
        #region Initialize Variables n Stuff
        Random random = new Random();

        bool youHaveAHeart = false; // use this flag when deciding if you alough sheep to die
        int shaveCounter = 0;           //how many days since last shave?
        int sheep = 10, sheepCost = 500, casualties = 0; //how many sheepies we have and how much they are worth, use casualties if sheep die
        int money = 500;                //how much monies we gots
        int wool = 0, woolCost = 25;    //how many woolzies we got and how much they are worth
        int food = 50, foodCost = 10, hunger = 1;   //how much food we gots and how much they are worth, and how hungry (cold) the sheep are
        int woolQuality = 10;
        int thermo = 75, thermo1 = 75, thermo2 = 75, thermo3 = 75;  //thermo is todays temperature and thurmo 1-3 is the next 3 days forcast

        string farmName = "Bannana Sheep Farm";
        string weather = "Sunny", forcast1 = "Sunny", forcast2 = "Sunny", forcast3 = "Sunny"; //todays weather and the next 3 days ie(Rain, Snow, ThunderStorm)

        public Form1()
        {
            InitializeComponent();

            //LETS SET OUR LABELS RIGHT ON BOOT (so our feet look good)
            updateMoneyNum(ref money);
            updateWoolNum(ref wool);
            woolQualityLabel.Text = "Wool Quality: " + woolQuality + "%";
            sheepLabel.Text = "Sheep: " + sheep;
            todaysWeatherLabel.Text = "Today: " + thermo + " " + weather;
            oneForcastLabel.Text = "Tomorow: " + thermo1 + " " + forcast1;
            twoForcastLabel.Text = "       2 Days: " + thermo2 + " " + forcast2;
            threeForcastLabel.Text = "       3 Days: " + thermo3 + " " + forcast3;
            foodMarketLabel.Text = "Food: $" + foodCost;
            woolMarketLabel.Text = "Wool: $" + woolCost;
            sheepMarketLabel.Text = "Sheep: $" + sheepCost;
            foodLabel.Text = "Food: " + food;

        }

        #endregion


        //This runs when GO button is pressed
        private void goButton_Click(object sender, EventArgs e)
        {
            #region will sheep die if I proceed?
            if (sheep * hunger > food)//if you dont have enough food for the night
            {
                if (MessageBox.Show("You dont have enough food for all your sheep. Some may die! ", "WARNING", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    youHaveAHeart = true;//you decided to cancel so sheep dont die
                }
                else
                {
                    youHaveAHeart = false;//dont care if sheep die
                }
            }

            // a 'DialogResult.Yes' value was returned from the MessageBox // proceed with your deletion 

            if (youHaveAHeart == false)//you never have a heart when there is enough food. So its ok.
                                       //the only reason you get a heart is if you dont want to go ahead a day
            {

                #endregion


                #region shave counter

                shaveCounter++;
                if (shaveCounter > 14)//lets avoid wool quality skyrocketing 
                    shaveCounter = 14;//2 weeks is the longest our sheep's wool can 'age' in the feild

                #endregion

                feedMySheep(ref sheep, ref hunger, ref food);//sheepz gotta eat

                #region update weather

                //LETS GET THE WEATHER UPDATED!
                generateWeather(ref weather, ref forcast1, ref forcast2, ref forcast3, ref thermo3);
                generateTemperatures(ref thermo, ref thermo1, ref thermo2, ref thermo3);
                todaysWeatherLabel.Text = "Today: " + thermo + " " + weather;
                oneForcastLabel.Text = "Tomorow: " + thermo1 + " " + forcast1;
                twoForcastLabel.Text = "       2 Days: " + thermo2 + " " + forcast2;
                threeForcastLabel.Text = "       3 Days: " + thermo3 + " " + forcast3;

                if (thermo < 32)// the sheep get twice as hungry when it is cold out
                    hunger = 2;
                else
                    hunger = 1;

                newDaySound();

                #endregion

                #region update Food/Wool/Sheep Markets and Wool Quality
                updateFoodCost(ref foodCost);
                foodMarketLabel.Text = "Food: $" + foodCost;
                updateWoolCost(ref woolCost);
                woolMarketLabel.Text = "Wool: $" + woolCost;
                sheepCost = updateSheepCost(sheepCost);
                sheepMarketLabel.Text = "Sheep: $" + sheepCost;
                calcWoolQuality(ref woolQuality, shaveCounter, weather);

                #endregion



            }
            #region cont. will sheep die if I proceed?
            else
                youHaveAHeart = true;// this returns to initilized value
            #endregion
        }

        //This runs when we press SELL THAT WOOL!!
        private void sellWoolButton_Click(object sender, EventArgs e)
        {
            if (wool > 0)
            {
                chachingSound();
            }
            money = money + (wool * woolCost);
            wool = 0;
            updateWoolNum(ref wool);
            updateMoneyNum(ref money);
            woolLabel.Text = "Wool: " + wool;



        }

        //this runs when we click SHAVE THEM SHEEEEPIEz
        private void shaveSheepButton_Click(object sender, EventArgs e)
        {
            double percentage = .5f;// will convert quality to percentage using this
            double woolGained = 0;
            if (woolQuality == 0)// to avoid divide by 0 bug  
                woolQuality = 1;

            percentage = woolQuality / 100f;// convert to percentage
            woolGained = sheep * percentage;

            woolGained += random.Next(2);//Just so the user cant predict accuratly     >:{D -hahahaha

            if (sheep == 0)
                woolGained = 0; // Cause we cant have farmers shaving dead sheep now can we?



            if (shaveCounter > 0)
            {
                clipSheepSound();
                wool += (int)woolGained;
                woolLabel.Text = "Wool: " + wool + " woolz";

                shaveCounter = 0;//we just shaved so lets reset our counter;
                calcWoolQuality(ref woolQuality, shaveCounter, weather);//crash the quality cause all the sheep are naked;
            }

        }

        //If you want to BUY FOOD button pressed
        private void buyFoodButton_Click(object sender, EventArgs e)
        {
            int buyHowmany = 0;
            if (Form1.InputBoxInt("Buy Food", "How much food?", ref buyHowmany) == DialogResult.OK)
            {
                if (buyHowmany * foodCost <= money)//can we afford it
                {
                    food = food + buyHowmany;
                    money = money - (buyHowmany * foodCost);
                }
            }
        }

        //this is called when you press BUY THEM SHEEPZ!
        private void buySheepButton_Click(object sender, EventArgs e)
        {
            int buyHowmany = 0;
            if (Form1.InputBoxInt("Buy Sheep", "How many sheep?", ref buyHowmany) == DialogResult.OK)
            {


                if (sheepCost * buyHowmany <= money && buyHowmany > 0)//if we can afford it AND we are buying a positve # off sheepz
                {
                    sheep += buyHowmany;
                    money -= sheepCost * buyHowmany;
                    updateMoneyNum(ref money);
                    updateSheepNum(ref sheep);
                }
            }

        }

        //this is called when you press SELL THEM SHEEPZ!
        private void sellSheepButton_Click_1(object sender, EventArgs e)
        {
            int sellHowmany = 0;
            if (Form1.InputBoxInt("Sell Sheep", "How many sheep?", ref sellHowmany) == DialogResult.OK)
            {


                if (sheep > sellHowmany)//if we have enough sheepz
                {
                    chachingSound();
                    sheep -= sellHowmany;
                    money += sheepCost * sellHowmany;
                    updateMoneyNum(ref money);
                    updateSheepNum(ref sheep);
                }
            }

        }

        //click this if you want to RENAME YOUR FARM
        private void label1_Click(object sender, EventArgs e)
        {
            if (Form1.InputBoxString("Rename Farm", "What would you like to name your farm?", ref farmName) == DialogResult.OK)
            {
                label1.Text = farmName;
            }
        }



        //this gets called every day. This will have each sheep EAT. if there is not enough food your sheep will die (OH NO!)
        public void feedMySheep(ref int sheep, ref int hunger, ref int food)
        {
            if (sheep * hunger > food)//calculate if sheep died
            {
                casualties = sheep - (hunger * food);//how many didnt make it through the night? :'(
                sheep = sheep - casualties; // RIP
                if (sheep < 1)//Game Over?
                {
                    updateSheepNum(ref sheep);
                    MessageBox.Show("All your sheepiez have died :.(", "OH SNAP!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            food = food - sheep * hunger;
            if (food < 0)
                food = 0;

            updateSheepNum(ref sheep);
            updateFoodNum(ref food);

        }



        //Updates the Wool Label
        public void updateWoolNum(ref int wool)
        {
            woolLabel.Text = "Wool: " + wool;

        }

        //Updates the Money Label
        public void updateMoneyNum(ref int money)
        {
            moneyLabel.Text = "Money: $" + money;

        }

        //Updates the Sheep Label
        public void updateSheepNum(ref int sheep)
        {
            sheepLabel.Text = "Sheep: " + sheep;
            if (sheep == 0)
                sheepLabel.Text = "Sheep: RIP :.(";
        }

        //Updates the Food Label
        public void updateFoodNum(ref int food)
        {
            foodLabel.Text = "Food: " + food;

        }



        //determines the wool quality ( call this pre-Harvest and Post-harvest)
        public void calcWoolQuality(ref int woolQuality, int shaveCounter, string weather)
        {
            int foo = random.Next(5);
            int bar = 0;
            switch (weather)
            {
                case "Snow":
                    bar = -20;
                    break;
                case "Rain":
                    bar = -25;
                    break;
                case "Light Snow":
                    bar = -10;
                    break;
                case "Light Rain":
                    bar = -12;
                    break;
                case "Thunderstorms":
                    bar = -30;
                    break;
                case "Sunny":
                    bar = 25;
                    break;
                default:
                    bar = 10;
                    break;

            }
            woolQuality = (shaveCounter * 5) + (foo + bar);
            if (woolQuality > 99)
                woolQuality = 99;
            if (woolQuality < 0)
                woolQuality = 0;

            if (shaveCounter == 0)
                woolQuality = 0;

            woolQualityLabel.Text = "*Wool Quality: " + woolQuality + "%";
        }

        //Generates the non-temperature side of weather.
        public void generateWeather(ref string weather, ref string forcast1, ref string forcast2, ref string forcast3, ref int temperature)
        {
            // shifts the forcast forward one day then randomly picks the weather for 3 days into the future.
            //Last arg sent (temperature0 is the tempurature forcasted for 3 days out. This is used to decide 
            //if it will snow or rain.
            //RUN generateWeather() BEFORE generateTemperatures() to accurately predict rain or snow;

            int foo = random.Next(7); ;

            weather = forcast1;
            forcast1 = forcast2;
            forcast2 = forcast3;

            //Decide what weather is randomly selected (for 3 days out)
            switch (foo)
            {
                case 0:
                    forcast3 = "Overcast";
                    break;
                case 1:
                    forcast3 = "Mostly Clear";
                    break;
                case 2:
                    if (temperature > 32)//is it cold enough for snow???
                        forcast3 = "Light Rain";
                    else
                        forcast3 = "Light Snow";
                    break;
                case 3:
                    if (temperature > 32)//is it cold enough for snow???
                        forcast3 = "Rain";
                    else
                        forcast3 = "Snow";
                    break;
                case 4:
                    forcast3 = "Thunderstorms";
                    break;
                default:
                    forcast3 = "Sunny";
                    break;

            }





        }

        //Adjust the Temps for the next weather patern
        public void generateTemperatures(ref int thermo, ref int thermo1, ref int thermo2, ref int thermo3)
        {
            thermo = thermo1;
            thermo1 = thermo2;
            thermo2 = thermo3;
            int foo = random.Next(10) - 5;

            thermo3 = thermo2 + foo;

            //lets control the temperatures so they dont get too extreme:
            if (thermo3 < -40)
                thermo3 = -40;
            if (thermo3 > 121)
                thermo3 = 121;

        }

        //Adjust market value of food
        public void updateFoodCost(ref int foodCost)
        {
            int foo = random.Next(10) - 5;
            foodCost = foodCost + foo;

            if (foodCost < 1)
                foodCost = 1;
            if (foodCost > 25)
                foodCost = 25;
        }

        //Adjust Market value of Wool
        public void updateWoolCost(ref int woolCost)
        {
            int foo = random.Next(10) - 5;
            woolCost = woolCost + foo;
            if (woolCost < 5)
                woolCost = 5;
            if (woolCost > 50)
                woolCost = 50;

        }

        //Adjust Market value of sheepies
        public int updateSheepCost(int sheepCost)
        {
            int foo = random.Next(100) - 50;
            sheepCost += foo;
            if (sheepCost > 2500)
                sheepCost = 2500;
            if (sheepCost < 50)
                sheepCost = 50;

            return sheepCost;
        }



        //This is a dialog box that gets Input from user and sends us an INT
        public static DialogResult InputBoxInt(string title, string promptText, ref int value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value.ToString();

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            if (Int32.TryParse(textBox.Text, out value))
            {
                value = value;
            }
            else value = 0;

            return dialogResult;
        }

        //This is a dialog box that gets Input from user and sends us a STRING
        public static DialogResult InputBoxString(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }



        //plays "Chaching!" $$$ sound
        private void chachingSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\brand\Documents\visual studio 2015\Projects\Sheep Farm\Media\chaching.wav");
            player.Play();
        }

        //plays "clipSheep!" $$$ sound
        private void clipSheepSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\brand\Documents\visual studio 2015\Projects\Sheep Farm\Media\clipSheep.wav");
            player.Play();
        }

        //plays "newDay!" $$$ sound
        private void newDaySound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\brand\Documents\visual studio 2015\Projects\Sheep Farm\Media\newDay.wav");
            player.Play();
        }

        //plays "notice!" $$$ sound (randomly 1 or 2)
        private void noticeSound()
        {
            int foo = random.Next(2);
            string bar;
            if (foo == 1)
                   bar = "notice1.wav";
            else
                bar = "notice2.wav";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\brand\Documents\visual studio 2015\Projects\Sheep Farm\Media\"+bar);

            player.Play();
        }

        //plays "notice3!" $$$ sound (Bad notice sound)
        private void notice3Sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\brand\Documents\visual studio 2015\Projects\Sheep Farm\Media\notice3.wav");
            player.Play();
        }

    }



}

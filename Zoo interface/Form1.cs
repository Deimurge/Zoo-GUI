using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zoo_interface
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void Animals()
        {

        }
        private void MBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GoodBye");
            Close();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SoulPage_Click(object sender, EventArgs e)
        {

        }

        private void SoulBtn_Click(object sender, EventArgs e)
        {

            if (Soul.Checked == true || ManageBtn.Checked == true)
            {
                if (Soul.Checked == true)
                {
                    TabControl.SelectedTab = Zoo;
                    MessageBox.Show("Hello Vistor, Please enjoy your visit");
                }
                else if (ManageBtn.Checked == true)
                {
                    TabControl.SelectedTab = ManagementPage;
                    MessageBox.Show("Greetings Zookeaper, Welcome back, Hope you have a great day");
                }
                else
                {
                    MessageBox.Show("Please Select if you are part of visitor or management ");
                    //tabControl1.SelectedTab = Zoo;
                }
            }
            else
            {
                    MessageBox.Show("Please Select if you are part of visitor or management ");

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ZButton_Click(object sender, EventArgs e)
        {
            if (AnimalType.SelectedItem == "Mammals")
            {
                MessageBox.Show("Welcome to the Mammal Habitat");
                TabControl.SelectedTab = Mammals;
            }
            else if (AnimalType.SelectedItem == "Reptiles")
            {
                MessageBox.Show("Sorry, we cannot let visitors in the snakes in this exhibit for it is still in development. " +
                                            "Please come back in 4-5 months. Thank you for visiting the HighLand Zoo!");
            }
            else if (AnimalType.SelectedItem == "Birds")
            {
                MessageBox.Show("Welcome to the Bird Habitat");
                TabControl.SelectedTab = Birds;
            }
            else { MessageBox.Show("Error: Please pick a habitat you would like to visit"); }
        }

        private void MHBack_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Zoo;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Feedbtn_Click(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lions lions = new Lions();
            bears bears = new bears();
            parrots parrots = new parrots();
            flamboyance flamboyance = new flamboyance();
            snakes snakes = new snakes();
            lions.FoodType = FoodType.Meat;
            bears.FoodType = FoodType.Fish;
            parrots.FoodType = FoodType.Fruit_and_berries;
            flamboyance.FoodType = FoodType.Mixed;

            if (comboBox8.SelectedItem == "Lions")
            {
                MessageBox.Show("Please pick the Lions meal for today");
                if (comboBox7.SelectedItem == "Meat")
                {
                    lions.Feed(50);
                    MessageBox.Show($"The Lions are eating {lions.FoodType}");
                }
                else if (comboBox7.SelectedItem == "Fish")
                {
                    lions.Feed(25);
                }
                else if (comboBox7.SelectedItem == "Friuts")
                {
                    lions.Feed(15);
                }
                else if (comboBox7.SelectedItem == "Seeds")
                {
                    lions.Feed(5);
                }
                else if (comboBox7.SelectedItem == "Berries")
                {
                    lions.Feed(10);
                }

            }
            else if (comboBox8.SelectedItem == "Bears")
            {
                MessageBox.Show("Please pick the Bears meal for today");
                if (comboBox7.SelectedItem == "Meat")
                {
                    bears.Feed(30);
                    MessageBox.Show($"The Lions are eating {bears.FoodType}");
                }
                else if (comboBox7.SelectedItem == "Fish")
                {
                    bears.Feed(45);
                }
                else if (comboBox7.SelectedItem == "Friuts")
                {
                    bears.Feed(25);
                }
                else if (comboBox7.SelectedItem == "Seeds")
                {
                    bears.Feed(5);
                }
                else if (comboBox7.SelectedItem == "Berries")
                {
                    bears.Feed(15);
                }


            }

            else if (comboBox8.SelectedItem == "parrots")
            {
                MessageBox.Show("Welcome to the Bird Habitat");
                if (comboBox7.SelectedItem == "Meat")
                {
                    parrots.Feed(0);
                }
                else if (comboBox7.SelectedItem == "Fish")
                {
                    parrots.Feed(0);
                }
                else if (comboBox7.SelectedItem == "Friuts")
                {
                    parrots.Feed(35);
                    MessageBox.Show($"The parrots are eating {parrots.FoodType}");
                }
                else if (comboBox7.SelectedItem == "Seeds")
                {
                    parrots.Feed(25);
                }
                else if (comboBox7.SelectedItem == "Berries")
                {
                    parrots.Feed(15);
                }

            }
            else if (comboBox8.SelectedItem == "flamingos")
            {
                MessageBox.Show("Welcome to the Bird Habitat");
                if (comboBox7.SelectedItem == "Meat")
                {
                    flamboyance.Feed(0);
                }
                else if (comboBox7.SelectedItem == "Fish")
                {
                    flamboyance.Feed(45);
                    MessageBox.Show($"The flamingos are eating {flamboyance.FoodType}");
                }
                else if (comboBox7.SelectedItem == "Friuts")
                {
                    flamboyance.Feed(35);    
                }
                else if (comboBox7.SelectedItem == "Seeds")
                {
                    flamboyance.Feed(15);
                }
                else if (comboBox7.SelectedItem == "Berries")
                {
                    flamboyance.Feed(25);
                }

            }
            else if (comboBox2.SelectedItem == "snakes")
            {
                MessageBox.Show("Welcome to the Bird Habitat");

            }
            else if (comboBox8.SelectedItem == "turtles")
            {
                MessageBox.Show("Welcome to the Bird Habitat");

            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            /*Lions lions = new Lions();
            bears bears = new bears();
            parrots parrots = new parrots();
            flamboyance flamboyance = new flamboyance();
            snakes snakes = new snakes();

            int amount;
            bool isNumber = int.TryParse(textBox15.Text.Substring(0, 1), out amount);
            if (isNumber == false)
            {
                int length = textBox15.Text.Length;
                String type = textBox15.Text.Substring(0, length).ToLower();

                //lions.Feed(type);
            }
            else
            {
                int length = textBox15.Text.Length - 2;
                String type = textBox15.Text.Substring(0, length).ToLower();

                //input(amount, type);
            }*/
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, we cannot let visitors feed the snakes in this exhibit for legal reasons. " +
                            "The turtles exhibit is not available at the moment. Please come back in 4-5 months. Thank you for visiting the HighLand Zoo!");
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Lions lions = new Lions();
            bears bears = new bears();
            parrots parrots = new parrots();
            flamboyance flamboyance = new flamboyance();
            snakes snakes = new snakes();
            string name;
            if (comboBox8.SelectedItem == "Lions" && !(textBox22.Text == " "))
            {
                try
                {
                    name = textBox22.Text;
                    MessageBox.Show("You Have given the lion a nickname called " + name);
                    lions.Name = name;

                }
                catch (Exception)
                {
                    MessageBox.Show("Must be an String", "Incorrect input type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (comboBox2.SelectedItem == "Bears" && !(textBox22.Text == ""))
            {
                try
                {
                    name = textBox22.Text;
                    bears.Name = name;

                }
                catch (Exception)
                {
                    MessageBox.Show("Must be an String", "Incorrect input type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (comboBox8.SelectedItem == "parrots" && !(textBox22.Text == ""))
            {
                try
                {
                    name = textBox22.Text;
                    parrots.Name = name;

                }
                catch (Exception)
                {
                    MessageBox.Show("Must be an String", "Incorrect input type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (comboBox8.SelectedItem == "flamingos" && !(textBox22.Text == ""))
            {
                try
                {
                    name = textBox22.Text;
                    flamboyance.Name = name;

                }
                catch (Exception)
                {
                    MessageBox.Show("Must be an String", "Incorrect input type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Home;
            Lions lions = new Lions();
            bears bears = new bears();
            parrots parrots = new parrots();
            flamboyance flamboyance = new flamboyance();
            snakes snakes = new snakes();
            lions.Sleep();
            bears.Sleep();
            parrots.Sleep();
            flamboyance.Sleep();
            snakes.Sleep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Zoo;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Zoo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lions lions = new Lions();
            bears bears = new bears();
            parrots parrots = new parrots();
            flamboyance flamboyance = new flamboyance();

            if (comboBox8.SelectedItem == "Lions")
            {
                    lions.Eat(50);
            }
            else if (comboBox8.SelectedItem == "Bears")
            {
                    bears.Eat(45);
            }

            else if (comboBox8.SelectedItem == "parrots")
            {
                    parrots.Eat(35);
            }
            else if (comboBox8.SelectedItem == "flamingos")
            {
                    flamboyance.Eat(25);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lions lions = new Lions();
            bears bears = new bears();
            parrots parrots = new parrots();
            flamboyance flamboyance = new flamboyance();
            lions.HabitatType = HabitatType.Savannah;
            bears.HabitatType = HabitatType.Forest;
            parrots.HabitatType = HabitatType.Forest;
            flamboyance.HabitatType = HabitatType.Aquatic;

            int Add;

            if (comboBox8.SelectedItem == "Lions")
            {

                if (!(textBox17.Text == ""))
                {
                    try
                    {
                        Add = int.Parse(textBox17.Text);
                        Console.WriteLine($"The lion eats {lions.FoodType} and lives in {lions.HabitatType}.");
                        lions.Move(Add,Add);
                        lions.Climb();
                        lions.Swim();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Must be an integer", "Incorrect input type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            else if (comboBox8.SelectedItem == "Bears")
            {
                Console.WriteLine($"The bear eats {bears.FoodType} and lives in {bears.HabitatType}.");
                bears.Move(45,10);
                bears.Climb();
                bears.Swim();
            }

            else if (comboBox8.SelectedItem == "parrots")
            {
                Console.WriteLine($"The parrot eats {parrots.FoodType} and lives in {parrots.HabitatType}.");
                parrots.flight(35,20);
                parrots.Swim();
            }
            else if (comboBox8.SelectedItem == "flamingos")
            {
                Console.WriteLine($"The flamingo eats {flamboyance.FoodType} and lives in {flamboyance.HabitatType}.");
                flamboyance.flight(25,10);
                flamboyance.Swim();
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lions lions = new Lions();
            bears bears = new bears();
            parrots parrots = new parrots();
            flamboyance flamboyance = new flamboyance();
            snakes snakes = new snakes();
            lions.FoodType = FoodType.Meat;
            bears.FoodType = FoodType.Fish;
            parrots.FoodType = FoodType.Fruit_and_berries;
            flamboyance.FoodType = FoodType.Mixed;

            if (comboBox1.SelectedItem == "Lions")
            {
                MessageBox.Show("Please pick the Lions meal for today");
                if (comboBox4.SelectedItem == "Meat")
                {
                    lions.Feed(50);
                    MessageBox.Show($"The Lions are eating {lions.FoodType}");
                }
                else if (comboBox4.SelectedItem == "Fish")
                {
                    lions.Feed(25);
                }
                else if (comboBox4.SelectedItem == "Friuts")
                {
                    lions.Feed(15);
                }
                else if (comboBox4.SelectedItem == "Seeds")
                {
                    lions.Feed(5);
                }
                else if (comboBox4.SelectedItem == "Berries")
                {
                    lions.Feed(10);
                }

            }
            else if (comboBox1.SelectedItem == "Bears")
            {
                MessageBox.Show("Please pick the Bears meal for today");
                if (comboBox4.SelectedItem == "Meat")
                {
                    bears.Feed(30);
                    MessageBox.Show($"The Bears are eating {bears.FoodType}");
                }
                else if (comboBox4.SelectedItem == "Fish")
                {
                    bears.Feed(45);
                }
                else if (comboBox4.SelectedItem == "Friuts")
                {
                    bears.Feed(25);
                }
                else if (comboBox4.SelectedItem == "Seeds")
                {
                    bears.Feed(5);
                }
                else if (comboBox4.SelectedItem == "Berries")
                {
                    bears.Feed(15);
                }


            }

            else if (comboBox2.SelectedItem == "snakes")
            {
                MessageBox.Show("Welcome to the Bird Habitat");

            }
            else if (comboBox8.SelectedItem == "turtles")
            {
                MessageBox.Show("Welcome to the Bird Habitat");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lions lions = new Lions();
            bears bears = new bears();
            parrots parrots = new parrots();
            flamboyance flamboyance = new flamboyance();
            snakes snakes = new snakes();
            lions.FoodType = FoodType.Meat;
            bears.FoodType = FoodType.Fish;
            parrots.FoodType = FoodType.Fruit_and_berries;
            flamboyance.FoodType = FoodType.Mixed;


            if (comboBox2.SelectedItem == "parrots")
            {
                MessageBox.Show("Welcome to the Bird Habitat");
                if(comboBox5.SelectedItem == "Friuts")
                {
                    parrots.Feed(35);
                    MessageBox.Show($"The parrots are eating {parrots.FoodType}");
                }
                else if (comboBox5.SelectedItem == "Seeds")
                {
                    parrots.Feed(25);
                }
                else if (comboBox5.SelectedItem == "Berries")
                {
                    parrots.Feed(15);
                }

            }
            else if (comboBox2.SelectedItem == "flamingos")
            {
                if (comboBox5.SelectedItem == "Fish")
                {
                    flamboyance.Feed(45);
                    MessageBox.Show($"The flamingos are eating {flamboyance.FoodType}");
                }
                else if (comboBox5.SelectedItem == "Friuts")
                {
                    flamboyance.Feed(35);
                }
                else if (comboBox5.SelectedItem == "Seeds")
                {
                    flamboyance.Feed(15);
                }
                else if (comboBox5.SelectedItem == "Berries")
                {
                    flamboyance.Feed(25);
                }

            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }

    public interface IClimbable
    {
        void Climb();
    }
    public interface ISwimmable
{
        void Swim();

    }
    public interface IFlying
    {
        void flight();

    }

    public enum AnimalType
    {
        Mammal,
        Bird,
        Reptile
    }

    public enum FoodType
    {
        Meat,
        Fish,
        Fruit_and_berries,
        Mixed
    }

    public enum HabitatType
    {
        Desert,
        Savannah,
        Forest,
        Aquatic
    }

    public abstract class Animals : IClimbable, ISwimmable
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public FoodType FoodType { get; set; }
        public HabitatType HabitatType { get; set; }

        public virtual void Eat()
        {
            MessageBox.Show($"{Name} is eating.");
        }

        public virtual void Sleep()
        {
            MessageBox.Show($"{Name} is sleeping.");
        }
        public virtual void Move(int Steps, int speed)
        {
            int Distance = Steps * speed;
            MessageBox.Show("The animal is moving.");
        }


        public void Climb()
        {
            MessageBox.Show($"The {Name} is Climbing.");
        }

        public void Swim()
        {
            MessageBox.Show($"The {Name} is Swim.");
        }
    }

    public class mammal : Animals
    {
        public void Feed(int quantity)
        {
            MessageBox.Show("The mammals are Eating.");
        }
    }
    public class Lions : mammal
    {
        private int HungerLevel;
        private const int MaxHungerLevel = 100;
        private const int MinHungerLevel = 0;
        private const int SatietyLevel = 48;
        private DateTime LastFedTime;
        public override void Move(int Steps, int speed)
        {
            int distance = Steps * speed;
            MessageBox.Show($"This lion is moving at speed of " + speed + "km and as moved " + Steps + " Steps\t\n");
            if (speed == 10 && Steps == 30)
            {
                MessageBox.Show("The lion is running.");
            }
            else if (speed < 20 && Steps < 50)
            {
                MessageBox.Show("The lion is run very fast");
            }
            else if (speed < 30 && Steps < 60)
            {
                MessageBox.Show("The lion as reached the end of the encloser\t\n");
            }
            else
            {
                MessageBox.Show("The lion is not moving");
            }

        }
        public Lions()
        {
            HungerLevel = MaxHungerLevel;
            LastFedTime = DateTime.Now;
        }
        public void Feed(int quantity)
        {
            if (IsHungry())
            {
                Eat(quantity);
                LastFedTime = DateTime.Now;
            }
            else
            {
                MessageBox.Show("The Lions are still full from the last time you fed them.\t\n");
            }

        }
        private bool IsHungry()
        {
            return HungerLevel > SatietyLevel;
        }
        public void Eat(int quantity)
        {
            // Simulate the lion eating
            HungerLevel -= quantity;
            if (HungerLevel < MinHungerLevel)
            {
                HungerLevel = MinHungerLevel;
            }
            MessageBox.Show($"The lion {Name} is eating.\t\n");
        }

        public virtual void Swim()
        {
            MessageBox.Show($"The lion {Name} can't swim.\t\n");
        }
        public virtual void Climb()
        {
            MessageBox.Show($"The lion {Name} can't Climb.\t\n");
        }

        public override void Sleep()
        {
            MessageBox.Show($"The lion {Name} is sleeping for 12 hours.\t\n");
        }


    }
    public class bears : mammal,IClimbable
    {
        private int HungerLevel;
        private const int MaxHungerLevel = 100;
        private const int MinHungerLevel = 0;
        private const int SatietyLevel = 48;
        private DateTime LastFedTime;
        public override void Move(int Steps, int speed)
        {
            int distance = Steps * speed;
            MessageBox.Show($"This Bear called {Name} is moving at speed of " + speed + "km and as moved " + Steps + " Steps\t\n");
            if (speed == 10 && Steps == 30)
            {
                MessageBox.Show("The Bear called are moving.\t\n");
            }
            else if (speed < 10 && Steps < 20)
            {
                MessageBox.Show("The Bear called is run very fast\t\n");
            }
            else if (speed < 30 && Steps < 40)
            {
                MessageBox.Show("The Bear as reached the end of the encloser\t\n");
            }
            else
            {
                MessageBox.Show("The Bear aren't moving");
            }

        }
        public void Feed(int quantity)
        {
            if (IsHungry())
            {
                Eat(quantity);
                LastFedTime = DateTime.Now;
                MessageBox.Show($"The Bear {Name} is eating");
            }
            else
            {
                MessageBox.Show($"The bear {Name} is eaten salmon and berrys.\t\n");
                MessageBox.Show($"The Bear {Name} are still full from the last time you fed them.\t\n");
            }
            MessageBox.Show("The Bears are Eating.\t\n");
        }
        public void Eat(int quantity)
        {

            HungerLevel -= quantity;
            if (HungerLevel < MinHungerLevel)
            {
                HungerLevel = MinHungerLevel;
            }
            MessageBox.Show($"The bear {Name} is eating salmon and berrys.\t\n");
        }
        private bool IsHungry()
        {
            return HungerLevel > SatietyLevel;
        }


        public virtual void Swim()
        {
            MessageBox.Show($"The Bear {Name} goes swiming and catches some salmon.\t\n");
        }
        public virtual void Climb()
        {
            MessageBox.Show($"The Bear {Name} can't Climb BREAKS THE TREE AND ANGER.\t\n");
        }



        public override void Sleep()
        {
            MessageBox.Show($"The Bears {Name} is sleeping for 4-6 hours.\t\n");
        }

    }



    public class Birds : Animals, ISwimmable
    {
        public void Swim()
        {
            MessageBox.Show($"The Animal {Name} are Swimming");
        }
    }
    public class parrots : Birds, IFlying
    {
        private int HungerLevel;
        private const int MaxHungerLevel = 100;
        private const int MinHungerLevel = 0;
        private const int SatietyLevel = 48;
        private DateTime LastFedTime;
        public void flight(int height, int distance)
        {
            int speed = height * distance;
            MessageBox.Show("The Parrots is flying at a speed of " + speed + "km\t\n");
            MessageBox.Show("The Parrots are flying\t\n");
        }
        public virtual void Swim()
        {
            MessageBox.Show($"The Parrots {Name} are Swimming");
        }

        public void Feed(int quantity)
        {
            MessageBox.Show("The Parrots are Eating.\t\n");
        }
        public void Eat(int quantity)
        {
            // Simulate the lion eating
            HungerLevel -= quantity;
            if (HungerLevel < MinHungerLevel)
            {
                HungerLevel = MinHungerLevel;
            }
            MessageBox.Show($"The Parrots {Name} is eating Seeds and berrys.\t\n");
        }

        public override void Sleep()
        {
            MessageBox.Show($"The Parrots {Name} is sleeping for 1-3 hours.\t\n");
            MessageBox.Show($"Please {Name} come back again later\t\n");
        }

        public void flight()
        {
            throw new NotImplementedException();
        }
    }
    public class flamboyance : Birds, IFlying
    {
        private int HungerLevel;
        private const int MaxHungerLevel = 100;
        private const int MinHungerLevel = 0;
        private const int SatietyLevel = 48;
        private DateTime LastFedTime;

        public void flight(int height, int distance)
        {
            int speed = height * distance;
            MessageBox.Show("The flamingo is flying at a speed of " + speed + "km");
            MessageBox.Show("The flamingo are flying");
        }

        public virtual void Swims()
        {
            MessageBox.Show($"The flamingo {Name} are Swimming");
        }

        public void Feed(int quantity)
        {
            MessageBox.Show("The flamingo are Eating.\t\n");
        }
        public void Eat(int quantity)
        {
            HungerLevel -= quantity;
            if (HungerLevel < MinHungerLevel)
            {
                HungerLevel = MinHungerLevel;
            }

            MessageBox.Show($"The flamingo {Name} is eating Seeds and berrys.\t\n");
        }

        public void Sleep()
        {
            MessageBox.Show($"The flamingo {Name} is sleeping for 4-6 hours.\t\n");
        }

        public void flight()
        {
            throw new NotImplementedException();
        }
    }


    public class Reptiles : Animals
    {

    }
    public class snakes : Reptiles
    {
        //private int HungerLevel;
        //private const int MaxHungerLevel = 100;
       //private const int MinHungerLevel = 0;
       //private const int SatietyLevel = 48;
      // private DateTime LastFedTime;
       public void Feed(int quantity)
        {
            throw new NotImplementedException();
        }
    }

    public class turtles : Reptiles
    {
        public void Feed(int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
//HAHA this is test





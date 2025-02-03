![image](https://github.com/user-attachments/assets/fa1b0be2-907f-4c65-bc7a-5c7a1cf2fdb5)

    
    public class BlackCoffee   //เก็บ
    {
        public double Water;
        public double Coffee; 
    }
    
    public class Mocca {
        public double Water;
        public double Coffee;
        public double Choco;
    
    }
    public class Latte
    {
        public double Water;
        public double Coffee;
        public double Milk;
    }
    public class Chocolate
    {
        public double Water;
        public double Choco;
    }
    public class ConInt1
    {
      public (double INwater , double INCof, double INMilk, double INChocolate) convert(TextBox item1,TextBox item2,TextBox item3,TextBox item4)

        {
            string inWater = item1.Text;
            string inCof = item2.Text;
            string inMilk = item3.Text;
            string inChoco = item4.Text;
            double Cof = 0;
            double Water = 0;
            double Milk = 0;
            double Choco = 0;
            try
            {
                Water = double.Parse(inWater);
            }
            catch (FormatException)
            {
            }
            try
            {
                Cof = double.Parse(inCof);
            }
            catch (FormatException) { }
            try
            {
                Milk = double.Parse(inMilk);
            }
            catch { }
            try
            {
                Choco = double.Parse(inChoco);
            }
            catch { }
            double INwater = Water;
            double INCof = Cof;
            double INMilk = Milk;
            double INChocolate = Choco;
            return (INwater,INCof,INMilk,INChocolate);
        }

    }
    public class INStock
    {



        public double INwater;
        public double INCof;
        public double INMilk;
        public double INChocolate;
    }
    public class BuyDrink1
    {
        public (double OutWater, double OutCof, double OutChocolate) BuyDrink(TextBox item1, TextBox item2)

            string inCof = item2.Text;  // item2 = กาแฟ
            string inWater = item1.Text;
            string inChoco = item2.Text;// item1 = น้ำ

            int Cof = 0;
            int Water = 0;
            int Choco = 0;

            try
            {
                Cof = int.Parse(inCof);
                Water = int.Parse(inWater);
            }
            catch (FormatException)
            {
                Console.WriteLine("รูปแบบข้อมูลไม่ถูกต้อง");
            }

            double OutCof = Cof;
            double OutWater = Water;
            double OutChoco = Choco;


           
                OutCof = Cof - 20;
                OutWater = Water - 300;
            OutChoco = OutCof;
           
            

            return (OutWater,OutCof,OutChoco); // ✅ คืนค่า Tuple

    }
    public class BuyDrink02
    {
        public (double OutWater, double OutCof, double OutMike,double OutChocolate) BuyDrink2(TextBox item1, TextBox item2, TextBox item3)
        {
            string inCof = item2.Text;
            string inWater = item1.Text;
            string inMike = item3.Text;
            string inChoco = item3.Text;

            int Cof = 0;
            int Water = 0;
            int Mike = 0;
            int Choco = 0;
            try
            {
                Cof = int.Parse(inCof);
                Water = int.Parse(inWater);
                Mike = int.Parse(inMike);
                Choco = int.Parse(inChoco);
            }
            catch (FormatException)
            {
                Console.WriteLine("รูปแบบข้อมูลไม่ถูกต้อง");
            }

            // กำหนดค่าเริ่มต้นใหม่หลังจาก parse
            double OutCof = Cof;
            double OutWater = Water;
            double OutMike = Mike;
            double OutChocolate = Choco;

            // ปรับค่าตามเงื่อนไข


            OutCof = Cof - 20;
            OutWater = Water - 300;
            OutMike = Mike - 10;
            OutChocolate = Choco - 10;

            return (OutWater, OutCof, OutMike,OutChocolate);
        }
    }

    public class StockUp {
        public (double StockWater, double StockCof, double StockMilk, double StockChocolate) StockUp1(INStock stock,TextBox stock1, TextBox stock2, TextBox stock3,TextBox stock4) {
            string in1 = stock1.Text;
            string in2 = stock2.Text;
            string in3 = stock3.Text;
            string in4 = stock4.Text;

            double water = 0;
            double Cof = 0;
            double Milk = 0;
            double Choco = 0;
            try
            {
                water = double.Parse(in1);
                Cof = double.Parse(in2);
                Milk = double.Parse(in3);
                Choco = double.Parse(in4);
            }
            catch (FormatException)
            {
                Console.WriteLine("รูปแบบข้อมูลไม่ถูกต้อง");
            }
            double StockWater = water ;
            double StockCof = Cof;
            double StockMilk = Milk ;
            double StockChocolate = Choco;
            StockWater = StockWater += stock.INwater;
            StockCof = StockCof += stock.INCof;
            StockMilk = StockMilk += stock.INMilk;
            StockChocolate = StockChocolate += stock.INChocolate;
            return  (StockWater, StockCof, StockMilk, StockChocolate);
        }
    
    
    
    }


คำอธิบายโครงสร้างและการทำงานของแต่ละคลาส
1. คลาสสำหรับเก็บข้อมูลสูตรเครื่องดื่ม
BlackCoffee

Attributes:
Water: ปริมาณน้ำในเครื่องดื่ม
Coffee: ปริมาณกาแฟในเครื่องดื่ม
หน้าที่: เก็บข้อมูลสูตรสำหรับกาแฟดำที่มีเพียงน้ำและกาแฟ
Mocca

Attributes:
Water: ปริมาณน้ำ
Coffee: ปริมาณกาแฟ
Choco: ปริมาณช็อกโกแลต
หน้าที่: เก็บข้อมูลสูตรสำหรับ Mocca ซึ่งมีส่วนผสมของน้ำ กาแฟ และช็อกโกแลต
Latte

Attributes:
Water: ปริมาณน้ำ
Coffee: ปริมาณกาแฟ
Milk: ปริมาณนม
หน้าที่: เก็บข้อมูลสูตรสำหรับลาเต้ที่ประกอบด้วยน้ำ กาแฟ และนม
Chocolate

Attributes:
Water: ปริมาณน้ำ
Choco: ปริมาณช็อกโกแลต
หน้าที่: เก็บข้อมูลสูตรสำหรับเครื่องดื่มช็อกโกแลต
2. คลาสสำหรับการแปลงข้อมูลและจัดการสต็อกวัตถุดิบ
ConInt1

Method: convert(TextBox item1, TextBox item2, TextBox item3, TextBox item4)
หน้าที่:
รับค่าอินพุตจาก TextBox 4 ตัว
แปลงค่าเป็น double สำหรับแต่ละส่วนผสม (น้ำ, กาแฟ, นม, ช็อกโกแลต)
คืนค่าเป็น tuple (INwater, INCof, INMilk, INChocolate)
INStock

Attributes:
INwater, INCof, INMilk, INChocolate
หน้าที่: เก็บข้อมูลสต็อกวัตถุดิบที่มีอยู่
StockUp

Method: StockUp1(INStock stock, TextBox stock1, TextBox stock2, TextBox stock3, TextBox stock4)
หน้าที่:
อ่านข้อมูลปริมาณวัตถุดิบจาก TextBox
แปลงเป็นตัวเลขและรวมกับสต็อกใน INStock
คืนค่าเป็น tuple ของสต็อกที่อัปเดต (StockWater, StockCof, StockMilk, StockChocolate)
3. คลาสสำหรับการคำนวณวัตถุดิบที่ใช้ในการสั่งซื้อเครื่องดื่ม
BuyDrink1

Method: BuyDrink(TextBox item1, TextBox item2)
หน้าที่:
รับค่าอินพุตจาก TextBox สำหรับน้ำและกาแฟ
แปลงเป็นตัวเลขและหักจำนวนวัตถุดิบ (หักกาแฟ 20 หน่วย และน้ำ 300 หน่วย)
คืนค่าเป็น tuple (OutWater, OutCof, OutChocolate)
(ในโค้ด ช็อกโกแลตถูกคำนวณให้เท่ากับค่ากาแฟหลังหัก)
BuyDrink02

Method: BuyDrink2(TextBox item1, TextBox item2, TextBox item3)
หน้าที่:
รับค่าอินพุตจาก TextBox สำหรับน้ำ, กาแฟ และนมหรือช็อกโกแลต (ใช้ TextBox ตัวที่ 3สำหรับทั้งสอง)
แปลงเป็นตัวเลขและหักจำนวนวัตถุดิบ (หักกาแฟ 20, น้ำ 300, และนมหรือช็อกโกแลต 10 หน่วย)
คืนค่าเป็น tuple (OutWater, OutCof, OutMike, OutChocolate)






![image](https://github.com/user-attachments/assets/fa1b0be2-907f-4c65-bc7a-5c7a1cf2fdb5)


1. คลาสสำหรับเก็บข้อมูลสูตรเครื่องดื่ม

public class BlackCoffee
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
BlackCoffee

Attributes:
Water: ปริมาณน้ำในเครื่องดื่ม
Coffee: ปริมาณกาแฟในเครื่องดื่ม
อธิบาย: คลาสนี้ใช้เก็บข้อมูลสูตรของกาแฟดำ ซึ่งประกอบด้วยน้ำและกาแฟเท่านั้น
Mocca

Attributes:
Water: ปริมาณน้ำในเครื่องดื่ม
Coffee: ปริมาณกาแฟในเครื่องดื่ม
Choco: ปริมาณช็อกโกแลตในเครื่องดื่ม
อธิบาย: คลาสนี้ใช้เก็บข้อมูลสูตรของ Mocca ที่มีส่วนผสมของน้ำ กาแฟ และช็อกโกแลต
Latte

Attributes:
Water: ปริมาณน้ำในเครื่องดื่ม
Coffee: ปริมาณกาแฟในเครื่องดื่ม
Milk: ปริมาณนมในเครื่องดื่ม
อธิบาย: คลาสนี้ใช้เก็บข้อมูลสูตรของลาเต้ ที่มีส่วนผสมของน้ำ กาแฟ และนม
Chocolate

Attributes:
Water: ปริมาณน้ำในเครื่องดื่ม
Choco: ปริมาณช็อกโกแลตในเครื่องดื่ม
อธิบาย: คลาสนี้ใช้เก็บข้อมูลสูตรของเครื่องดื่มช็อกโกแลต ซึ่งประกอบด้วยน้ำและช็อกโกแลต
2. คลาสสำหรับจัดการกับการแปลงข้อมูลและสต๊อกวัตถุดิบ

ConInt1
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

Method: convert(TextBox item1, TextBox item2, TextBox item3, TextBox item4)
การทำงาน:
รับค่าจาก TextBox ทั้ง 4 ตัว ซึ่งคาดว่าจะเป็นข้อความที่เป็นตัวเลข
พยายามแปลงค่าที่ได้เป็น double สำหรับน้ำ, กาแฟ, นม และช็อกโกแลต
คืนค่าเป็น tuple (INwater, INCof, INMilk, INChocolate)
อธิบาย: คลาสนี้เป็น utility สำหรับแปลงข้อมูลอินพุตที่มาจาก UI (TextBox) ให้เป็นตัวเลขที่สามารถนำไปคำนวณต่อได้
INStock
public class INStock
{



    public double INwater;
    public double INCof;
    public double INMilk;
    public double INChocolate;
}

Attributes:
INwater, INCof, INMilk, INChocolate
อธิบาย: คลาสนี้ใช้เก็บค่าปริมาณวัตถุดิบที่มีอยู่ในสต๊อก โดยข้อมูลเหล่านี้จะถูกอัปเดตและนำไปใช้ในการคำนวณเมนูเครื่องดื่ม
StockUp
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

Method: StockUp1(INStock stock, TextBox stock1, TextBox stock2, TextBox stock3, TextBox stock4)
การทำงาน:
อ่านข้อมูลปริมาณวัตถุดิบจาก TextBox ที่ส่งเข้ามา
แปลงค่าเป็น double และนำมารวมกับค่าที่มีอยู่ในอ็อบเจ็กต์ INStock
คืนค่าเป็น tuple ที่ประกอบด้วยปริมาณวัตถุดิบที่อัปเดตแล้ว (StockWater, StockCof, StockMilk, StockChocolate)
อธิบาย: ใช้สำหรับอัปเดตหรือเพิ่มสต๊อกวัตถุดิบโดยการนำข้อมูลใหม่มารวมกับสต๊อกที่มีอยู่
3. คลาสสำหรับการซื้อและคำนวณการใช้วัตถุดิบในเครื่องดื่ม
BuyDrink1
    public class BuyDrink1
    {
        public (double OutWater, double OutCof, double OutChocolate) BuyDrink(TextBox item1, TextBox item2)
{
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
    }
Method: BuyDrink(TextBox item1, TextBox item2)
การทำงาน:
รับค่าอินพุตจาก TextBox สำหรับน้ำและกาแฟ
แปลงค่าที่ได้เป็นตัวเลข (int) และจากนั้นคำนวณการหักส่วนผสมออก โดยในที่นี้:
หักกาแฟ 20 หน่วย
หักน้ำ 300 หน่วย
คืนค่าเป็น tuple (OutWater, OutCof, OutChocolate)
ในโค้ดนี้ค่าช็อกโกแลตถูกกำหนดให้เท่ากับค่ากาแฟหลังการหัก (อาจเป็นการคำนวณที่ต้องปรับปรุงเพิ่มเติม)
อธิบาย: ใช้สำหรับคำนวณวัตถุดิบที่เหลือหลังจากมีการสั่งเครื่องดื่มประเภทที่ใช้เพียงน้ำและกาแฟ
BuyDrink02
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
Method: BuyDrink2(TextBox item1, TextBox item2, TextBox item3)
การทำงาน:
รับค่าอินพุตจาก TextBox สำหรับน้ำ, กาแฟ, และนมหรือช็อกโกแลต (ในโค้ดมีการใช้ TextBox ตัวที่ 3สำหรับทั้งนมและช็อกโกแลต)
แปลงค่าเป็นตัวเลข จากนั้นหักปริมาณ:
หักกาแฟ 20 หน่วย
หักน้ำ 300 หน่วย
หักนมหรือช็อกโกแลต 10 หน่วย
คืนค่าเป็น tuple (OutWater, OutCof, OutMike, OutChocolate)
อธิบาย: คลาสนี้เหมาะสำหรับเครื่องดื่มที่มีการใช้วัตถุดิบหลายชนิด (น้ำ, กาแฟ, นม และช็อกโกแลต) โดยมีการคำนวณหักปริมาณตามสูตรที่กำหนด

internal class Program
{
    private static void Main(string[] args)
    {
        int number1, number2, number3;
         
        Console.WriteLine("Dizi kaç sayıdan oluşsun?");
        number3= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dizin ilk sayısını giriniz");
        number1= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dizi ikinci sayısını giriniz?");
        number2= Convert.ToInt32(Console.ReadLine());

        int[] numList = new int[number3];
        numList[0]=number1;
        numList[1]=number2;
        int sum =0;
        //diziye eleman ekleme
        for (int i = 0; i < number3-2; i++)
        {
            numList[i+2]=numList[i]+numList[i+1];
        }

        //dizinin elemanlarını görme-toplama ve ortalama alma
        Console.WriteLine("Dizinin elemanları aşağıda sıralanmıştır;");
        for (int j = 0; j < number3; j++)
        {
            Console.WriteLine(numList[j]);
            sum = numList[j]+sum;
        }
        Console.WriteLine("Dizinin toplamı : "+sum);
        Console.WriteLine("Dizideki sayıların ortalaması : "+sum/number3);


       


    }
    
}
public class Program {
     static void Main (){
        double Y,M,D;

        Console.Write("input Y :");
        Y = double.Parse(Console.ReadLine());
        
        Console.Write("input M :");
        M = double.Parse(Console.ReadLine());
        
        Console.Write("input D :");
        D = double.Parse(Console.ReadLine());

        double sum = Y+(M/100)+(D/10000);
        string yuk  = "";
        if (sum >= 2019.0501){
            yuk = "令和 (เรวะ)";
        }
        else if (sum >= 1989.0108){
            yuk = "平成 (เฮเซ)";
        }
        else if (sum >= 1926.1225){
            yuk = "昭和 (โชวะ)";
        }
        else if (sum >= 1912.0730){
            yuk = "大正 (ไทโช)";
        }
        else if (sum >= 1896.0808){
            yuk = "明治 (เมจิ)";
        }
        else {
            Console.WriteLine("Error");
        }
        Console.WriteLine("YUK = {0}",yuk);
     }
}
using System ;

namespace CoreProgramming{

    public class CoreProgramming{

          public static void flipacoin(int n ){
            Random random = new Random();
            int head =0;
            int tails =0;
           
            for(int i =0; i<5;i++){
                double value = random.NextDouble();
                if(value<0.5 ){
                    head = head + 1;
                }else{
                    tails = tails+1;
                }
            }
            Console.WriteLine(head);
            Console.WriteLine(tails);
            double headPercentage = ((double) head/n) * 100;
            Console.WriteLine(headPercentage);
            double tailPercentage = ((double)tails / n) * 100;
            Console.WriteLine("The percentage of Heads is {0}",headPercentage);
            Console.WriteLine("The percentage of Tails is {0}",tailPercentage);

        }
        public static void Leapyearornot(){
            Console.Write("enter the year ");
            int Year =  Convert.ToInt32(Console.ReadLine());
            int numberOfDigits = (int)Math.Floor(Math.Log10(Year) + 1);
            if(numberOfDigits == 4){
                if (Year%4 == 0){
                    Console.WriteLine("{0} is Leap year",Year);
                }else{
                        Console.WriteLine("{0} is not Leap year",Year);
                }
            }else{
                Console.WriteLine("please enter the 4 digit number");
            }

        }

         public static void Poweroftwo(){
            Console.Write("Enter the number ");
            int n =  Convert.ToInt32(Console.ReadLine());

            if(n>= 0 && n<31 ){
                int power =1;
                for(int i =0 ; i < n;i++){
                    power *=2;
                }
                Console.WriteLine("The exponent is {0}",power);
            }else{
                Console.WriteLine("enter the number below 31");
            }

        }

        public static void hormonic(){
            Console.WriteLine("enter the value of N");
            int n = Convert.ToInt16(Console.ReadLine());
            float sum = 0;
            if(n !=0){
                for (int i =1;i<n;i++){
                    sum = sum + 1 / (float)i;
                    
                }
                Console.WriteLine(sum);
            }else{
                Console.WriteLine("choose the number abouve 0");
            }
        }

        public static void evenoradd(){
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number % 2 == 0 ){
                Console.WriteLine("The given  Number {0} is even ",number);
            }else{
                Console.WriteLine("The given Number {0} is odd",number);
            }

        }

        public static void swapNumbers(){
            Console.WriteLine("enter the Value of A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of B");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swap a : {0} and  B : {1}",A,B);
            A = A * B;
            B = A / B;
            A = A /B;

            Console.WriteLine("After Swap A : {0} and B : {1}",A,B);   
        }

        public static void Quotient_and_Remainder(){

            Console.Write("Enter The Divident : ");
            int Divident = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Divisor : ");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            int Quuotient = Divident/Divisor;
            int Reminder = Divident % Divisor ;

            Console.WriteLine("Quotient is  {0}",Quuotient);
            Console.WriteLine("Reminder is  {0}", Reminder);

        }

        public static void LargestamongThree(){
            Console.Write("enter the value of A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the value of B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the value of C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A > B && A  >C ){
                Console.WriteLine("A is greatest number  {0}",A);
            }else if(B  > A &&  B > C){
                Console.WriteLine("The B is Greatest Number {0}",B);

            }else{
                Console.WriteLine("The C is the greatest Number {0}",C );
            }


        }




















    }
}
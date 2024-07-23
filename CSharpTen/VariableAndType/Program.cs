namespace VariableAndType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수란 값을 저장하는 곳!
            Console.Write("이름을 입력하세요: ");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("키를 입럭하세요: ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세, 키는");
            Console.Write(height);
            Console.WriteLine("cm 이시군요!");

        }
    }
}

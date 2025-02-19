namespace MyException
{
    public class InvalidArgumentException : Exception
    {
        public uint Argument { get; set; }
        public string Range { get; set; }
        public InvalidArgumentException(string message) : base(message)
        {
            // 부모 클래스(Exception)의 생성자
            // this.Message = message로 초기화 할 수 없음...readonly
        }
        public InvalidArgumentException()
        {
        }
    }
    internal class Program
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };

            foreach (uint arg in args)
            {
                if (arg > 255)
                    throw new InvalidArgumentException()
                    {
                        Argument = arg, // 입력값
                        Range = "0~255" // 적정 범위
                    };
            }

            return (alpha << 24 & 0xFF000000) |
                   (red << 16 & 0x00FF0000) |
                   (green << 8 & 0x0000FF00) |
                   (blue << 0 & 0x000000FF);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"0x{MergeARGB(255, 111, 111, 111)}");
                Console.WriteLine($"0x{MergeARGB(1, 65, 192, 128)}");
                Console.WriteLine($"0x{MergeARGB(0, 255, 255, 300)}");
            }
            catch (InvalidArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Argument:{e.Argument}, Range:{e.Range}");
            }
        }
    }
}

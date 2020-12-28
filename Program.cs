using System;

namespace 平方根
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("これは、ぴったりの数しか求めることができません。");
            Console.WriteLine("√何か入力してください。");
            string s_rute = Console.ReadLine();
            if(!seisuu_toka.seisuu_toka.seisuu(s_rute))
            {
                error("整数に変換できませんでした。");
            }
            if(s_rute == "0")
            {
                error("0は入力しないでください。");
            }
            long rute = long.Parse(s_rute);
            double fuyasu = 1;
            long kekka = 0;
            for_:
            for(long i = 0;i < rute;i++)
            {
                if(i * i == rute)
                {
                    kekka = i;
                }
            }
            if(kekka == 0)
            {
                fuyasu = fuyasu / 10;
                if(fuyasu == 0)
                {
                    error("変数が対応できなくなりました。");
                }
                Console.WriteLine($"失敗したので、レベルを{fuyasu}にします。");
                goto for_;
            }
            Console.WriteLine($"計算結果は、{kekka}です。");
            Console.WriteLine("何かキーを押すと終了します...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static void error(string error_message)
        {
            Console.WriteLine("エラーが発生しました。");
            Console.WriteLine(error_message);
            Console.WriteLine("何かキーを押すと終了します...");
            Console.ReadKey();
            Environment.Exit(1);
        }
    }
}
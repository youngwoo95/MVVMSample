namespace WpfExplorer
{
    internal class Starter
    {
        // * 프로그램 시작 진입적 역할
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App().Run();
        }
    }
}

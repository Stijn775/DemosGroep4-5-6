namespace Les3
{
    internal class CallbackMethode
    {

        public async Task LoadData(Action<int> action)
        {

            for (int i = 0; i < 10; i++)
            {

                Thread.Sleep(1000);
                action(new Random().Next(100));
            }

            ;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IGUIFactory factory = new WinFactory();
        IButton button = factory.CreateButton();
        ITextBox textBox = factory.CreateTextBox();
 
        button.Render();
        textBox.Render();

        factory = new MacFactory();
        button = factory.CreateButton();
        textBox = factory.CreateTextBox();

        button.Render();
        textBox.Render();
    }
}
public class Menu
{
    private string optionOne = "1. Start breathing activity";
    private string optionTwo = "2. Start reflecting activity";
    private string optionThree = "3. Start listing activity";
    private string optionFour = "4. Quit";

    public string GetMenu()
    {
        return $"\n<---------------------------------->\nWelcome to the Mindfulness Progarm!\n\nMenu Options: \n  {optionOne}\n  {optionTwo}\n  {optionThree}\n  {optionFour}\nSelect a choice from the menu: ";
    }
}
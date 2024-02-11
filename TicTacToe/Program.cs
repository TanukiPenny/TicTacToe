using System.Windows.Forms;

namespace TicTacToe;

static class Program
{
    
    static void Main(string[] args)
    {
        MainForm mainForm;
        
        // pass wins into new form
        if (args.Length > 0)
        {
            mainForm = new MainForm(args[0], args[1]);
            
        }
        else
        {
            mainForm = new MainForm("0", "0");
        }
        Application.Run(mainForm);
    }
}
using System.Diagnostics;

namespace Variant2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            CreateNewProcess("plus");
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            CreateNewProcess("minus");
        }

        private void butMultiple_Click(object sender, EventArgs e)
        {
            CreateNewProcess("multiple");
        }

        private void butDivide_Click(object sender, EventArgs e)
        {
            CreateNewProcess("divide");
        }

        private void CreateNewProcess(string operation)
        {
            var process = new Process();

            string currentDirectory = Directory.GetCurrentDirectory();
            var fileInfo = new FileInfo($"{currentDirectory}\\OperationApplication\\OperationApplication.exe");

            if (!fileInfo.Exists)
                return;

            process.StartInfo.FileName = $"{currentDirectory}\\OperationApplication\\OperationApplication.exe";

            process.StartInfo.ArgumentList.Add(operation);
            process.StartInfo.ArgumentList.Add(number1Box.Text);
            process.StartInfo.ArgumentList.Add(number2Box.Text);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            Task.Run(() =>
            {
                process.Start();
                var result = process.StandardOutput.ReadToEnd();

                Action action = () =>
                {
                    listBox1.Items.Add(result);
                    listBox1.Refresh();
                };

                if (listBox1.InvokeRequired)
                    listBox1.Invoke(action);
                else
                    action();
            });
        }

        private void number1Box_KeyPress(object sender, KeyPressEventArgs e) => ChechPressedChar(e);

        private void number2Box_KeyPress(object sender, KeyPressEventArgs e) => ChechPressedChar(e);

        private void ChechPressedChar(KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
namespace Day_7
{
    public partial class Form1 : Form
    {
        string path = string.Empty;
        string content = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void readFile_Click(object sender, EventArgs e)
        {
            //Open Dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Read File";
            openFileDialog.ShowDialog();

            //Path
            path = openFileDialog.FileName;

            //Read Content
            content = File.ReadAllText(path);
            readingRichTextBox.Text = content;
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            //Save Dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.ShowDialog();

            //Path
            path = saveFileDialog.FileName;

            //Add File
            File.Create(path);
        }

        private void removeFile_Click(object sender, EventArgs e)
        {
            //Remove File
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Remove";
            openFileDialog.ShowDialog();

            //Path
            path = openFileDialog.FileName;

            //Remove File
            File.Delete(path);
        }

        private void docFile_Click(object sender, EventArgs e)
        {
            //Save Dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "docx";
            saveFileDialog.ShowDialog();

            //Path
            path = saveFileDialog.FileName;

            //Add File
            File.Create(path);
        }
    }
}

using indeed.com.models;
using System.Windows.Forms;

namespace indeed.com.parser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void d()
        {
            ParserRequest request = new ParserRequestBuilder()
                .FindJob("jdjdj")
                .InCity("city")
                .WithSalary(1)
                .Build();
        }
    }
}

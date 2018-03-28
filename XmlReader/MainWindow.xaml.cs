using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using XmlCitac.Class;

namespace XmlCitac
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Osobe> lista = new List<Osobe>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           

            XmlTextReader reader = new XmlTextReader("C:/listaemail.xml");

            while (reader.Read())
            {
                var a = new Osobe();
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.

                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name == "email")
                            {
                               
                                a.email = reader.Value;
                                lista.Add(a);                             
                            }
                            if (reader.Name == "prezimeime")
                            {

                                a.prezimeime = reader.Value;
                                lista.Add(a);
                            }

                            if (reader.Name == "adresa")
                            {

                                a.adresa = reader.Value;
                                lista.Add(a);
                            }
                            if (reader.Name == "datumrodjenja")
                            {

                                a.datumrodjenja = reader.Value;
                                lista.Add(a);
                            }
                            if (reader.Name == "brojtelefona")
                            {

                                a.brojtelefona = reader.Value;
                                lista.Add(a);
                            }
                        }

                        break;
                }
                
            }

            foreach (var item in lista.Distinct())
            {
                dataGridClanoviIgraci.Items.Add(item);
            }
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            dataGridClanoviIgraci.SelectAllCells();
            dataGridClanoviIgraci.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, dataGridClanoviIgraci);
            dataGridClanoviIgraci.UnselectAllCells();
            String result = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            File.AppendAllText("C:\\lista.csv", result, Encoding.UTF8);
        }
    }
}

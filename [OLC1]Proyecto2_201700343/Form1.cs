using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Irony.Parsing;
namespace _OLC1_Proyecto2_201700343
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void erroresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void compilarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1 gramatica = new Class1();
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser parse = new Parser(lenguaje);
            ParseTree cedro = parse.Parse(richTextBox1.Text);
            if (cedro.Root != null)
            {
                Console.WriteLine(cedro.ParserMessages.Count());
                for (int i = 0; i < cedro.ParserMessages.Count(); i++)
                {
                    Console.WriteLine(cedro.ParserMessages.ElementAt(i).Message + " " + cedro.ParserMessages.ElementAt(i).Location.Line);
                }
                Console.WriteLine("correcto");
            }
            else
            {

                Console.WriteLine(cedro.ParserMessages.Count());
                for(int i = 0; i < cedro.ParserMessages.Count();i++)
                {
                    Console.WriteLine(cedro.ParserMessages.ElementAt(i).Message+" "+cedro.ParserMessages.ElementAt(i).Location.Line);
                }
                Console.WriteLine("incorrecto");
            }


             
        }
    }
}

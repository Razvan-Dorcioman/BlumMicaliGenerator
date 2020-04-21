using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigNumberGenerator
{
    public partial class MainForm : Form
    {
        private BlumMicalGenerator _blumMicalGenerator;
        public MainForm()
        {
            InitializeComponent();

            var safePrime = BigInteger.Parse("45792590961032426879");
            var someValue = BigInteger.Parse("97484683765418940923");

            //a few 50 digit safe primes to play with:
            //var v1 = BigInteger.Parse("35707516168479785771797981373542410151981709510147");
            //var v2 = BigInteger.Parse("67900515765101717201431937816070398614160355475187");

            //a few 100 digit safe primes to play with:
            //var v1 = BigInteger.Parse("3089014570559104071319006923413060128665200110584708220833159771123973154612557115837845252375278767");
            //var v2 = BigInteger.Parse("9570534401487121496467970925158867173311659260360449216698291705369543311625846657862708743879011967");

            //calculate a primitive root
            var generator = PrimitiveRoots.GetPrimitiveRootOfSafePrime(safePrime);

            if (generator == 0) throw new Exception("Could not find a primitive root of this prime!  Try using a safe prime where P % 8 = 3 or 7.");

            //initialize the blum micali algorithm
            _blumMicalGenerator = new BlumMicalGenerator(someValue, safePrime, generator);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var fileName = "C:\\Users\\razvan.dorcioman\\source\\repos\\BigNumberGenerator\\BigNumberGenerator\\output.txt";
            var mb = Convert.ToInt32(sizeNumericUpDown.Value);
            //request a few bytes
            var bts = _blumMicalGenerator.GetRandomBytes(mb* 1024*1024).ToList();
            //show the bytes generated
           // File.WriteAllText(, bts.ToString());

            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(bts.ToArray());
            }
        }
    }
}

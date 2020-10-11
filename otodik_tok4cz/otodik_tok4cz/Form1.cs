using otodik_tok4cz.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otodik_tok4cz
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        List<Tick> Ticks;
        List<PortfolioItem> Portfolio = new List<PortfolioItem>();


        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList();
            dataGridView1.DataSource = Ticks;
            CreatePortfolio();
        }

        private decimal GetPortfolioValue(DateTime date)
        {
            decimal value = 0;
            foreach (var item in Portfolio)
            {
                var last = (from x in Ticks
                            where item.Index == x.Index.Trim()
                               && date <= x.TradingDay
                            select x)
                            .First();
                value += (decimal)last.Price * item.Volume;
            }
            return value;
        }

        private void CreatePortfolio()
        {
            Portfolio.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });

            dataGridView2.DataSource = Portfolio;
        }

        private void saving_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            sfd.AddExtension = true;
            sfd.Title = "save";

            if (sfd.FileName != "")
            {


                List<decimal> Nyereségek = new List<decimal>();
                int intervallum = 30;
                DateTime KezdőDátum = (from x in Ticks select x.TradingDay).Min();
                DateTime záróDátum = new DateTime(2016, 12, 30);
                TimeSpan z = záróDátum - KezdőDátum;
                for (int i = 0; i < z.Days - intervallum; i++)
                {
                    decimal ny = GetPortfolioValue(KezdőDátum.AddDays(i + intervallum))
                                - GetPortfolioValue(KezdőDátum.AddDays(i));
                    Nyereségek.Add(ny);
                    Console.WriteLine(i + "" + ny);

                }

                var nyereségekRendezve = (from x in Nyereségek
                                          orderby x
                                          select x)
                                          .ToList();
                MessageBox.Show(nyereségekRendezve[nyereségekRendezve.Count() / 5].ToString());


                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    sw.WriteLine("Időszak; Nyereség");

                    for (int i = 0; i < nyereségekRendezve.Count; i++)
                    {
                        sw.WriteLine(i + ";" + nyereségekRendezve[i]);
                    }

                }
            }
        }
    }
}

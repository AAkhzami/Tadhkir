using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tadhkir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CheckTimeSet();
            timer1.Start();
        }

        void CheckTimeSet()
        {
            int second = ((int)nudSecond.Value) * 1000;
            int Min = ((int)nudMinute.Value) * 60000;
            int result = Min + second;

            timer1.Interval = result;
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckTimeSet();
            timer1.Stop();
            notifyIcon1.Visible = true;
            notifyIcon1.Icon = SystemIcons.Information;
        }
        
        string GetRandomText()
        {
            string[] adhkar = new string[]
                    {
                        "أستغفر الله",
                        "أستغفر الله العظيم",
                        "أستغفر الله العظيم وأتوب إليه",
                        "اللهم اغفر لي وتب عليّ إنك أنت التواب الرحيم",
                        "رب اغفر لي ولوالديّ",
                        "اللهم إنك عفو تحب العفو فاعفُ عني",
                        "أستغفر الله الذي لا إله إلا هو الحي القيوم وأتوب إليه",
                        "اللهم أنت ربي لا إله إلا أنت خلقتني وأنا عبدك وأنا على عهدك ووعدك ما استطعت أعوذ بك من شر ما صنعت أبوء لك بنعمتك عليّ وأبوء بذنبي فاغفر لي فإنه لا يغفر الذنوب إلا أنت",
                        "سبحان الله",
                        "سبحان الله وبحمده",
                        "سبحان الله العظيم",
                        "سبحان الله وبحمده سبحان الله العظيم",
                        "سبحان الله عدد خلقه",
                        "سبحان الله ملء السماوات وملء الأرض",
                        "سبحان الله والحمد لله",
                        "سبحان الله ولا حول ولا قوة إلا بالله",
                        "الله أكبر",
                        "الله أكبر كبيرًا",
                        "الله أكبر ولله الحمد",
                        "الله أكبر الله أكبر لا إله إلا الله، الله أكبر الله أكبر ولله الحمد",
                        "الله أكبر كبيرًا والحمد لله كثيرًا وسبحان الله بكرةً وأصيلًا",
                        "لا إله إلا الله",
                        "لا إله إلا الله وحده لا شريك له له الملك وله الحمد وهو على كل شيء قدير",
                        "الحمد لله",
                        "الحمد لله رب العالمين",
                        "لا حول ولا قوة إلا بالله",
                        "حسبنا الله ونعم الوكيل",
                        "توكلت على الله",
                        "اللهم صلِّ وسلم على نبينا محمد"
                    };

            Random r = new Random();
            string Text = adhkar[r.Next(0,adhkar.Length -1)];
            return Text;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            notifyIcon1.ShowBalloonTip(1000,"Tadhkir",GetRandomText(),ToolTipIcon.Info);
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

using System.IO;


namespace WindowsFormsApp1
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void savePeople_Click(object sender, EventArgs e)
        {
            savePeopleDataBase spdb = new savePeopleDataBase(FIOtext.Text.ToString(), SpecialCombo.SelectedText.ToString(), DoljCombo.SelectedText.ToString(),
                DateTime.Text.ToString());
            spdb.catchSearch();
        }
        
    }
    class informationPeople
    {
        public string FIO;
        public string special;
        public string dolj;
        public string date;
    }
    
    
    class savePeopleDataBase : informationPeople
    {
        public savePeopleDataBase(string FIO, string special, string dolj, string date)
        {
            this.FIO = FIO;
            this.special = special;
            this.dolj = dolj;
            this.date = date;
        }
        public void catchSearch()
        { 
            
                tranferIndata();
            
        }
        private void tranferIndata()
        {
            workInDateBase wib = new workInDateBase();
            wib.updateTextFile(FIO, special, dolj, date);
        }
    }
    class searchPeopleinDataBase : informationPeople
    {


    }

    class workInDateBase : informationPeople
    {
        public void updateTextFile(string FIO, string special, string dolj, string date)
        {
            

        }

    }
    
}

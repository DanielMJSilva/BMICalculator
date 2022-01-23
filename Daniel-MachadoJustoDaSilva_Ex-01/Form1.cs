using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Daniel_MachadoJustoDaSilva_Ex_01
{
    public partial class FormFilterCategory : Form
    {
        // global variable
        public string gName;
        public string gSex = "Male";
        public string gDate;
        public string gBMI;
        public string gHeight;
        public string gWeight;
        public string gSystem;
        public bool update = false;
        public string personId;
        public string path = @"C:\Users\DMJS\Desktop\Daniel\Software Eng\COMP123 - Programming 2\LabAssignments\Daniel-MachadoJustoDaSilva_COMP123-Sec010_Lab-04\Daniel-MachadoJustoDaSilva_Ex-01\readme.txt";
        public string initialPath = @"C:\Users\DMJS\Desktop\Daniel\Software Eng\COMP123 - Programming 2\LabAssignments\Daniel-MachadoJustoDaSilva_COMP123-Sec010_Lab-04\Daniel-MachadoJustoDaSilva_Ex-01\intitialData.txt";
        public string exportFormat = "TXT";


        //global filter variable
        public bool filterOn = false;
        public string filName = "";
        public string filAge = "";
        public string filAgeModifier = "";
        public string filSex = "";
        public string filCategory = "";

        // Properties
        private List<Person> Customer { get; set; }

        List<Person> list = new List<Person>();
        public FormFilterCategory()
        {
            Thread thread = new Thread(new ThreadStart(SplashStart));
            thread.Start();
            Thread.Sleep(7000);


            Customer = GetCustomer(); // insert initial data
            InitializeComponent();


            thread.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new Form2());
        }

        //Initial data
        private List<Person> GetCustomer()
        {

            
            // READ from file and show in dataGridView
            string[] lines = File.ReadAllLines(initialPath);
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].Split(',');
                list.Add(new Person(values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[0]));
            }
            /*   Data to be read in file
 1,Daniel,Male,07-05-1986,30.00,180,98,Metric,
 2,James,Male,02-08-1940,31.00,70,105,Imperial,
 3,Kate,Female,03-13-1960,28.00,180,105,Metric,
 4,Lisa,Female,04-04-2001,25.00,180,105,Metric,
 5,Josh,Male,05-25-2000,33.00,62,105,Imperial,
 6,Tom,Male,06-06-1970,35.00,180,105,Metric,
 7,Alice,Female,07-07-1982,29.50,180,105,Metric,
 8,Anna,Female,08-08-1993,30.10,49,105,Imperial,
 9,Thomas,Male,09-09-2012,29.00,180,105,Metric,
 10,Jerry,Male,10-05-2000,22.00,180,105,Metric,
 11,Jason,Male,11-11-1999,21.00,51,105,Imperial,
 12,Jim,Male,12-22-1946,27.00,180,105,Metric,
 13,Jonson,Male,11-21-1984,38.00,55,120,Imperial,
 14,Patricia,Famale,10-18-1965,24.00,180,105,Metric,
             */
            /*
            // Add new person to list
            list.Add(new Person("Daniel", "Male", "07-05-1986", "30.00", "180", "98", "Metric"));
            list.Add(new Person("James", "Male", "02-08-1940", "31.00", "70", "105", "Imperial"));
            list.Add(new Person("Kate", "Female", "03-13-1960", "28.00", "180", "105", "Metric"));
            list.Add(new Person("Lisa", "Female", "04-04-2001", "25.00", "180", "105", "Metric"));
            list.Add(new Person("Josh", "Male", "05-25-2000", "33.00", "62", "105", "Imperial"));
            list.Add(new Person("Tom", "Male", "06-16-1998", "35.00", "180", "105", "Metric"));
            list.Add(new Person("Alice", "Female", "07-07-1970", "29.50", "180", "105", "Metric"));
            list.Add(new Person("Anna", "Female", "08-18-1982", "30.10", "49", "105", "Imperial"));
            list.Add(new Person("Thomas", "Male", "09-29-1993", "29.00", "180", "105", "Metric"));
            list.Add(new Person("Jerry", "Male", "10-19-2012", "22.00", "180", "105", "Metric"));
            list.Add(new Person("Jason", "Male", "11-15-2000", "21.00", "51", "105", "Imperial"));
            list.Add(new Person("Jim", "Male", "12-22-1999", "27.00", "180", "105", "Metric"));
            list.Add(new Person("Jonson", "Male", "11-11-1946", "38.00", "55", "120", "Imperial"));
            list.Add(new Person("Patricia", "Famale", "10-10-1984", "24.00", "180", "105", "Metric"));

            */
            return list;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // change LinkColor after it has been clicked
            linkLabelReadMe.LinkVisited = true;

            System.Diagnostics.Process.Start(path);
        }

        //BUTTONS

        // calculate Imperial BMI
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double h = Convert.ToDouble(comboBoxFeet.Text) * 12 + Convert.ToDouble(comboBoxInch.Text);
                double w = Convert.ToDouble(textBoxPounds.Text);
                double b = Math.Round((w / (h * h)) * 703, 2);
                gHeight = h.ToString();
                gWeight = w.ToString();
                gBMI = b.ToString();
                gSystem = "Imperial";
                labelBMIImp.Text = "BMI: " + gBMI;
                labelBMIImp.ForeColor = Color.DarkBlue;
                MessageBox.Show("BMI: " + gBMI);
                buttonPrint.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Add only numeric data", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Calculate Metric BMI
        private void buttonCalculateMetric_Click(object sender, EventArgs e)
        {
            try
            {
                double h = Convert.ToDouble(textBoxHeight.Text);
                double w = Convert.ToDouble(textBoxWeight.Text);
                double b = Math.Round(w / (h / 100 * h / 100), 2);
                gHeight = h.ToString();
                gWeight = w.ToString();
                gBMI = b.ToString();
                labelBMIMet.Text = "BMI: " + gBMI;
                labelBMIMet.ForeColor = Color.DarkBlue;
                buttonPrint.Enabled = true;
                gSystem = "Metric";
                MessageBox.Show("BMI: " + gBMI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Add only numeric data", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Disply result before adding to database
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            gName = textBoxName.Text;

            if (!(gName.Equals(""))) { } // terminar de colocar a checagem de  campos null

            gDate = dateTimePicker1.Value.ToString("MM-dd-yyyy");

            textBoxPrint.Text = "Name: " + gName + "\t " +
                                "Sex: " + gSex + "\t " +
                                "BMI: " + gBMI + "\t " +
                                "Height: " + gHeight + "\t " +
                                "Weight: " + gWeight + "\t " +
                                "System: " + gSystem + "\t " +
                                "Date: " + gDate;
            buttonClear.Enabled = true;
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = true;
            buttonPrint.Enabled = false;
            textBoxName.Enabled = false;
            textBoxHeight.Enabled = false;
            textBoxPounds.Enabled = false;
            textBoxWeight.Enabled = false;
            comboBoxFeet.Enabled = false;
            comboBoxInch.Enabled = false;
            dateTimePicker1.Enabled = false;
            groupBoxSex.Enabled = false;


        }

        //Export data to File
        private void buttonExport_Click(object sender, EventArgs e)
        {

            using (StreamWriter exportLine = File.AppendText(path))
            {
                if (filterOn)
                {
                    string filter = "";

                    if (filName != "")
                    {
                        filter += " Name: " + filName + "; ";
                    }
                    if (filAge != "")
                    {
                        filter += "Age " + filAgeModifier + " " + filAge + "; ";
                    }
                    if (filSex != "")
                    {
                        filter += "Sex: " + filSex + "; ";
                    }
                    if (filCategory != "")
                    {
                        filter += "Category: " + filCategory + ";";
                    }
                    exportLine.WriteLine("---------FILTER-------------");
                    exportLine.WriteLine(filter);
                    exportLine.WriteLine("----------------------------");
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    
                        var row = dataGridView1.Rows[i].DataBoundItem as Person;
                    if (exportFormat.Equals("JSON"))
                    {
                        exportLine.WriteLine("Person = {\"PersonID\" : \"" + row.GetPersonID() + "\", " +
                          "\"Name\" : \"" + row.GetName() + "\", " +
                          "\"Sex\" : \"" + row.GetSex() + "\", " +
                          "\"BirthDay\" : \"" + row.GetBirthday() + "\", " +
                          "\"BMI\" : \"" + row.GetBMI() + "\", " +
                          "\"Height\" : \"" + row.GetHeight() + "\", " +
                          "\"Weight\" : \"" + row.GetWeight() + "\", " +
                          "\"NumSystem\" : \"" + row.GetNumSystem() + "\"}");
                    }
                    else if (exportFormat.Equals("XML"))
                    {
                        exportLine.WriteLine("<Person>\n  <PersonID > "+ row.GetPersonID() + " </ PersonID > " +
                                 "\n  <Name>" + row.GetName() + "</Name>" +
                                 "\n  <Sex>" + row.GetSex() + "</Sex>" +
                                 "\n  <Birthday>" + row.GetBirthday() + "</Birthday>" +
                                 "\n  <BMI>" + row.GetBMI() + "</BMI>" +
                                 "\n  <Height>" + row.GetHeight() + "</Height>" +
                                 "\n  <Weight>" + row.GetWeight() + "</Weight>" +
                                 "\n  <NumSystem>" + row.GetNumSystem() + "</NumSystem>\n</Person>");
                    }
                    else if (exportFormat.Equals("TXT"))
                    {
                        exportLine.WriteLine( row.GetPersonID() + ", " + row.GetName() + ", " + row.GetSex() + ", " + row.GetBirthday() + ", " + row.GetBMI() + ", " + row.GetHeight() + ", " + row.GetWeight() + ", " + row.GetNumSystem());
                    }


                    /* This is used when data is not bound
                    TextWriter export = new StreamWriter(path);

                        for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                        {
                            //export.WriteLine(row.PersonID.ToString() + row.Name.ToString());
                            export.WriteLine(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        export.Close();
                    */
                }

            }
        } 


        private void Form1_Load(object sender, EventArgs e)
        {
      
        var customer = this.Customer;
            dataGridView1.DataSource = customer;
        }



        // RADIO BUTTON
        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                gSex = "Male";
            }
        }
        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFemale.Checked)
            {
                gSex = "Female";
            }
        }

        private void radioButtonJSON_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonJSON.Checked)
            {
                exportFormat = "JSON";
            }
        }

        private void radioButtonXML_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonXML.Checked)
            {
                exportFormat = "XML";
            }
        }

        private void radioButtonTXT_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTXT.Checked)
            {
                exportFormat = "TXT";
            }
        }

     

        // ADD TO DataGripView
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxPrint.Text = "";
            buttonPrint.Enabled = false;
            buttonClear.Enabled = false;
            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;
            if(update == false) {
                list.Add(new Person(gName, gSex, gDate, gBMI, gHeight, gWeight, gSystem));

                // Get Id from add person (used to write the id in file, only when interaction is ON)
                //var lastRow = dataGridView1.Rows[dataGridView1.Rows.Count - 1].DataBoundItem as Person;
                //personId = (Convert.ToInt32(lastRow.PersonID)+1).ToString();

            } else
            {
                list.Add(new Person(gName, gSex, gDate, gBMI, gHeight, gWeight, gSystem, personId));
                update = false;
            }

            // Add to file readme.txt
            /*
            using (StreamWriter exportLine = File.AppendText(path))
            {
                exportLine.WriteLine(personId + ", " + gName + ", " + gSex + ", " + gDate + ", " + gBMI + ", " + gHeight + ", " + gWeight + ", " + gSystem + ",\n");
            }
          */
            
            dataGridView1.DataSource = null; // reset list
            dataGridView1.DataSource = list;




            textBoxName.Text = "";
            textBoxHeight.Text = "";
            textBoxPounds.Text = "";
            textBoxWeight.Text = "";
            comboBoxFeet.Text = "";
            comboBoxInch.Text = ""; 
            labelBMIImp.Text = "";
            labelBMIMet.Text = "";

            
            textBoxName.Enabled = true;
            textBoxHeight.Enabled = true;
            textBoxPounds.Enabled = true;
            textBoxWeight.Enabled = true;
            comboBoxFeet.Enabled = true;
            comboBoxInch.Enabled = true;
            dateTimePicker1.Enabled = true;
            groupBoxSex.Enabled = true;

            
            
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPrint.Text = "";
            buttonPrint.Enabled = true;
            buttonClear.Enabled = false;
            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;

            textBoxName.Text = "";
            textBoxHeight.Text = "";
            textBoxPounds.Text = "";
            textBoxWeight.Text = "";
            comboBoxFeet.Text = "";
            comboBoxInch.Text = "";

            buttonPrint.Enabled = true;
            textBoxName.Enabled = true;
            textBoxHeight.Enabled = true;
            textBoxPounds.Enabled = true;
            textBoxWeight.Enabled = true;
            comboBoxFeet.Enabled = true;
            comboBoxInch.Enabled = true;
            dateTimePicker1.Enabled = true;
            groupBoxSex.Enabled = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxPrint.Text = "";
            buttonPrint.Enabled = true;
            buttonClear.Enabled = false;
            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;

            buttonPrint.Enabled = true;
            textBoxName.Enabled = true;
            textBoxHeight.Enabled = true;
            textBoxPounds.Enabled = true;
            textBoxWeight.Enabled = true;
            comboBoxFeet.Enabled = true;
            comboBoxInch.Enabled = true;
            dateTimePicker1.Enabled = true;
            groupBoxSex.Enabled = true;
        }

        // UPDATE FILE
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                update = true;
                var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Person;
                textBoxName.Text = selectedRow.Name;
                personId = selectedRow.PersonID;
                dateTimePicker1.Value = new DateTime(Convert.ToInt32(selectedRow.Birthday.Substring(6, 4)), Convert.ToInt32(selectedRow.Birthday.Substring(0, 2)), Convert.ToInt32(selectedRow.Birthday.Substring(3, 2)));
                if (selectedRow.Sex.Equals("Male"))
                {
                    radioButtonMale.Checked = true;
                }
                else
                {
                    radioButtonFemale.Checked = true;
                }

                if (selectedRow.NumSystem.Equals("Metric"))
                {
                    tabControl.SelectedTab = tabControl.TabPages["tabPageMetric"];
                    textBoxHeight.Text = selectedRow.Height;
                    textBoxWeight.Text = selectedRow.Weight;
                }
                else
                {
                    tabControl.SelectedTab = tabControl.TabPages["tabPageImperial"];
                    comboBoxFeet.Text = Math.Truncate(Convert.ToDouble(selectedRow.Height) / 12).ToString();
                    comboBoxInch.Text = ((decimal)(Convert.ToDouble(selectedRow.Height) % 12)).ToString();
                    textBoxPounds.Text = selectedRow.Weight;
                }
                list.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }


        // DELETE FROM FILE
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Ask form confirmation
            DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    // remove row
                    list.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    dataGridView1.DataSource = null; // reset list
                    dataGridView1.DataSource = list;

                    //Remove selected item from File
                    /*
                    var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Person;//
                    personId = (Convert.ToInt32(selectedRow.PersonID)-1).ToString();//
                    var oldLines = File.ReadAllLines(@"C:\Users\DMJS\Desktop\Daniel\Software Eng\COMP123 - Programming 2\LabAssignments\Daniel-MachadoJustoDaSilva_COMP123-Sec010_Lab-04\Daniel-MachadoJustoDaSilva_Ex-01\readme.txt");
                    var newLines = oldLines.Where(line => !line.Substring(0,line.IndexOf(",")).Contains(personId));
                    File.WriteAllLines(path, newLines);
                    FileStream obj = new FileStream(path, FileMode.Append);
                    obj.Close();
                    // once deleted the selected line and once again read the text file and diplay the new text file in listBox  
                    FileInfo fi = new FileInfo(@"C:\Users\DMJS\Desktop\Daniel\Software Eng\COMP123 - Programming 2\LabAssignments\Daniel-MachadoJustoDaSilva_COMP123-Sec010_Lab-04\Daniel-MachadoJustoDaSilva_Ex-01\readme.txt");
                    using (StreamReader sr = fi.OpenText())
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            dataGridView1.Text = s;

                        }
                        sr.Close();
                    }
                    FileStream obj1 = new FileStream(path, FileMode.Append);
                    obj1.Close();
                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
                }
            }
            else if (DialogResult == DialogResult.No)
            {
                //Nothing to do
            }

           

            
        }
        // Using LINQ
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                // inicialize filter list
                var filteredList = from x in list select x;
                filterOn = true;

                string filterName = textBoxFilterName.Text;
                string filterAge = textBoxFilterAge.Text;


                // filter by Name
                if (filterName != null)
                {
                    filName = filterName;
                    filteredList = from fName in filteredList where (fName.GetName().Contains(filterName)) select fName;
                }

                //filter by Sex
                if ((checkBoxFilterMale.Checked == true || checkBoxFilterFemale.Checked == true) || !(checkBoxFilterMale.Checked == true && checkBoxFilterFemale.Checked == true))
                {
                    if (checkBoxFilterMale.Checked == true)
                    {
                        filSex = " Male";
                        filteredList = from fSex in filteredList where (fSex.GetSex().Equals("Male")) select fSex;
                    }
                    else if (checkBoxFilterFemale.Checked == true)
                    {
                        filSex = filSex + " Female";
                        filteredList = from fSex in filteredList where (fSex.GetSex().Equals("Female")) select fSex;
                    }
                }
                
                //filter by Age
                if (filterAge != "")
                {
                    filAge = filterAge;
                    filAgeModifier = comboBoxFilterAge.Text;
                    // calculate number of days from 01/01/0000 to today's date
                    int today = (DateTime.Today.Year * 365 + DateTime.Today.Month * 30 + DateTime.Today.Day) / 365;


                    if (comboBoxFilterAge.Text.Equals("equal or greater than"))
                    {
                        // filter ages equal or greater than input
                        filteredList = from fAge in filteredList
                                       where ((int)Math.Truncate(today - (
                                       (Convert.ToInt32(fAge.GetBirthday().Substring(6, 4))) * 365 + //year * 365 +
                                       (Convert.ToInt32(fAge.GetBirthday().Substring(0, 2))) * 30 + // month * 30 +
                                       (Convert.ToInt32(fAge.GetBirthday().Substring(3, 2))) // day
                                       ) / 365.00) // calculate number of days from birthday to today's date.
                                       >= Convert.ToInt32(filterAge))
                                       select fAge;
                    }
                    else if (comboBoxFilterAge.Text.Equals("less than"))
                    {
                        // filter ages less than input
                        filteredList = from fAge in filteredList
                                       where ((int)Math.Truncate(today - (
                     (Convert.ToInt32(fAge.GetBirthday().Substring(6, 4))) * 365 + //year * 365 +
                     (Convert.ToInt32(fAge.GetBirthday().Substring(0, 2))) * 30 + // month * 30 +
                     (Convert.ToInt32(fAge.GetBirthday().Substring(3, 2))) // day
                     ) / 365.00) < Convert.ToInt32(filterAge)
                     )
                                       select fAge;
                    }
                    else
                    {
                        // filter ages equals to input
                        filteredList = from fAge in filteredList
                                       where ((int)Math.Truncate(today - (
                     (Convert.ToInt32(fAge.GetBirthday().Substring(6, 4))) * 365 + //year * 365 +
                     (Convert.ToInt32(fAge.GetBirthday().Substring(0, 2))) * 30 + // month * 30 +
                     (Convert.ToInt32(fAge.GetBirthday().Substring(3, 2))) // day
                     ) / 365.00) + 1 == Convert.ToInt32(filterAge)
                     )
                                       select fAge;
                    }

                }

                // filter by category
                if (comboBoxCategory.Text != null)
                {
                    filCategory = comboBoxCategory.Text;
                    if (comboBoxCategory.Text.Equals("Obesity"))
                    {
                        filteredList = from fCat in filteredList where (Convert.ToDouble(fCat.GetBMI()) >= 30.00) select fCat;
                    }
                    else if (comboBoxCategory.Text.Equals("Underweight"))
                    {
                        filteredList = from fCat in filteredList where (Convert.ToDouble(fCat.GetBMI()) <= 18.50) select fCat;
                    }
                    else if (comboBoxCategory.Text.Equals("Overweight"))
                    {
                        filteredList = from fCat in filteredList where ((Convert.ToDouble(fCat.GetBMI()) >= 25.00) && (Convert.ToDouble(fCat.GetBMI()) < 30.00)) select fCat;
                    }
                    else if (comboBoxCategory.Text.Equals("Normal"))
                    {
                        filteredList = from fCat in filteredList where ((Convert.ToDouble(fCat.GetBMI()) > 18.50) && (Convert.ToDouble(fCat.GetBMI()) < 25.00)) select fCat;
                    }
                }
                // insert filter data into dataDridView
                dataGridView1.DataSource = filteredList.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " - " + ex.Source + ex.StackTrace);
            }
           

        }

        private void buttonFilterClear_Click(object sender, EventArgs e)
        {
            //reset filter fields
            filterOn = false;
            textBoxFilterName.Text = "";
            textBoxFilterAge.Text = "";
            comboBoxCategory.Text = "";
            comboBoxFilterAge.Text = "";
            checkBoxFilterFemale.Checked = false;
            checkBoxFilterMale.Checked = false;
            filName = "";
            filAge = "";
            filAgeModifier = "";
            filCategory = "";
            filSex = "";

            //insert original data into dataGridView
            dataGridView1.DataSource = list;
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab4 {
    public partial class Form1 : Form {
        private Stack<string> InText = new Stack<string>();

        public Form1() {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {

        }
        
        /// <summary>
        /// When the Load button is clicked it will allow the user to select a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Click(object sender, EventArgs e) {
            Stack<string> Lines = new Stack<string>();//Create a new Stack
            var Line = string.Empty;//Create a variable that will receive info from the reader
            //Create the OpenFileDialog
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Multiselect = false;
            OFD.Filter = "HTML Files (*.html) | *.html";//Set the filter
            OFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//set the default path
            //Read from the file
            if (OFD.ShowDialog() == DialogResult.OK) {
                var Stream = OFD.OpenFile();//Open the file
                using (StreamReader reader =new StreamReader(Stream)) {//Initialize reader
                    while ((Line = reader.ReadLine())!=null) {//Read line by line
                        Lines.Push(Line);//add to Stack
                    }//while
                    while (Lines.Count != 0){
                        InText.Push(Lines.Pop());//Reverse the Stack into a new one
                    }//while
                }//using
            }//if
        }//Load
        
        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e) {
            Environment.Exit(0);//Exit with code 0
        }//Exit

        /// <summary>
        /// When the Check button is clicked it will check each line for opening and closing tags, while filtering non-containing tags
        /// NOTE: Not all non-containing tags have been added. If this were being added to a piece of software that was being sold, I would add each tag.
        /// I added the tags that were both listed in the assignment and any non-container tags in my test code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_Click(object sender, EventArgs e) {
            String OIndex = "<", CIndex = ">";//Identify the Index Characters of a tag
            String [] Element, SplitBy = {"<",">"};//Identify what to split by, and make an array to hold elements of a line
            String [] Ignore = { "img", "hr", "br", "link", "meta", "input","DOCTYPE" };//Identify the tags to ignore. SEE NOTE INT SUMMARY COMMENTS!!!
            String [] Lines = InText.ToArray();//Convert Stack to an Array. I do this, so it's easier for me to traverse the lines of text. Alternatively I could have used InText.Pop() to select the line
            int Open = 0, Close = 0, Size = Lines.Count();//Create variables to hold the number of open tags, close tags and the size of the array
            bool Balanced = false;
            var Skip = false;
            var FinalText = string.Empty;
            var Line=string.Empty;
            //Create two counters
            int x=0;
            int y = 0;

            //Breaking down to Elements
            for (int i = 0; i < Size; i++){
                Line = Lines[i].Trim();//Trim the Line
                Element = Line.Split(SplitBy,StringSplitOptions.RemoveEmptyEntries);//Split the line
                //Checking each line element
                for (int j = 0; j < Element.Length; j++){
                    Skip = false;
                    x = 0;//Traverses the Ignore array
                    y = 0;//Acts as an exit statement
                    Element[j] = Element[j].Trim();//trim the element
                    
                    while (y<Ignore.Length){
                        //If the selection matches a word that we need to Skip
                        if (Element[j].Contains(Ignore[x]) == true) {
                            //j++;//increment the selection counter
                            Skip = true;//set Skip to true
                            y++;
                        }//if
                        //If the selection does not matches a word we need to Skip
                        else if (Element[j].Contains(Ignore[x]) == false) {
                            x++;
                            y++;
                        }//elif
                    }//while
                    //If the word does not need to be skipped
                    if (Skip != true){
                        //if the Length is 0
                        if (Lines[i].Length == 0) {
                            break;
                        }//if
                        else{
                            //Check to see if the first Character is a forward slash
                            string Check = Element[j].Substring(0,1);
                            if (Check.Equals("/")) {
                                Close++;//Add a count to the closing tag count
                                FinalText += "Found Closing Tag: <" + Element[j].ToString() + ">\n";//Add a line to the Final Text
                            }//if
                            else {
                                Open++;//Add a count to the opening tag count
                                FinalText += "Found Opening Tag: <" + Element[j].ToString() + ">\n";//Add a line to the Final Text
                            }//else
                        }//else
                    }//else
                }//for
            }//for
            //Check if the tags are balanced
            if (Open == Close) {
                Balanced = true;
            }//if
            else {
                Balanced = false;
            }//else
            Update(Balanced,FinalText);//Call the update method
        }//Check
        /// <summary>
        /// Updates the Text Box
        /// </summary>
        /// <param name="Balanced"></param>
        /// <param name="FinalText"></param>
        public void Update(bool Balanced, string FinalText){
            //Check the Balanced condition
            switch (Balanced){
                case true://If it is balanced
                    Title.Text = "The tags are balanced";
                    break;
                case false://If it is NOT balanced
                    Title.Text = "The tags are not balanced";
                    break;
                default:
                    break;
            }//switch
            DisplayBox.Text = FinalText;//Update the final text
        }//Update
    }//Form
}//namespace
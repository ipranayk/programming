using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// open an xml file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openXml_Click(object sender, EventArgs e)
        {
            XmlDocument myDocument = new XmlDocument();
            try
            {
                myDocument.Load(FileName.Text);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Can't find file." + Environment.NewLine + ex.Message.ToString());
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Something is wrong: " + ex.Message.ToString());
            }

            // Read the data from the document...
            int pizzaCount = 1;
            for (int index = 0; index != myDocument.DocumentElement.ChildNodes.Count; index++)
            {
                XmlNode curNode = myDocument.DocumentElement.ChildNodes[index];

                // Phone number...
                if (curNode.Name == "phone")
                {
                    this.AddLine("phone# " + curNode.InnerText.ToString());
                }
                else if (curNode.Name == "date")
                {
                    this.AddLine("date: " + curNode.InnerText.ToString());
                }
                else if (curNode.Name == "time")
                {
                    this.AddLine("time: " + curNode.InnerText.ToString());
                }
                else if (curNode.Name == "pizza")
                {
                    this.AddLine("pizza #" + pizzaCount);
                    pizzaCount++;
                    // Now things get a little more complex as we have to read nodes inside
                    int toppingCount = 1;
                    for (int pizzaIndex = 0; pizzaIndex != curNode.ChildNodes.Count; pizzaIndex++)
                    {
                        XmlNode pizzaCurNode = curNode.ChildNodes[pizzaIndex];
                        if (pizzaCurNode.Name == "large")
                        {
                            this.AddLine("large");
                        }
                        else if (pizzaCurNode.Name == "topping")
                        {
                            this.AddLine("topping #" + toppingCount.ToString()
                                         + " = " + pizzaCurNode.InnerText.ToString());
                            toppingCount++;
                        }

                    }
                }
            }
        }
        /// <summary>
        /// insert text in new line
        /// </summary>
        /// <param name="theText"></param>
        private void AddLine(string theText)
        {
            this.textOutput.Text = this.textOutput.Text + Environment.NewLine + theText.ToString();
        }

        /// <summary>
        /// create and save new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveNewFile_Click(object sender, EventArgs e)
        {
             // This shows you how you can create your own order. 
            // Note that, while this is a lot easier than doing it 'from scratch' in 
            // something like C++, it's not perfect...

            XmlDocument mynewDoc = new XmlDocument();

            XmlElement rootNode = mynewDoc.CreateElement("pizzaOrder");
            // Note that this is placed as the first (and only) child...
            mynewDoc.AppendChild(rootNode);

            // Now the header (or it's not an XML doc)....
            XmlDeclaration myHeader = mynewDoc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            // Add it BEFORE the document element....
            mynewDoc.InsertBefore(myHeader, mynewDoc.DocumentElement);

            // Now add all the pizza stuff... 
            // NOTE: the "rootNode" is still "connected" to the node in the document, 
            //  so we can use the mynewDoc.DocumentElement or "rootNode" to get at it...

            XmlElement phoneNode = mynewDoc.CreateElement("phone");
            phoneNode.InnerText = first.Text;
            mynewDoc.DocumentElement.AppendChild(phoneNode);
            // Could also do:
            // rootNode.AppendChild(phoneNode);

            XmlElement dateNode = mynewDoc.CreateElement("date");
            dateNode.InnerText = second.Text;
            mynewDoc.DocumentElement.AppendChild(dateNode);

            XmlElement timeNode = mynewDoc.CreateElement("time");
            timeNode.InnerText = third.Text;
            mynewDoc.DocumentElement.AppendChild(timeNode);

            XmlElement pizzaNode = mynewDoc.CreateElement("pizza");
            XmlElement sizeNode = mynewDoc.CreateElement("medium");
            XmlElement topping1Node = mynewDoc.CreateElement("topping");
            topping1Node.InnerText = fourth.Text;
            XmlElement topping2Node = mynewDoc.CreateElement("topping");
            topping2Node.InnerText = fifth.Text;
            // Add these to the pizzaNode
            pizzaNode.AppendChild(sizeNode);
            pizzaNode.AppendChild(topping1Node);
            pizzaNode.AppendChild(topping2Node);

            // Add pizza to the document node
            mynewDoc.DocumentElement.AppendChild(pizzaNode);

            // Now we save it.
            mynewDoc.Save("NewPizzaOrder.xml");
            this.AddLine("Created new xml document");
        }
         /// <summary>
         /// test function to check unit test
         /// </summary>
         /// <param name="a"></param>
         /// <param name="b"></param>
         /// <returns></returns>
        int TestFunction(int a, int b)
        {
            return a + b;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (A.Text != "" && B.Text != "")
            {
                int c = TestFunction(Convert.ToInt16(A.Text), Convert.ToInt16(B.Text));
                MessageBox.Show(c.ToString());
            }
            else
            {
                MessageBox.Show("Please Enter correct values.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

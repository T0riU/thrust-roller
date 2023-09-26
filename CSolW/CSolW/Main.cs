using CSolW.Properties;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSolW
{
    public partial class Main : Form
    {
        public string FileName() { return Settings.Default.Path != String.Empty ? Settings.Default.Path + "\\" + Settings.Default.FileName : Settings.Default.FileName; }

        public Main()
        {
            InitializeComponent();

        }
        private SldWorks swApp;
        private ModelDoc2 swModel;
        private ModelDocExtension swModelDocExt;
        private SelectionMgr swSelMgr;
        bool SizesError = false;
        const int ValueStep = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            //set Path in text box
            textBoxPath.Text = FileName();

        }
        public static double FindCathetus(double hypotenuse, double otherCathetus)
        {
            double hypotenuseSquared = hypotenuse * hypotenuse;
            double otherCathetusSquared = otherCathetus * otherCathetus;
            double remainingCathetusSquared = hypotenuseSquared - otherCathetusSquared;
            double remainingCathetus = Math.Sqrt(remainingCathetusSquared);
            return remainingCathetus;
        }
        private void create_Click(object sender, EventArgs e)
        {
            if (!SizesError)
            {
                try
                {
                    swApp = (SldWorks)Marshal.GetActiveObject("SldWorks.Application");
                }
                catch (Exception)
                {
                    swApp = new SldWorks();
                }
                swApp.Visible = true;
                string defaultPartTemplate;
                defaultPartTemplate = swApp.GetUserPreferenceStringValue((int)swUserPreferenceStringValue_e.swDefaultTemplatePart);
                try
                {
                    swApp.NewPart();
                }
                catch (Exception)
                {
                    swApp.NewDocument(defaultPartTemplate, 0, 0, 0);
                }
                //
                swModel = (ModelDoc2)swApp.ActiveDoc;
                swModelDocExt = swModel.Extension;
                swSelMgr = (SelectionMgr)swModel.SelectionManager;

                //create variables
                
                //z coordinate
                double z = 0.0;

                //d1 - outer width
                double Nd1 = (double)d1.Value / 1000;
                //d2 - inner width
                double Nd2 = (double)d2.Value / 1000;
                //d3 - radius of arc
                double Nd3 = (double)d3.Value / 1000;
                //d4 - big hole height\diameter
                double Nd4 = ((double)d4.Value / 2) / 1000;
                //d5 - innner height
                double Nd5 = ((double)d5.Value / 2) / 1000;

                //d6 - hole radius
                double Nd6 = (double)d6.Value / 1000;
                //d7 - hole diameter
                double Nd7 = (double)d7.Value / 1000;
                //holes - num of noles
                int Holes = (int)holes.Value;

                //Console.WriteLine(Nd1 + " " + Nd2 + " " + Nd3 + " " + Nd4 + " " + Nd5 + " " + Nd6 + " " + Nd7 + " " + Holes);

                //start creating model
                swModel.Extension.SelectByID2("Front", "PLANE", 0, 0, 0, false, 0, null, 0);
                swModel.InsertSketch2(true);

                //axis line
                swModel.CreateCenterLineVB(-0.4, 0.0, z, 0.4, 0.0, z);


                //center circle width line
                swModel.CreateCenterLineVB(0.0, 0.0, z, 0.0, Nd4, z);


                //bottom bases
                swModel.CreateLine2(0.0, Nd4, z, Nd1 / 2, Nd4, z);
                swModel.CreateLine2(0.0, Nd4, z, -(Nd1 / 2), Nd4, z);


                //bottom sides
                swModel.CreateLine2(Nd1 / 2, Nd4, z, Nd1 / 2, Nd5, z);
                swModel.CreateLine2(-(Nd1 / 2), Nd4, z, -(Nd1 / 2), Nd5, z);


                //up bases
                swModel.CreateLine2(Nd1 / 2, Nd5, z, Nd2 / 2, Nd5, z);
                swModel.CreateLine2(-(Nd1 / 2), Nd5, z, -(Nd2 / 2), Nd5, z);

                //arc highest on base point
                double ArcHighPoint = FindCathetus(Nd3, (Nd2 / 2));

                //up sides
                swModel.CreateLine2(Nd2 / 2, Nd5, z, Nd2 / 2, ArcHighPoint, z);
                swModel.CreateLine2(-(Nd2 / 2), Nd5, z, -(Nd2 / 2), ArcHighPoint, z);

                //arc
                swModel.CreateArc2(0.0, 0.0, z, -(Nd2 / 2), ArcHighPoint, z, Nd2 / 2, ArcHighPoint, z, -1);

                // define sketch
                int fullyDefined = swModel.SketchManager.FullyDefineSketch(true, true, (int)swSketchFullyDefineRelationType_e.swSketchFullyDefineRelationType_Coincident, true, 1, null, 1, null, -1, -1);
                swModel.ClearSelection2(true);


                swModel.InsertSketch2(false);




                //create revolve
                swModel.Extension.SelectByID2("Line1@Sketch1", "EXTSKETCHSEGMENT", 0, 0, z, false, 16, null, 0);
                swModel.Extension.SelectByID2("Sketch1", "SKETCH", 0, 0, z, true, 2, null, 0);
                swModel.SelectionManager.EnableContourSelection = true;
                swModel.Extension.SelectByID2("Sketch1", "SKETCHREGION", 0, Nd5, z, true, 2, null, 0);
                swModel.FeatureManager.FeatureRevolve2(true, true, false, false, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true);
                swModel.SelectionManager.EnableContourSelection = false;



                //sketch for cut
                swModel.Extension.SelectByID2("Right Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
                swModel.InsertSketch2(true);
                swModel.CreateCircleByRadius2(Nd4, 0.0, 0.0, Nd6);
                fullyDefined = swModel.SketchManager.FullyDefineSketch(true, true, (int)swSketchFullyDefineRelationType_e.swSketchFullyDefineRelationType_Coincident, true, 1, null, 1, null, -1, -1);
                swModel.ClearSelection2(true);

                //make cut 
                if (Holes != 0)
                {
                    swModel.FeatureManager.FeatureCut4(true, false, false, (int)swEndConditions_e.swEndCondBlind, (int)swEndConditions_e.swEndCondBlind, Nd7, Nd7, false, false, false, false, 0.0174532925199433, 0.0174532925199433, false, false, false, false, false, true, true, true, true, false, 3, Nd1 / 2, false, false);
                    swModel.ClearSelection2(true);
                }
                if (Holes > 1)
                {
                    //array
                    swModel.Extension.SelectByID2("Cut-Extrude1", "BODYFEATURE", 0, 0, 0, false, 4, null, 0);
                    swModel.Extension.SelectByID2("Line1@Sketch1", "EXTSKETCHSEGMENT", 1, 0, 0, true, 1, null, 0);
                    int numInstances = (int)Holes; // Total number of instances in the pattern
                    double angleBetween = (360.0 / numInstances) * (Math.PI / 180.0); // Angle between each instance
                    swModel.FeatureManager.FeatureCircularPattern2(numInstances, angleBetween, true, " ", true);
                }

                //save
                var result = MessageBox.Show("Would you like to save file?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string FileNameTemp = FileName();
                    bool longstatus = true;
                    do
                    {
                        longstatus = swModel.Extension.SaveAs(FileNameTemp, (int)swSaveAsVersion_e.swSaveAsCurrentVersion, (int)swSaveAsOptions_e.swSaveAsOptions_Silent, null, 0, 0);
                        Console.WriteLine("File already exist");
                        FileNameTemp = FileNameTemp.Insert(FileNameTemp.LastIndexOf('.'), "(copy)");
                    } while (longstatus == false);
                }
                try
                {
                    swApp.CloseDoc(swModel.GetTitle());
                }catch
                {

                }

            }
            else
            {
                MessageBox.Show("Change parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Check_ValueChanged(object sender, EventArgs e)
        {
            bool bd1, bd2, bd3, bd4, bd5, bd6, bd7, bholes;

            var t = Math.Sqrt(Math.Pow((double)d2.Value, 2) + Math.Pow((double)d5.Value, 2));
            //d1
            if (d1.Value <= d2.Value || d1.Value < d7.Value)
            {
                d1.BackColor = Color.IndianRed;
                bd1 = true;
            }
            else
            {
                d1.BackColor = Color.White;
                bd1 = false;
            }
            //d2
            if (d1.Value <= d2.Value || (double)d3.Value < Math.Sqrt(Math.Pow((double)d2.Value / 2, 2) + Math.Pow((double)d5.Value / 2, 2)))
            {
                d2.BackColor = Color.IndianRed;
                bd2 = true;
            }
            else
            {
                d2.BackColor = Color.White;
                bd2 = false;
            }
            //d3   d2.Value
            if (d3.Value <= d4.Value / 2 || d3.Value <= d5.Value / 2 || d3.Value <= d6.Value || (double)d3.Value< Math.Sqrt(Math.Pow((double)d2.Value / 2, 2) + Math.Pow((double)d5.Value / 2, 2)))
            {
                d3.BackColor = Color.IndianRed;
                bd3 = true;
            }
            else
            {
                d3.BackColor = Color.White;
                bd3 = false;
            }
            //d4
            if (d4.Value / 2 >= d3.Value || d4.Value >= d5.Value || d4.Value <= d6.Value || (d5.Value - d4.Value)/2 <= d6.Value)
            {
                d4.BackColor = Color.IndianRed;
                bd4 = true;
            }
            else
            {
                d4.BackColor = Color.White;
                bd4 = false;
            }
            //d5
            if (d5.Value / 2 >= d3.Value || d5.Value <= d4.Value || d5.Value <= d6.Value || (d5.Value - d4.Value)/2 <= d6.Value || (double)d3.Value < Math.Sqrt(Math.Pow((double)d2.Value/2, 2) + Math.Pow((double)d5.Value/2, 2)))
            {
                d5.BackColor = Color.IndianRed;
                bd5 = true;
            }
            else
            {
                d5.BackColor = Color.White;
                bd5 = false;
            }
            //d6
            if (d6.Value >= d3.Value || d5.Value <= d6.Value || d4.Value <= d6.Value || (d5.Value - d4.Value) / 2 <= d6.Value) 
            {
                d6.BackColor = Color.IndianRed;
                bd6 = true;
            }
            else
            {
                d6.BackColor = Color.White;
                bd6 = false;
            }
            //d7
            if (d1.Value < d7.Value)
            {
                d7.BackColor = Color.IndianRed;
                bd7 = true;
            }
            else
            {
                d7.BackColor = Color.White;
                bd7 = false;
            }
            //holes
            if (((Decimal)Math.PI * d4.Value) < holes.Value * 2 * d6.Value)
            {
                holes.BackColor = Color.IndianRed;
                bholes = true;
            }
            else
            {
                holes.BackColor = Color.White;
                bholes = false;
            }

            if (!bd1 && !bd2 && !bd3 && !bd4 && !bd5 && !bd6 && !bd7 && !bholes)
            {
                SizesError = false;
            }
            else
            {
                SizesError = true;
            }
        }

        private void SetStandartValues()
        {
            d1.Value = 42;
            d2.Value = 30;
            d3.Value = 42;
            d4.Value = 21;
            d5.Value = 46;
            d6.Value = (Decimal)3.3;
            d7.Value = 12;
            holes.Value = 1;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            SetStandartValues();
        }

        private void setPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog = new SaveFileDialog();
            if (Settings.Default.Path == string.Empty)
            {
                Settings.Default.Path = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            }
            openFileDialog.InitialDirectory = Settings.Default.Path;
            openFileDialog.Filter = "Solid Works 2022 file (*.SLDPRT)|*.SLDPRT";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string TempDirectory = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                string TempFileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                Settings.Default.Path = TempDirectory == String.Empty ? Settings.Default.Path : TempDirectory;
                Settings.Default.FileName = TempFileName == String.Empty ? Settings.Default.FileName : TempFileName;
                Settings.Default.Save();
                textBoxPath.Text = FileName();
            }
        }
        
        private string setTipText(NumericUpDown sender)
        {
            //d1
            if (d1 == sender)
            {
                Decimal temp = ((d2.Value ) > (d7.Value)) ? d2.Value : d7.Value ;
                return ("min: >" + temp);
            }
            //d2 (d1.Value >= d2.Value)
            if (d2 == sender)
            {
                Decimal temp = (Decimal)(2 * Math.Sqrt(Math.Pow((double)d3.Value, 2) - Math.Pow((double)d5.Value / 2, 2)));
                temp = ((temp) < (d1.Value)) ? temp : d1.Value;
                return ("min: > " + d2.Minimum + "; max: < " + d1.Value);
            }
            //d3 (d3.Value >= d4.Value / 2 || d3.Value >= d5.Value / 2 || d3.Value >= d6.Value) || (double)d3.Value > Math.Sqrt(Math.Pow((double)d2.Value, 2) + Math.Pow((double)d5.Value, 2))
            if (d3 == sender)
            {
                Decimal temp = ((d4.Value / 2) > (d5.Value / 2)) ? d4.Value / 2 : d5.Value / 2;
                temp = ((temp) > (d6.Value)) ? temp : d6.Value;
                temp = ((temp) > (Decimal)(Math.Sqrt(Math.Pow((double)d2.Value / 2, 2) + Math.Pow((double)d5.Value / 2, 2)))) ? temp : (Decimal)Math.Sqrt(Math.Pow((double)d2.Value / 2, 2) + Math.Pow((double)d5.Value / 2, 2));
                return ("min: > "  + temp + " ");
            }
            //d4 (d4.Value <= d3.Value*2 || d4.Value <= d5.Value || d4.Value >= d6.Value || d4.Value <= -d6.Value*2-d5.Value)
            if (d4 == sender)
            {
                Decimal temp = ((d3.Value*2) < (d5.Value)) ? d3.Value *2 : d5.Value ;
                
                temp = ((temp) < (-(d6.Value * 2 - d5.Value))) ? temp : -(d6.Value * 2 - d5.Value);

                return ("min: > " + d6.Value + "; max: < " + temp);
            }
            //d5 (d5.Value <= d3.Value*2 || d5.Value >= d4.Value || d5.Value >= d6.Value || d5.Value >= (d6.Value*2)+d4.Value 
            if (d5 == sender)
            {
                Decimal temp = ((d4.Value) > (d6.Value)) ? d4.Value : d6.Value;

                temp = ((temp) > (d6.Value * 2) + d4.Value) ? temp : (d6.Value * 2) + d4.Value;

                Decimal temp1 = (Decimal)(2 * Math.Sqrt(Math.Pow((double)d3.Value, 2) - Math.Pow((double)d2.Value / 2, 2)));
                temp1 = ((temp1) < (d3.Value * 2)) ? temp1 : d3.Value * 2;
                return ("min: > " + temp + "; max: < " + temp1);
            }
            //d6 (d6.Value <= d3.Value || d5.Value >= d6.Value || d4.Value >= d6.Value || (d5.Value - d4.Value) / 2 >= d6.Value) 
            if (d6 == sender)
            {
                Decimal temp = ((d3.Value) < (d5.Value)) ? d3.Value : d5.Value;

                temp = ((temp) < (d4.Value)) ? temp : d4.Value;
                temp = ((temp) < ((d5.Value - d4.Value) / 2)) ? temp : (d5.Value - d4.Value) / 2;
                return ("min: > " + d6.Minimum + "; max: < " + temp);
            }
            //d7 (d1.Value >= d7.Value)(
            if (d7 == sender)
            {
                return ("min: > " + d7.Minimum + "; max: < " + d1.Value);
            }
            //num  (Decimal)Math.PI* d4.Value / (2 * d6.Value) > holes.Value
            if (holes == sender)
            {
                return ("min: > " + d7.Minimum + "; max: < " + (int)((Decimal)Math.PI * d4.Value / (2 * d6.Value))); 
            }

            return "something went wrong";
        }

        private void Num_Enter(object sender, EventArgs e)
        {
            NumericUpDown temp = (NumericUpDown)sender;
                string text = setTipText(temp);
                Point pt = new Point(0, 0);
                pt.Offset(temp.Width - 1, temp.Height - 20);
                Tip.Show(text, temp, pt, 8000);
                Tip.ToolTipIcon = ToolTipIcon.Warning;
        }
        private void Num_Leave(object sender, EventArgs e)
        {
            Tip.Hide((NumericUpDown)sender);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (swApp != null)
                {
                    swApp.ExitApp();
                    swApp = null;
                }
            } catch(Exception ex)
            {

            }
        }
    }
}

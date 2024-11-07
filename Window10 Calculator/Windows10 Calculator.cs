using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window10_Calculator
{
    public partial class Windows10_Calculator : Form
    {
        Double Result = 0;
        String Operation = "";
        bool Enter_Value = false;
        String FirstNum,SecondNum;
        char Temp;
        public Windows10_Calculator()
        {
            InitializeComponent();
        }

        private void Windows10_Calculator_Load(object sender, EventArgs e)
        {
            txtResult.Location = new Point(16, 150);
            txtResult.Size = new Size(795, 39);
            lblResultOf.Location = new Point(16, 120);
            lblResultOf.Size = new Size(795, 19);
            TreeViewCalculator.Visible = false;
            btnShowTreeView.Visible = false;
            labelProgrammer();
            BtnShowOnStandard();
       
            lblNoHIstory.BringToFront();
            lblTextHexa.BringToFront();
            lblTextDecimal.BringToFront();
            lblTextOctal.BringToFront();
            lblResultBinary.BringToFront();
            btnHideOnTempreture();
        }
        void labelProgrammer()
        {
            txtResult.Location = new Point(302, 149);
            lblTextHexa.Visible = false;
            lblTextDecimal.Visible = false;
            lblTextOctal.Visible = false;
            lblTextBinary.Visible = false;
            lblResultHexa.Visible = false;
            lblResultDecimal.Visible = false;
            lblResultOctal.Visible = false;
            lblResultBinary.Visible = false;
        }

        private void btnShowTreeView_Click(object sender, EventArgs e)
        {
            TreeViewCalculator.Visible = false;
            btnShowTreeView.Visible = false;
            btnHideTreeView.Visible = true;
            TreeViewCalculator.BringToFront();
            TreeViewCalculator.Location = new Point(-215, 0);
            //TreeViewCalculator.TopNode.NodeFont = Font.Bold;
        }

        private void btnHideTreeView_Click(object sender, EventArgs e)
        {
            TreeViewCalculator.Visible = true;
            btnHideTreeView.Visible = false;
            btnShowTreeView.Visible = true;
            TreeViewCalculator.BringToFront();
            btnShowTreeView.BringToFront();
            TreeViewCalculator.Location = new Point(0, 0);
        }
        void ShowHideLabels()
        {
            btnShowTreeView.Visible = false;
            btnHideTreeView.Visible = true;
        }
         public void BtnShowOnStandard()
        {
            this.txtResult.TextAlign = HorizontalAlignment.Right;
            lblResultOf.Location = new Point(16, 120);
            lblResultOf.Size = new Size(795,19);
            txtResult.Location = new Point(16, 150);
            txtResult.Size = new Size(795, 39);
            btnBackSpace.Size = new Size(208, 62);
            btnDivide.Size = new Size(208, 62);
            btnMultiply.Size = new Size(208, 62);
            btnPlus.Size = new Size(208, 62);
            btnMinus.Size = new Size(208, 62);
            btnFirstMinus.Size = new Size(208, 62);
            btnThree.Size = new Size(208, 62);
            btnSix.Size = new Size(208, 62);
            btnNine.Size = new Size(208, 62);
            btnEqual.Size = new Size(208, 62);
            btnClearAll.Size = new Size(208, 62);
            btnTwo.Size = new Size(208, 62);
            btnFive.Size = new Size(208, 62);
            btnEight.Size = new Size(208, 62);
            btnDot.Size = new Size(208, 62);
            btnClear.Size = new Size(208, 62);
            btnOne.Size = new Size(208, 62);
            btnFour.Size = new Size(208, 62);
            btnSeven.Size = new Size(208, 62);
            btnZero.Size = new Size(208, 62);

            btnBackSpace.Location = new Point(623, 223);
            btnDivide.Location = new Point(623, 285);
            btnMultiply.Location = new Point(623, 347);
            btnPlus.Location = new Point(623, 409);
            btnMinus.Location = new Point(623, 471);
            btnFirstMinus.Location = new Point(416, 223);
            btnThree.Location = new Point(416, 285);
            btnSix.Location = new Point(416, 347);
            btnNine.Location = new Point(416, 409);
            btnEqual.Location = new Point(416, 471);
            btnClearAll.Location = new Point(208, 223);
            btnTwo.Location = new Point(208, 285);
            btnFive.Location = new Point(208, 347);
            btnEight.Location = new Point(208, 409);
            btnDot.Location = new Point(208, 471);
            btnClear.Location = new Point(0, 223);
            btnOne.Location = new Point(0, 285);
            btnFour.Location = new Point(0, 347);
            btnSeven.Location = new Point(0, 409);
            btnZero.Location = new Point(0, 471);

            btnRightBracket.Visible = false;
            btnLeftBracket.Visible = false;
            btnTanjant.Visible = false;
            btnTanjanth.Visible = false;
            btnCosinh.Visible = false;
            btnCosin.Visible = false;
            btnSin.Visible = false;
            btnSinh.Visible = false;
            btnNumberDevideByNumber.Visible = false;
            btnPercent.Visible = false;
            btnXPowerOfThree.Visible = false;
            btnXPowerOfTwo.Visible = false;
            btnSquareRoot.Visible = false;
            btnExp.Visible = false;
            btnModulas.Visible = false;
            btnLogarithm.Visible = false;
            btnFactorial.Visible = false;
            btnTenPowerOfNumber.Visible = false;
            btnNumberPowerOfNumber.Visible = false;
            btnPie.Visible = false;

            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            btnE.Visible = false;
            btnF.Visible = false;

            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
            btnDot.Enabled = true;
            lblResultOf.Text = "";
            txtResult.Text = "0";
            PanelTempreture.Visible = false;
            cmbTempreture.Visible = false;
            cmbTempretureResult.Visible = false;
            txtTempreture.Visible = false;
            //txtTempretureResult.Visible = false;
            PanelTempreture.Visible = false;
            lblResultOf.Visible = true;

        }
        void BtnShowOnScientific()
        {
            //here we change location and size of txtResult and lblResult of 
            this.txtResult.TextAlign = HorizontalAlignment.Right;
            lblResultOf.Location = new Point(16, 120);
            lblResultOf.Size = new Size(795, 19);
            txtResult.Location = new Point(16, 150);
            txtResult.Size = new Size(795, 39);

            btnBackSpace.Size = new Size(105, 62);
            btnDivide.Size = new Size(105, 62);
            btnMultiply.Size = new Size(105, 62);
            btnPlus.Size = new Size(105, 62);
            btnMinus.Size = new Size(105, 62);
            btnFirstMinus.Size = new Size(105, 62);
            btnThree.Size = new Size(105, 62);
            btnSix.Size = new Size(105, 62);
            btnNine.Size = new Size(105, 62);
            btnEqual.Size = new Size(105, 62);
            btnClearAll.Size = new Size(105, 62);
            btnTwo.Size = new Size(105, 62);
            btnFive.Size = new Size(105, 62);
            btnEight.Size = new Size(105, 62);
            btnDot.Size = new Size(105, 62);
            btnClear.Size = new Size(105, 62);
            btnOne.Size = new Size(105, 62);
            btnFour.Size = new Size(105, 62);
            btnSeven.Size = new Size(105, 62);
            btnZero.Size = new Size(105, 62);
            btnTanjant.Size = new Size(105, 62);
            btnTanjanth.Size = new Size(105, 62);
            btnModulas.Size = new Size(105, 62);
            btnPie.Size = new Size(105, 62);
            btnRightBracket.Size = new Size(105, 62);
            btnCosin.Size = new Size(105, 62);
            btnCosinh.Size = new Size(105, 62);
            btnExp.Size = new Size(105, 62);
            btnPercent.Size = new Size(105, 62);
            btnLeftBracket.Size = new Size(105, 62);
            btnSin.Size = new Size(105, 62);
            btnSinh.Size = new Size(105, 62);
            btnLogarithm.Size = new Size(105, 62);
            btnSquareRoot.Size = new Size(105, 62);
            btnFactorial.Size = new Size(105, 62);
            btnXPowerOfTwo.Size = new Size(105, 62);
            btnXPowerOfThree.Size = new Size(105, 62);
            btnTenPowerOfNumber.Size = new Size(105, 62);
            btnNumberPowerOfNumber.Size = new Size(105, 62);
            btnNumberDevideByNumber.Size = new Size(105, 62);

            btnBackSpace.Location = new Point(725, 223);
            btnDivide.Location = new Point(725, 285);
            btnMultiply.Location = new Point(725, 347);
            btnPlus.Location = new Point(725, 409);
            btnMinus.Location = new Point(725, 471);
            btnFirstMinus.Location = new Point(621, 223);
            btnThree.Location = new Point(621, 285);
            btnSix.Location = new Point(621, 347);
            btnNine.Location = new Point(621, 409);
            btnEqual.Location = new Point(621, 471);
            btnClearAll.Location = new Point(517, 223);
            btnTwo.Location = new Point(517, 285);
            btnFive.Location = new Point(517, 347);
            btnEight.Location = new Point(517, 409);
            btnDot.Location = new Point(517, 471);
            btnClear.Location = new Point(414, 223);
            btnOne.Location = new Point(414, 285);
            btnFour.Location = new Point(414, 347);
            btnSeven.Location = new Point(414, 409);
            btnZero.Location = new Point(414, 471);
            btnTanjant.Location = new Point(309, 223);
            btnTanjanth.Location = new Point(309, 285);
            btnModulas.Location = new Point(309, 347);
            btnPie.Location = new Point(309, 409);
            btnRightBracket.Location = new Point(309, 471);
            btnCosin.Location = new Point(205, 223);
            btnCosinh.Location = new Point(205, 285);
            btnExp.Location = new Point(205, 347);
            btnPercent.Location = new Point(205, 409);
            btnLeftBracket.Location = new Point(205, 471);
            btnSin.Location = new Point(101, 223);
            btnSinh.Location = new Point(101, 285);
            btnLogarithm.Location = new Point(101, 347);
            btnSquareRoot.Location = new Point(101, 409);
            btnFactorial.Location = new Point(101, 471);
            btnXPowerOfTwo.Location = new Point(0, 223);
            btnXPowerOfThree.Location = new Point(0, 285);
            btnTenPowerOfNumber.Location = new Point(0, 347);
            btnNumberPowerOfNumber.Location = new Point(0, 409);
            btnNumberDevideByNumber.Location = new Point(0, 471);

            btnRightBracket.Visible = true;
            btnLeftBracket.Visible = true;
            btnTanjant.Visible = true;
            btnTanjanth.Visible = true;
            btnCosinh.Visible = true;
            btnCosin.Visible = true;
            btnSin.Visible = true;
            btnSinh.Visible = true;
            btnNumberDevideByNumber.Visible = true;
            btnPercent.Visible = true;
            btnXPowerOfThree.Visible = true;
            btnXPowerOfTwo.Visible = true;
            btnSquareRoot.Visible = true;
            btnExp.Visible = true;
            btnModulas.Visible = true;
            btnLogarithm.Visible = true;
            btnFactorial.Visible = true;
            btnTenPowerOfNumber.Visible = true;
            btnNumberPowerOfNumber.Visible = true;
            btnPie.Visible = true;

            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            btnE.Visible = false;
            btnF.Visible = false;

            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
            btnDot.Enabled = true;
            lblResultOf.Text = "";
            txtResult.Text = "0";
            PanelTempreture.Visible = false;
            lblResultOf.Visible = true;
        }

        void btnShowOnProgrammer()
        {
            btnBackSpace.Size = new Size(138, 50);
            btnDivide.Size = new Size(138, 50);
            btnMultiply.Size = new Size(138, 50);
            btnPlus.Size = new Size(138, 50);
            btnMinus.Size = new Size(138, 50);
            btnFirstMinus.Size = new Size(138, 50);
            btnThree.Size = new Size(138, 50);
            btnSix.Size = new Size(138, 50);
            btnNine.Size = new Size(138, 50);
            btnEqual.Size = new Size(138, 50);
            btnClearAll.Size = new Size(138, 50);
            btnTwo.Size = new Size(138, 50);
            btnFive.Size = new Size(138, 50);
            btnEight.Size = new Size(138, 50);
            btnDot.Size = new Size(138, 50);
            btnClear.Size = new Size(138, 50);
            btnOne.Size = new Size(138, 50);
            btnFour.Size = new Size(138, 50);
            btnSeven.Size = new Size(138, 50);
            btnZero.Size = new Size(138, 50);
            btnModulas.Size = new Size(138, 50);
            btnB.Size = new Size(138, 50);
            btnD.Size = new Size(138, 50);
            btnF.Size = new Size(138, 50);
            btnRightBracket.Size = new Size(138, 50);
            btnExp.Size = new Size(138, 50);
            btnA.Size = new Size(138, 50);
            btnC.Size = new Size(138, 50);
            btnE.Size = new Size(138, 50);
            btnLeftBracket.Size = new Size(138, 50);

            btnBackSpace.Location = new Point(690, 283);
            btnDivide.Location = new Point(690, 333);
            btnMultiply.Location = new Point(690, 383);
            btnPlus.Location = new Point(690, 433);
            btnMinus.Location = new Point(690, 483);
            btnFirstMinus.Location = new Point(552, 283);
            btnThree.Location = new Point(552, 333);
            btnSix.Location = new Point(552, 383);
            btnNine.Location = new Point(552, 433);
            btnEqual.Location = new Point(551, 483);
            btnClearAll.Location = new Point(414, 283);
            btnTwo.Location = new Point(414, 333);
            btnFive.Location = new Point(414, 383);
            btnEight.Location = new Point(414, 433);
            btnDot.Location = new Point(414, 483);
            btnClear.Location = new Point(276, 283);
            btnOne.Location = new Point(276, 333);
            btnFour.Location = new Point(276, 383);
            btnSeven.Location = new Point(276, 433);
            btnZero.Location = new Point(276, 483);
            btnModulas.Location = new Point(138, 283);
            btnB.Location = new Point(138, 333);
            btnD.Location = new Point(138, 383);
            btnF.Location = new Point(138, 433);
            btnRightBracket.Location = new Point(138, 483);
            btnExp.Location = new Point(0, 283);
            btnA.Location = new Point(0, 333);
            btnC.Location = new Point(0, 383);
            btnE.Location = new Point(0, 433);
            btnLeftBracket.Location = new Point(0, 483);

            btnTanjant.Visible = false;
            btnTanjanth.Visible = false;
            btnCosin.Visible = false;
            btnCosinh.Visible = false;
            btnSin.Visible = false;
            btnSinh.Visible = false;
            btnFactorial.Visible = false;
            btnLogarithm.Visible = false;
            btnPercent.Visible = false;
            btnXPowerOfThree.Visible = false;
            btnXPowerOfTwo.Visible = false;
            btnNumberDevideByNumber.Visible = false;
            btnNumberPowerOfNumber.Visible = false;
            btnSquareRoot.Visible = false;
            btnTenPowerOfNumber.Visible = false;
            btnPie.Visible = false;

            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            btnE.Visible = true;
            btnF.Visible = true;

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;

            btnExp.Visible = true;
            btnModulas.Visible = true;
            btnRightBracket.Visible = true;
            btnLeftBracket.Visible = true;
            lblTextHexa.Visible = true;
            lblTextDecimal.Visible = true;
            lblTextOctal.Visible = true;
            lblTextBinary.Visible = true;
            lblResultHexa.Visible = true;
            lblResultDecimal.Visible = true;
            lblResultOctal.Visible = true;
            lblResultBinary.Visible = true;
            txtResult.Location = new Point(302, 44);
            lblTextHexa.BringToFront();
            lblTextDecimal.BringToFront();
            lblTextOctal.BringToFront();
            lblResultBinary.BringToFront();
            btnDot.Enabled = false;
            txtResult.Location = new Point(12,117);
            txtResult.Size = new Size(808, 39);
            lblResultOf.Location = new Point(16,90);
            lblResultOf.Size = new Size(795,19);

            lblResultHexa.Location = new Point(57,175);
            lblResultDecimal.Location = new Point(57,203);
            lblResultOctal.Location = new Point(57,230);
            lblResultBinary.Location = new Point(57,225);

            lblTextHexa.Location = new Point(12,173);
            lblTextDecimal.Location = new Point(12,201);
            lblTextOctal.Location = new Point(12,228);
            lblTextBinary.Location = new Point(12,253);

            lblResultHexa.Size = new Size(767,19);
            lblResultDecimal.Size = new Size(767,19);
            lblResultOctal.Size = new Size(767,19);
            lblResultBinary.Size = new Size(767,19);

            lblTextHexa.Size = new Size(36,19);
            lblTextDecimal.Size = new Size(36,19);
            lblTextOctal.Size = new Size(36,19);
            lblTextBinary.Size = new Size(36,19);
            lblResultBinary.BringToFront();
            lblResultOf.Text = "";
            txtResult.Text = "0";
            PanelTempreture.Visible = false;
            this.txtResult.TextAlign = HorizontalAlignment.Right;
            cmbTempreture.Visible = false;
            cmbTempretureResult.Visible = false;
            txtTempreture.Visible = false;

        }
        void btnHideOnTempreture()
        {
            RichTextBox.Location = new Point(834, -2);
            RichTextBoxHistory.Location = new Point(837, 97);
            lblMemory.Location = new Point(942, 48);
            lblHistory.Location = new Point(851, 48);
            lblNoHIstory.Location = new Point(851, 91);
     
            lblMemory.Size = new Size(67, 19);
            lblHistory.Size = new Size(58, 19);
            lblNoHIstory.Size = new Size(158, 19);
            
            RichTextBoxHistory.Size = new Size(317, 391);
            RichTextBox.Size = new Size(320, 536);
            btnDivide.Visible = true;
            btnMultiply.Visible = true;
            btnPlus.Visible = true;
            btnMinus.Visible = true;
            btnEqual.Visible = true;
            RichTextBox.Visible = true;
            RichTextBoxHistory.Visible = true;
            lblMemory.Visible = true;
            lblNoHIstory.Visible = true;
            lblHistory.Visible = true;

        }
        void btnShowOnTempreture()
        {
            btnBackSpace.Location = new Point(953, 172);
            btnThree.Location = new Point(953, 237);
            btnSix.Location = new Point(953, 302);
            btnNine.Location = new Point(953, 367);
            btnDot.Location = new Point(953, 432);
            btnClearAll.Location = new Point(783, 172);
            btnTwo.Location = new Point(783, 237);
            btnFive.Location = new Point(783, 302);
            btnEight.Location = new Point(783, 367);
            btnZero.Location = new Point(783, 432);
            btnClear.Location = new Point(613, 172);
            btnOne.Location = new Point(613, 237);
            btnFour.Location = new Point(613, 302);
            btnSeven.Location = new Point(613, 367);
            btnFirstMinus.Location = new Point(613, 432);

            btnBackSpace.Size = new Size(170,65);
            btnThree.Size = new Size(170, 65);
            btnSix.Size = new Size(170, 65);
            btnNine.Size = new Size(170, 65);
            btnDot.Size = new Size(170, 65);
            btnClearAll.Size = new Size(170, 65);
            btnTwo.Size = new Size(170, 65);
            btnFive.Size = new Size(170, 65);
            btnEight.Size = new Size(170, 65);
            btnZero.Size = new Size(170, 65);
            btnClear.Size = new Size(170, 65);
            btnOne.Size = new Size(170, 65);
            btnFour.Size = new Size(170, 65);
            btnSeven.Size = new Size(170, 65);
            btnFirstMinus.Size = new Size(170, 65);

            lblHistory.Visible = false;
            lblNoHIstory.Visible = false;
            lblMemory.Visible = false;

            RichTextBox.Visible = false;
            RichTextBoxHistory.Visible = false;
            lblResultOf.Visible = false;
            txtTempreture.Visible = true;
            cmbTempreture.Visible = true;
            cmbTempretureResult.Visible = true;
            PanelTempreture.Size = new Size(575, 534);
            PanelTempreture.Location = new Point(579, -1);
            PanelTempreture.Visible = true;
            btnDivide.Visible = false;
            btnMultiply.Visible = false;
            btnPlus.Visible = false;
            btnMinus.Visible = false;
            btnEqual.Visible = false;
            lblHistory.Visible = false;
            lblNoHIstory.Visible = false;
            lblMemory.Visible = false;

            RichTextBox.Visible = false;
            RichTextBoxHistory.Visible = false;
            PanelTempreture.SendToBack();
            btnExp.Visible = false;
            btnModulas.Visible = false;
            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            btnE.Visible = false;
            btnF.Visible = false;
            btnRightBracket.Visible = false;
            btnLeftBracket.Visible = false;
            btnDot.Visible = true;
            btnSin.Visible = false;
            btnSinh.Visible = false;
            btnLogarithm.Visible = false;
            btnExp.Visible = false;
            btnTanjant.Visible = false;
            btnTanjanth.Visible = false;
            btnCosin.Visible = false;
            btnCosinh.Visible = false;
            btnXPowerOfThree.Visible = false;
            btnXPowerOfTwo.Visible = false;
            btnPercent.Visible = false;
            btnNumberDevideByNumber.Visible = false;
            btnFactorial.Visible = false;
            btnPie.Visible = false;
            btnSquareRoot.Visible = false;
            btnNumberPowerOfNumber.Visible = false;
            btnTenPowerOfNumber.Visible = false;

            txtResult.Location = new Point(33, 155);
            cmbTempretureResult.Location = new Point(33, 223);
            txtTempreture.Location = new Point(33, 336);
            cmbTempreture.Location = new Point(33, 396);

            txtResult.Size = new Size(325, 54);
            cmbTempretureResult.Size = new Size(325, 21);
            txtTempreture.Size = new Size(325, 54);
            cmbTempreture.Size = new Size(325, 21);
            this.txtResult.TextAlign = HorizontalAlignment.Left;
            txtResult.Text = "0";

        }
        private void TreeViewCalculator_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "NodeCalculator")
            {
                lblHeading.Text = "STANDARD";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                //e.Node.NodeFont = ("bold");
               // NodeCalculator.ForeColor = Color.red;
                
            }
            if (e.Node.Name == "NodeConverter")
            {
                lblHeading.Text = "STANDARD";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
            }
            if (e.Node.Name == "NodeStandard")
            {
                lblHeading.Text = "STANDARD";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                BtnShowOnStandard();
                btnHideOnTempreture();
            }
            if (e.Node.Name == "NodeScientific")
            {
                lblHeading.Text = "SCIECTIFIC";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                BtnShowOnScientific();
                btnHideOnTempreture();

            }
            if (e.Node.Name == "NodeProgrammer")
            {
                lblHeading.Text = "PROGRAMMER";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                btnShowOnProgrammer();
                btnHideOnTempreture();
            }
            if (e.Node.Name == "NodeVolume")
            {
                lblHeading.Text = "VOLUME";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
            if (e.Node.Name == "NodeLength")
            {
                lblHeading.Text = "LENGTH";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
            if (e.Node.Name == "NodeWeight and Mass")
            {
                lblHeading.Text = "WEIGHT AND MASS";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
            if (e.Node.Name == "NodeTempreture")
            {
                lblHeading.Text = "TEMPRETURE";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
            if (e.Node.Name == "NodeEnergy")
            {
                lblHeading.Text = "ENERGY";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
            if (e.Node.Name == "NodeArea")
            {
                lblHeading.Text = "AREA";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
            if (e.Node.Name == "NodeSpeed")
            {
                lblHeading.Text = "SPEED";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
            if (e.Node.Name == "NodeTime")
            {
                lblHeading.Text = "TIME";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
            if (e.Node.Name == "NodePower")
            {
                lblHeading.Text = "POWER";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
            if (e.Node.Name == "NodeData")
            {
                lblHeading.Text = "DATA";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
            if (e.Node.Name == "NodePressure")
            {
                lblHeading.Text = "PRESSURE";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
            if (e.Node.Name == "NodeAngle")
            {
                lblHeading.Text = "ANGLE";
                TreeViewCalculator.Visible = false;
                ShowHideLabels();
                labelProgrammer();
                btnShowOnTempreture();
            }
        }

        private void TreeViewCalculator_MouseHover(object sender, EventArgs e)
        {
        }

        private void Numbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ((txtResult.Text == "0") || (Enter_Value))
                txtResult.Text = "";
            Enter_Value = false;
            if (button.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + button.Text;
            }
            else
            {
                txtResult.Text = txtResult.Text + button.Text;
            }

            try
            {
                long a = long.Parse(txtResult.Text);
                lblResultHexa.Text = System.Convert.ToString(a, 16);

                long b = long.Parse(txtResult.Text);
                lblResultDecimal.Text = System.Convert.ToString(b, 10);

                long c = long.Parse(txtResult.Text);
                lblResultOctal.Text = System.Convert.ToString(c, 8);

                long d = long.Parse(txtResult.Text);
                lblResultBinary.Text = System.Convert.ToString(d, 2);
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void Arithematic_Operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Result != 0)
            {
                btnEqual.PerformClick();
                Enter_Value = true;
                Operation = button.Text;
                lblResultOf.Text = System.Convert.ToString(Result) + " " + Operation;
            }
            else
            {
                Operation = button.Text;
                Result = Double.Parse(txtResult.Text);
                Enter_Value = true;
                lblResultOf.Text = System.Convert.ToString(Result) + " " + Operation;
            }
            FirstNum = lblResultOf.Text;
        }
        void OverWriteNumbers(object sender)
        {
            Button button = (Button)sender;
            Operation = button.Text;
            Result = Double.Parse(txtResult.Text);
            Enter_Value = true;
            lblResultOf.Text = System.Convert.ToString(Result) + " " + Operation;
            // After Every clicks of Equals we should clear the label Result
            lblResultOf.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            Result = 0;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblResultOf.Text = "";
            lblResultBinary.Text = "";
            lblResultDecimal.Text = "";
            lblResultOctal.Text = "";
            lblResultHexa.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            SecondNum = txtResult.Text;
            lblResultOf.Text = "";

            switch (Operation)
            {
                case "+":
                    txtResult.Text = (Result + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (Result - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "‎✕‎":
                    txtResult.Text = (Result * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "‎➗‎":
                    txtResult.Text = (Result / Double.Parse(txtResult.Text)).ToString();
                    break;
                case "Mod":
                    txtResult.Text = (Result % Double.Parse(txtResult.Text)).ToString();
                    break;
                 
                case "Exp":
                    double i = Double.Parse(txtResult.Text);
                    double q;
                    q = (Result);
                    txtResult.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
            Result = Double.Parse(txtResult.Text);
            Operation = "";
            OverWriteNumbers(sender);
     
            /////////////////////////////////////////////////////////////
            RichTextBoxHistory.AppendText(FirstNum + "   " + SecondNum + "  =  " + "\n");
            RichTextBoxHistory.AppendText("\n\t" + txtResult.Text + "\n\n");
            lblNoHIstory.Text = "";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnLogarithm_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtResult.Text);
            lblResultOf.Text = System.Convert.ToString("Log" + "(" + (txtResult.Text) + ")");
            ilog = Math.Log10(ilog);
            txtResult.Text = System.Convert.ToString(ilog);
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(txtResult.Text);
            lblResultOf.Text = System.Convert.ToString("‎‎√‎" + "(" + (txtResult.Text) + ")");
            sq = Math.Sqrt(sq);
            txtResult.Text = System.Convert.ToString(sq);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double Sine = double.Parse(txtResult.Text);
            lblResultOf.Text = System.Convert.ToString("‎‎Sin‎" + "(" + (txtResult.Text) + ")");
            Sine = Math.Sin(Sine);
            txtResult.Text = System.Convert.ToString(Sine);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double Sineh = double.Parse(txtResult.Text);
            lblResultOf.Text = System.Convert.ToString("‎‎Sin‎ h" + "(" + (txtResult.Text) + ")");
            Sineh = Math.Sinh(Sineh);
            txtResult.Text = System.Convert.ToString(Sineh);
        }

        private void btnCosin_Click(object sender, EventArgs e)
        {
            double Cosin = double.Parse(txtResult.Text);
            lblResultOf.Text = System.Convert.ToString("‎‎Cosin‎" + "(" + (txtResult.Text) + ")");
            Cosin = Math.Cos(Cosin);
            txtResult.Text = System.Convert.ToString(Cosin);
        }

        private void btnCosinh_Click(object sender, EventArgs e)
        {
            double Cosinh = double.Parse(txtResult.Text);
            lblResultOf.Text = System.Convert.ToString("‎‎Cosin h‎" + "(" + (txtResult.Text) + ")");
            Cosinh = Math.Cosh(Cosinh);
            txtResult.Text = System.Convert.ToString(Cosinh);
        }

        private void btnTanjant_Click(object sender, EventArgs e)
        {
            double Tanjant = double.Parse(txtResult.Text);
            lblResultOf.Text = System.Convert.ToString("‎‎Tanjant‎" + "(" + (txtResult.Text) + ")");
            Tanjant = Math.Tan(Tanjant);
            txtResult.Text = System.Convert.ToString(Tanjant);
        }

        private void btnTanjanth_Click(object sender, EventArgs e)
        {
            double Tanjanth = double.Parse(txtResult.Text);
            lblResultOf.Text = System.Convert.ToString("‎‎Tanjant h‎" + "(" + (txtResult.Text) + ")");
            Tanjanth = Math.Tanh(Tanjanth);
            txtResult.Text = System.Convert.ToString(Tanjanth);
        }

        private void btnXPowerOfTwo_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a);
        }

        private void btnXPowerOfThree_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a);
        }

        private void btnNumberDevideByNumber_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0/ Convert.ToDouble(txtResult.Text));
            txtResult.Text = System.Convert.ToString(a);
        }

        private void lblTextHexa_Click(object sender, EventArgs e)
        {
            btnZero.Enabled = true;
            btnOne.Enabled = true;
            btnDot.Enabled = false;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            lblTextDecimal.ForeColor = Color.Black;
            lblTextBinary.ForeColor = Color.Black;
            lblTextHexa.ForeColor = Color.Blue;
            lblTextOctal.ForeColor = Color.Black;
        }

        private void lblTextBinary_Click(object sender, EventArgs e)
        {
            btnZero.Enabled = true;
            btnOne.Enabled = true;
            btnDot.Enabled = false;
            btnTwo.Enabled = false;
            btnThree.Enabled = false;
            btnFour.Enabled = false;
            btnFive.Enabled = false;
            btnSix.Enabled = false;
            btnSeven.Enabled = false;
            btnEight.Enabled = false;
            btnNine.Enabled = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            lblTextDecimal.ForeColor = Color.Black;
            lblTextBinary.ForeColor = Color.Blue;
            lblTextHexa.ForeColor = Color.Black;
            lblTextOctal.ForeColor = Color.Black;

        }

        private void lblTextDecimal_Click(object sender, EventArgs e)
        {
            btnZero.Enabled = true;
            btnOne.Enabled = true;
            btnDot.Enabled = false;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            lblTextDecimal.ForeColor = Color.Blue;
            lblTextBinary.ForeColor = Color.Black;
            lblTextHexa.ForeColor = Color.Black;
            lblTextOctal.ForeColor = Color.Black;
        }

        private void lblTextOctal_Click(object sender, EventArgs e)
        {
            btnZero.Enabled = true;
            btnOne.Enabled = true;
            btnDot.Enabled = false;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = false;
            btnNine.Enabled = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            lblTextDecimal.ForeColor = Color.Black;
            lblTextBinary.ForeColor = Color.Black;
            lblTextHexa.ForeColor = Color.Black;
            lblTextOctal.ForeColor = Color.Blue;
        }

        private void lblTextHexa_MouseHover(object sender, EventArgs e)
        {
            lblTextHexa.BackColor = Color.Gray;
        }

        private void lblTextHexa_MouseLeave(object sender, EventArgs e)
        {
            lblTextHexa.BackColor = Color.White;
        }

        private void btnEquals_MouseHover(object sender, EventArgs e)
        {
            btnEqual.ForeColor = Color.White;
            btnEqual.BackColor = Color.LightBlue;
        }

        private void btnEquals_MouseLeave(object sender, EventArgs e)
        {
            btnEqual.ForeColor = Color.Black;
            btnEqual.BackColor = Color.Gainsboro;
        }

        private void txtBinary_MouseHover(object sender, EventArgs e)
        {
            //txtBinary.BackColor = Color.Green;
        }

        private void btnEquals_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnEqual.BackColor = Color.Blue;
        }

        private void btnEquals_KeyUp(object sender, KeyEventArgs e)
        {
            btnEqual.BackColor = Color.Snow;
        }

        private void btnEquals_MouseClick(object sender, MouseEventArgs e)
        {
            btnEqual.BackColor = Color.Blue;
        }

        private void btnEquals_MouseDown(object sender, MouseEventArgs e)
        {
            btnEqual.BackColor = Color.Silver;
        }

        private void Alphabet_Clicks(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text = txtResult.Text + button.Text;
            try
            {
                //char a = char.Parse(txtResult.Text);
               // lblResultHexa.Text = System.Convert.ToString(a, 16);
                lblResultHexa.Text = txtResult.Text;

                int b = int.Parse(txtResult.Text);
                lblResultDecimal.Text = System.Convert.ToString(b, 10);
                //lblResultDecimal.Text = txtResult.Text;

                int c = int.Parse(txtResult.Text);
                lblResultOctal.Text = System.Convert.ToString(c, 8);

                int d = int.Parse(txtResult.Text);
                lblResultBinary.Text = System.Convert.ToString(2, d);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnFirstMinus_Click(object sender, EventArgs e)
        {
          //  double Sine = double.Parse(txtResult.Text);
            //Result = Double.Parse(txtResult.Text);
            //Enter_Value = true;
            //txtResult.Text = System.Convert.ToString("-") + txtResult.Text;

         //  txtResult.Text = txtResult.Text+"-";
        }

        private void btnFirstMinus_Click_1(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "0";
            }
            else
            {
                txtResult.Text = System.Convert.ToString("-") + txtResult.Text;
            }   
        }
        private void cmbTempretureResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTempretureResult.SelectedIndex == 0)
            {
                if (cmbTempreture.SelectedIndex == 0)
                {
                    double iCelsius = float.Parse(txtResult.Text);
                    txtTempreture.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                }
               
            }
            if (cmbTempretureResult.SelectedIndex==1)
            {
                double iFahrenheit = float.Parse(txtResult.Text);
                txtTempreture.Text = ((((iFahrenheit-32) * 5) / 9).ToString());
            }
            if (cmbTempretureResult.SelectedIndex==2)
            {
                double iKelvin = float.Parse(txtResult.Text);
                txtTempreture.Text = (((((9 * iKelvin) / 5) + 32) + 273.15).ToString());
            }
        }
        private void lblClearHistory_Click(object sender, EventArgs e)
        {
            RichTextBoxHistory.Clear();
            if (lblNoHIstory.Text == "")
            {
                lblNoHIstory.Text = "There's no history yet";
            }
      
        }
    }
}
  
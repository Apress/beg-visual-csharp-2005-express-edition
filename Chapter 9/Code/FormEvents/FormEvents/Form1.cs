using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Activated");
        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Autosizechanged");
           
        }

        private void Form1_AutoValidateChanged(object sender, EventArgs e)
        {
            Console.WriteLine("AutoValidateChanged");
        }

        private void Form1_BackColorChanged(object sender, EventArgs e)
        {
            Console.WriteLine("BackColorChanged");
        }

        private void Form1_BackgroundImageChanged(object sender, EventArgs e)
        {
            Console.WriteLine("BackgroundImageChanged");

        }

        private void Form1_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {
            Console.WriteLine("BackgroundImageLayoutChanged");
        }

        private void Form1_BindingContextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("BindingContextChanged");
        }

        private void Form1_CausesValidationChanged(object sender, EventArgs e)
        {
            Console.WriteLine("CausesValidationChanged");
        }

        private void Form1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            Console.WriteLine("ChangeUICues");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click");
        }

        private void Form1_ContextMenuStripChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ContextMenuStripChanged");
        }

        private void Form1_ControlAdded(object sender, ControlEventArgs e)
        {
            Console.WriteLine("ControlAdded");
        }

        private void Form1_ControlRemoved(object sender, ControlEventArgs e)
        {
            Console.WriteLine("ControlRemoved");
        }

        private void Form1_CursorChanged(object sender, EventArgs e)
        {
            Console.WriteLine("CursorChanged");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Console.WriteLine("Deactivate");
        }

        private void Form1_DockChanged(object sender, EventArgs e)
        {
            Console.WriteLine("DockChanged");

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine("DoubleClick");
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragDrop");
         
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragEnter");
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            Console.WriteLine("DragLeave");
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragOver");
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            Console.WriteLine("EnabledChanged");
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Enter");
        }

        private void Form1_FontChanged(object sender, EventArgs e)
        {
            Console.WriteLine("FontChanged");
        }

        private void Form1_ForeColorChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ForeColorChanged");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("FormClosed");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("FormClosing");
        }

        private void Form1_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            Console.WriteLine("GiveFeedback");
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Console.WriteLine("HelpButtonClicked");
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Console.WriteLine("HelpRequested");
        }

        private void Form1_ImeModeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ImeModeChanged");
        }

        private void Form1_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            Console.WriteLine("InputLanguageChanged");
        }

        private void Form1_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {
            Console.WriteLine("InputLanguageChanging");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("KeyDown");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("KeyPress");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("KeyUp");
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Console.WriteLine("Layout");
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("Leave");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Load");
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            Console.WriteLine("LocationChanged");
        }

        private void Form1_MarginChanged(object sender, EventArgs e)
        {
            Console.WriteLine("MarginChanged");
        }

        private void Form1_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            Console.WriteLine("MaximizedBoundsChanged");
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("MAximumSizeChanged");
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            Console.WriteLine("MdiChildActivate");
        }

        private void Form1_MenuComplete(object sender, EventArgs e)
        {
            Console.WriteLine("MenuComplete");
        }

        private void Form1_MenuStart(object sender, EventArgs e)
        {
            Console.WriteLine("MenuStart");
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("MinimumSizeChanged");
        }

        private void Form1_MouseCaptureChanged(object sender, EventArgs e)
        {
            Console.WriteLine("MouseCaptureChanged");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("MouseClick");
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("MouseDoubleClick");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("MouseDown");
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("MouseEnter");
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            Console.WriteLine("MouseHover");
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Console.WriteLine("MouseLeave");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("MouseMove");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("MouseUp");
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            Console.WriteLine("Move");
        }

        private void Form1_PaddingChanged(object sender, EventArgs e)
        {
            Console.WriteLine("PaddingChanged");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Paint");
        }

        private void Form1_ParentChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ParentChanged");
        }

        private void Form1_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {
            Console.WriteLine("QueryAccessibilityHelp");
        }

        private void Form1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            Console.WriteLine("QueryContinueDrag");
        }

        private void Form1_RegionChanged(object sender, EventArgs e)
        {
            Console.WriteLine("RegionChanged");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Console.WriteLine("Resize");
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            Console.WriteLine("ResizeBegin");
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Console.WriteLine("ResizeEnd");
        }

        private void Form1_RightToLeftChanged(object sender, EventArgs e)
        {
            Console.WriteLine("RightToLeftChanged");
        }

        private void Form1_RightToLeftLayoutChanged(object sender, EventArgs e)
        {
            Console.WriteLine("RightToLeftLayoutChanged");
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
            Console.WriteLine("Scroll");

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("Shown");
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("SizeChanged");
        }

        private void Form1_StyleChanged(object sender, EventArgs e)
        {
            Console.WriteLine("StyleChanged");
        }

        private void Form1_SystemColorsChanged(object sender, EventArgs e)
        {
            Console.WriteLine("SystemColorsChanged");
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("TextChanged");
        }

        private void Form1_Validated(object sender, EventArgs e)
        {
            Console.WriteLine("Validated");
        }

        private void Form1_Validating(object sender, CancelEventArgs e)
        {
            Console.WriteLine("Validating");
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine("VisibleChanged");
        }
    }
}


using System.Windows.Forms;
using System.Collections.Generic;
using GladeConstructor.Gui;
using GladeConstructor.Parser;
using WeifenLuo.WinFormsUI.Docking;

namespace GladeConstructor
{

    public class GuiManager
    {
        private static List<BindingWidget> WidgetsList = new List<BindingWidget>();
        private static List<WindowContainer> WindowsList = new List<WindowContainer>();
        public static List<WidgetContainer> WidgetContainersList = new List<WidgetContainer>();
        public static List<SignalContainer> SignalContainerList = new List<SignalContainer>();

        public static DockPanel dockPanel { get; set; }

        public static WidgetContainer widgetContainer { get; set; }
        public static WindowContainer windowContainer { get; set; }

        public static WindowContainer CreateWindowPanel(BindingSource source, string FileName = null)
        {
            var panel = new WindowContainer();
            panel.SetDataSource(source);
            if (FileName != null)
            {
                panel.Text = System.IO.Path.GetFileName(FileName) + " -> " + "Gtk::Window";
            }
            else
            {
                panel.Text = "Gtk::Window";
            }
            
            return panel;
        }

        public static WidgetContainer CreateWidgetPanel(BindingForm form)
        {
            if (form.GUIContainerId < 0)
            {
                // Non è stato ancora creato il pannello relativo al widget
                WidgetContainer widgetContainer = new WidgetContainer(form);
                form.GUIContainerId = widgetContainer.ID;
                widgetContainer.Text = "Form " + form.Id;
                widgetContainer.Show(GuiManager.dockPanel, DockState.DockRight);
                WidgetContainersList.Add(widgetContainer);
                return widgetContainer;
            }
            else
            {
                //Search for the WidgetContainer with GUIContainerId
                WidgetContainer container = WidgetContainersList.Find(obj => obj.ID == form.GUIContainerId);
                //container.Focus();
                container.Show();
                return container;
            }   
        }

        public static SignalContainer CreateSignalPanel(BindingForm form)
        {
            long guid = form.GUISignalContainerId;
            SignalContainer container = CreateSignalPanel(guid, "Signals for Window " + form.Id, form.Signals);
            form.GUISignalContainerId = container.ID;
            return container;
        }

        public static SignalContainer CreateSignalPanel(BindingWidget widget)
        {
            long guid = widget.GUISignalContainerId;
            SignalContainer container = CreateSignalPanel(guid, "Signals for Widget " + widget.Id, widget.Signals);
            widget.GUISignalContainerId = container.ID;
            
            return container;
        }

        private static SignalContainer CreateSignalPanel(long GUId, string text, BindingSource source)
        {
            if (GUId < 0)
            {
                // Non è stato ancora creato il pannello relativo al widget
                SignalContainer signalContainer = new SignalContainer();
                signalContainer.Text = text;
                signalContainer.Show(GuiManager.dockPanel, DockState.DockRight);
                signalContainer.SetDataSource(source);
                SignalContainerList.Add(signalContainer);
                
                return signalContainer;
            }
            else
            {
                //Search for the WidgetContainer with GUIContainerId
                SignalContainer container = SignalContainerList.Find(obj => obj.ID == GUId);
                container.Show();
                return container;
            }
        }


    }

}
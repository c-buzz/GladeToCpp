using System.Windows.Forms;
using System.Collections.Generic;
using GladeConstructor.Gui;
using GladeConstructor.GladeParser;
using WeifenLuo.WinFormsUI.Docking;

namespace GladeConstructor
{

    public class GuiManager
    {
        private static List<BindingWidget> WidgetsList = new List<BindingWidget>();
        private static List<WindowContainer> WindowsList = new List<WindowContainer>();
        public static List<WidgetContainer> WidgetContainersList = new List<WidgetContainer>();

        public static DockPanel dockPanel { get; set; }

        /// <summary>
        ///     The Glade parser is initialized into the MainForm class
        /// </summary>
        public static GtkParser Parser { get; set; }

        public enum DockPanelType
        {
            FORM_CONTAINER,
            WIDGET_CONTAINER,
            OBJECT_CONTAINER
        }

        public static WidgetContainer widgetContainer { get; set; }
        public static WindowContainer windowContainer { get; set; }

        public static WindowContainer CreateWindowPanel(BindingSource source)
        {
            var panel = new WindowContainer(Parser);
            panel.SetDataSource(source);
            panel.Text = "Widget list";
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
                container.Focus();
                container.Show();
                return container;
            }
            
        }


    }

}
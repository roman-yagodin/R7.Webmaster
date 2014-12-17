
// This file has been generated by the GUI designer. Do not modify.
namespace R7.Webmaster
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Action undoAction;
		
		private global::Gtk.Action actionMenu;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Toolbar toolbar1;
		
		private global::Gtk.Toolbar toolbar2;
		
		private global::Gtk.Notebook notebook1;
		
		private global::Gtk.Label label1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget R7.Webmaster.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.undoAction = new global::Gtk.Action ("undoAction", null, null, "gtk-undo");
			w1.Add (this.undoAction, null);
			this.actionMenu = new global::Gtk.Action ("actionMenu", null, null, "gtk-execute");
			w1.Add (this.actionMenu, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "R7.Webmaster.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("R7.Webmaster");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("R7.Webmaster.icons.webmaster_128.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child R7.Webmaster.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'/></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.hbox1.Add (this.toolbar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.toolbar1]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar2'><toolitem name='actionMenu' action='actionMenu'/></toolbar></ui>");
			this.toolbar2 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar2")));
			this.toolbar2.Name = "toolbar2";
			this.toolbar2.ShowArrow = false;
			this.hbox1.Add (this.toolbar2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.toolbar2]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Notebook tab
			global::Gtk.Label w5 = new global::Gtk.Label ();
			w5.Visible = true;
			this.notebook1.Add (w5);
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
			this.notebook1.SetTabLabel (w5, this.label1);
			this.label1.ShowAll ();
			this.vbox1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.notebook1]));
			w6.Position = 2;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.toolbar2.Hide ();
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		}
	}
}

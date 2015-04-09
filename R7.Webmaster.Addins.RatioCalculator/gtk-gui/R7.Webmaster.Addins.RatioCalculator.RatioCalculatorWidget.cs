
// This file has been generated by the GUI designer. Do not modify.
namespace R7.Webmaster.Addins.RatioCalculator
{
	public partial class RatioCalculatorWidget
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.Button buttonDivide;
		
		private global::Gtk.ToggleButton buttonLockFactor;
		
		private global::Gtk.Button buttonMultiply;
		
		private global::Gtk.Button buttonReverseRatio;
		
		private global::Gtk.Button buttonRotate;
		
		private global::Gtk.Entry entryRatio;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label labelFactorValue;
		
		private global::Gtk.Label labelPrecisionValue;
		
		private global::Gtk.HScale scaleTolerance;
		
		private global::Gtk.SpinButton spinHeight;
		
		private global::Gtk.SpinButton spinMultiplier;
		
		private global::Gtk.SpinButton spinWidth;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget R7.Webmaster.Addins.RatioCalculator.RatioCalculatorWidget
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.UIManager.InsertActionGroup (w2, 0);
			this.Name = "R7.Webmaster.Addins.RatioCalculator.RatioCalculatorWidget";
			// Container child R7.Webmaster.Addins.RatioCalculator.RatioCalculatorWidget.Gtk.Container+ContainerChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(5)), ((uint)(9)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.buttonDivide = new global::Gtk.Button ();
			this.buttonDivide.TooltipMarkup = "Divide by";
			this.buttonDivide.CanFocus = true;
			this.buttonDivide.Name = "buttonDivide";
			this.buttonDivide.UseUnderline = true;
			this.buttonDivide.Label = global::Mono.Unix.Catalog.GetString ("/");
			this.table1.Add (this.buttonDivide);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonDivide]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(6));
			w3.RightAttach = ((uint)(7));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buttonLockFactor = new global::Gtk.ToggleButton ();
			this.buttonLockFactor.TooltipMarkup = "Lock factor";
			this.buttonLockFactor.CanFocus = true;
			this.buttonLockFactor.Name = "buttonLockFactor";
			this.buttonLockFactor.UseUnderline = true;
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "locked", global::Gtk.IconSize.Menu);
			this.buttonLockFactor.Image = w4;
			this.table1.Add (this.buttonLockFactor);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonLockFactor]));
			w5.LeftAttach = ((uint)(4));
			w5.RightAttach = ((uint)(5));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buttonMultiply = new global::Gtk.Button ();
			this.buttonMultiply.TooltipMarkup = "Multiply by";
			this.buttonMultiply.CanFocus = true;
			this.buttonMultiply.Name = "buttonMultiply";
			this.buttonMultiply.UseUnderline = true;
			this.buttonMultiply.Label = global::Mono.Unix.Catalog.GetString ("x");
			this.table1.Add (this.buttonMultiply);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonMultiply]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(5));
			w6.RightAttach = ((uint)(6));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buttonReverseRatio = new global::Gtk.Button ();
			this.buttonReverseRatio.TooltipMarkup = "Flip";
			this.buttonReverseRatio.CanFocus = true;
			this.buttonReverseRatio.Name = "buttonReverseRatio";
			this.buttonReverseRatio.UseUnderline = true;
			global::Gtk.Image w7 = new global::Gtk.Image ();
			w7.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-jump-to", global::Gtk.IconSize.Button);
			this.buttonReverseRatio.Image = w7;
			this.table1.Add (this.buttonReverseRatio);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonReverseRatio]));
			w8.LeftAttach = ((uint)(6));
			w8.RightAttach = ((uint)(7));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buttonRotate = new global::Gtk.Button ();
			this.buttonRotate.TooltipMarkup = "Rotate";
			this.buttonRotate.CanFocus = true;
			this.buttonRotate.Name = "buttonRotate";
			this.buttonRotate.UseUnderline = true;
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "rotate", global::Gtk.IconSize.Menu);
			this.buttonRotate.Image = w9;
			this.table1.Add (this.buttonRotate);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonRotate]));
			w10.LeftAttach = ((uint)(5));
			w10.RightAttach = ((uint)(6));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryRatio = new global::Gtk.Entry ();
			this.entryRatio.CanFocus = true;
			this.entryRatio.Name = "entryRatio";
			this.entryRatio.IsEditable = false;
			this.entryRatio.InvisibleChar = '●';
			this.table1.Add (this.entryRatio);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryRatio]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(4));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Width:");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Height:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w13.LeftAttach = ((uint)(2));
			w13.RightAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Ratio:");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Factor:");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Precision:");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelFactorValue = new global::Gtk.Label ();
			this.labelFactorValue.Name = "labelFactorValue";
			this.labelFactorValue.Xalign = 0F;
			this.labelFactorValue.Selectable = true;
			this.table1.Add (this.labelFactorValue);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelFactorValue]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(4));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelPrecisionValue = new global::Gtk.Label ();
			this.labelPrecisionValue.Name = "labelPrecisionValue";
			this.labelPrecisionValue.Xalign = 0F;
			this.table1.Add (this.labelPrecisionValue);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelPrecisionValue]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.LeftAttach = ((uint)(4));
			w18.RightAttach = ((uint)(6));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.scaleTolerance = new global::Gtk.HScale (null);
			this.scaleTolerance.CanFocus = true;
			this.scaleTolerance.Name = "scaleTolerance";
			this.scaleTolerance.Adjustment.Lower = 1;
			this.scaleTolerance.Adjustment.Upper = 7;
			this.scaleTolerance.Adjustment.PageIncrement = 1;
			this.scaleTolerance.Adjustment.StepIncrement = 1;
			this.scaleTolerance.Adjustment.Value = 2;
			this.scaleTolerance.DrawValue = true;
			this.scaleTolerance.Digits = 0;
			this.scaleTolerance.ValuePos = ((global::Gtk.PositionType)(1));
			this.table1.Add (this.scaleTolerance);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.scaleTolerance]));
			w19.TopAttach = ((uint)(3));
			w19.BottomAttach = ((uint)(4));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(4));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinHeight = new global::Gtk.SpinButton (1, 100000, 1);
			this.spinHeight.CanFocus = true;
			this.spinHeight.Name = "spinHeight";
			this.spinHeight.Adjustment.PageIncrement = 10;
			this.spinHeight.ClimbRate = 1;
			this.spinHeight.Numeric = true;
			this.spinHeight.Value = 768;
			this.table1.Add (this.spinHeight);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.spinHeight]));
			w20.LeftAttach = ((uint)(3));
			w20.RightAttach = ((uint)(4));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinMultiplier = new global::Gtk.SpinButton (0.01, 100, 1);
			this.spinMultiplier.CanFocus = true;
			this.spinMultiplier.Name = "spinMultiplier";
			this.spinMultiplier.Adjustment.PageIncrement = 1;
			this.spinMultiplier.ClimbRate = 1;
			this.spinMultiplier.Digits = ((uint)(2));
			this.spinMultiplier.Numeric = true;
			this.spinMultiplier.Value = 2;
			this.table1.Add (this.spinMultiplier);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.spinMultiplier]));
			w21.TopAttach = ((uint)(1));
			w21.BottomAttach = ((uint)(2));
			w21.LeftAttach = ((uint)(4));
			w21.RightAttach = ((uint)(5));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinWidth = new global::Gtk.SpinButton (1, 10000, 1);
			this.spinWidth.CanFocus = true;
			this.spinWidth.Name = "spinWidth";
			this.spinWidth.Adjustment.PageIncrement = 10;
			this.spinWidth.ClimbRate = 1;
			this.spinWidth.Numeric = true;
			this.spinWidth.Value = 1024;
			this.table1.Add (this.spinWidth);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.spinWidth]));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(0));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.alignment1.Add (this.table1);
			this.Add (this.alignment1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.Hide ();
			this.spinWidth.ValueChanged += new global::System.EventHandler (this.OnSpinWidthValueChanged);
			this.spinHeight.ValueChanged += new global::System.EventHandler (this.OnSpinHeightValueChanged);
			this.scaleTolerance.ValueChanged += new global::System.EventHandler (this.OnScaleToleranceValueChanged);
			this.scaleTolerance.FormatValue += new global::Gtk.FormatValueHandler (this.OnScaleToleranceFormatValue);
			this.buttonRotate.Clicked += new global::System.EventHandler (this.OnButtonRotateClicked);
			this.buttonReverseRatio.Clicked += new global::System.EventHandler (this.OnButtonReverseRatioClicked);
			this.buttonMultiply.Clicked += new global::System.EventHandler (this.OnButtonMultiplyClicked);
			this.buttonLockFactor.Toggled += new global::System.EventHandler (this.OnButtonLockFactorToggled);
			this.buttonDivide.Clicked += new global::System.EventHandler (this.OnButtonDivideClicked);
		}
	}
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;

namespace MyProject
{
	public struct stFontStyle
	{
		public string Name;
		public float Size;
		public FontStyle Style;
		public stFontStyle(string Name, float Size, FontStyle Style)
		{
			this.Name = Name;
			this.Size = Size;
			this.Style = Style;
		}
	}
	public struct stFlatAppearanceStyle
	{
		public int BorderSize;
		public Color BorderColor;
		public Color MouseOverBackColor;
		public Color MouseDownBackColor;

		public stFlatAppearanceStyle(int BorderSize, Color BorderColor, Color MouseOverBackColor,
									 Color MouseDownBackColor)
		{
			this.BorderSize = BorderSize;
			this.BorderColor = BorderColor;
			this.MouseOverBackColor = MouseOverBackColor;
			this.MouseDownBackColor = MouseDownBackColor;
		}
	}
	public struct stButtonStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
		public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public stFlatAppearanceStyle FlatSettings;
		public AnchorStyles Anchor;
		public stButtonStyle(string Text, Point Location, Size Size, Color BackgroundColor,
							 Color ForeColor, stFontStyle FontSettings,
							 stFlatAppearanceStyle FlatSettings, AnchorStyles Anchor)
		{
			this.Text = Text;
			this.Size = Size;
			this.Location = Location;
			this.BackgroundColor = BackgroundColor;
			this.ForeColor = ForeColor;
			this.FontSettings = FontSettings;
			this.FlatSettings = FlatSettings;
			this.Anchor = Anchor;
		}
	}
	public struct stTextBoxStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
		public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stTextBoxStyle(string Text, Point Location, Size Size, Color BackgroundColor,
							  Color ForeColor, stFontStyle FontSettings, AnchorStyles Anchor)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.BackgroundColor = BackgroundColor;
			this.ForeColor = ForeColor;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
		}
	}
	public struct stLabelStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
		public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stLabelStyle(string Text, Point Location, Size Size, Color BackgroundColor,
							Color ForeColor, stFontStyle FontSettings, AnchorStyles Anchor)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.BackgroundColor = BackgroundColor;
			this.ForeColor = ForeColor;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
		}
	}
	public struct stCheckBoxStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
		public bool IsChecked;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stCheckBoxStyle(string Text, Point Location, Size Size, bool IsChecked,
							   stFontStyle FontSettings, AnchorStyles Anchor)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.IsChecked = IsChecked;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
		}
	}
	public struct stRadioButtonStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
		public bool IsChecked;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stRadioButtonStyle(string Text, Point Location, Size Size, bool IsChecked,
								  stFontStyle FontSettings, AnchorStyles Anchor)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.IsChecked = IsChecked;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
		}
	}
	public struct stGroupBoxStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
        public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stGroupBoxStyle(string Text, Point Location, Size Size, stFontStyle FontSettings,
							   AnchorStyles Anchor,Color BackgroundColor, Color ForeColor)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
            this.BackgroundColor = BackgroundColor;
            this.ForeColor = ForeColor;
		}
	}
    public struct stMaskedTextBoxStyle
	{
        public string Mask;
        public char PromptChar;
        public MaskFormat TextMaskFormat;
		public string Text;
		public Point Location;
		public Size Size;
		public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stMaskedTextBoxStyle(string Text, Point Location, Size Size, Color BackgroundColor,
	    Color ForeColor, stFontStyle FontSettings, AnchorStyles Anchor,
        string Mask, char PromptChar, MaskFormat TextMaskFormat)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.BackgroundColor = BackgroundColor;
			this.ForeColor = ForeColor;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
            this.Mask = Mask;
            this.PromptChar = PromptChar;
            this.TextMaskFormat = TextMaskFormat;
		}
	}
    public struct stComboBoxStyle
	{
		public Point Location;
		public Size Size;
        public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
        public ComboBoxStyle DropDownStyle;
		public stComboBoxStyle(Point Location, Size Size, stFontStyle FontSettings,
 	   AnchorStyles Anchor,Color BackgroundColor, Color ForeColor,ComboBoxStyle DropDownStyle)
		{
			this.Location = Location;
			this.Size = Size;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
            this.BackgroundColor = BackgroundColor;
            this.ForeColor = ForeColor;
            this.DropDownStyle = DropDownStyle;
		}
	}
    public struct stLinkLabelStyle
    {
        public string Text;
        public Point Location;
        public Size Size;
        public Color BackgroundColor;
        public Color LinkColor;
        public Color VisitedLinkColor;
        public stFontStyle FontSettings;
        public AnchorStyles Anchor;

        public stLinkLabelStyle(string Text, Point Location, Size Size, Color BackgroundColor, Color LinkColor, Color VisitedLinkColor, stFontStyle FontSettings, AnchorStyles Anchor)
        {
            this.Text = Text;
            this.Location = Location;
            this.Size = Size;
            this.BackgroundColor = BackgroundColor;
            this.LinkColor = LinkColor;
            this.VisitedLinkColor = VisitedLinkColor;
            this.FontSettings = FontSettings;
            this.Anchor = Anchor;
        }
    }
    public struct stDateTimePicker
    {
        public Point Location;
        public Size Size;
        public Color BackgroundColor;
        public Color ForeColor;
        public stFontStyle FontSettings;
        public AnchorStyles Anchor;
        
        public DateTimePickerFormat Format;
        public string CustomFormat;
        public bool ShowUpDown;
        public bool ShowCheckBox;
        public DateTime Value;
        public DateTime MinDate;
        public DateTime MaxDate;
        
        public stDateTimePicker(Point Location, Size Size, Color BackgroundColor, Color ForeColor,
        DateTimePickerFormat Format,string CustomFormat,bool ShowUpDown,bool ShowCheckBox,DateTime Value,
        DateTime MinDate,DateTime MaxDate, stFontStyle FontSettings, AnchorStyles Anchor)
        {
            this.Location = Location;
            this.Size = Size;
            this.BackgroundColor = BackgroundColor;
            this.ForeColor = ForeColor;
            this.FontSettings = FontSettings;
            this.Anchor = Anchor;
            this.Format = Format;
            this.CustomFormat = CustomFormat;
            this.ShowUpDown = ShowUpDown;
            this.ShowCheckBox = ShowCheckBox;
            this.Value = Value;
            this.MinDate = MinDate;
            this.MaxDate = MaxDate;
        }
    }
    public struct stProgressBarStyle
    {
        public Point Location;
        public Size Size;
        public int Minimum;
        public int Maximum;
        public int Value;
        public int Step;
        public AnchorStyles Anchor;
        
        public stProgressBarStyle(Point Location, Size Size
        ,AnchorStyles Anchor,int Minimum,int Maximum,int Value,int Step)
        {
            this.Location = Location;
            this.Size = Size;
            this.Anchor = Anchor;
            this.Minimum = Minimum;
            this.Maximum = Maximum;
            this.Value = Value;
            this.Step = Step;
        }
    }
    public struct stCheckedListBoxStyle
    {
       public Point Location;
       public Size Size;
       public Color BackgroundColor;
       public Color ForeColor;
       public stFontStyle FontSettings;
       public AnchorStyles Anchor;
       public bool CheckOnClick;
       public bool Sorted;
       public BorderStyle borderstyle;
      public stCheckedListBoxStyle(Point Location, Size Size, Color BackgroundColor, Color ForeColor, stFontStyle FontSettings, AnchorStyles Anchor,BorderStyle borderstyle,bool CheckOnClick,bool Sorted)
      {
        this.Location = Location;
        this.Size = Size;
        this.BackgroundColor = BackgroundColor;
        this.ForeColor = ForeColor;
        this.FontSettings = FontSettings;
        this.Anchor = Anchor;
        this.CheckOnClick = CheckOnClick;
        this.Sorted = Sorted;
        this.borderstyle = borderstyle;
      }
    }
    public struct stMonthCalendar
    {
        public Point Location;
        public Size Size;
        public Color TitleBackColor;
        public Color TitleForeColor;
        public stFontStyle FontSettings;
        public AnchorStyles Anchor;
        public DateTime MinDate;
        public DateTime MaxDate;
        
        public int MaxSelectionCount;
        public DateTime TodayDate;
        public bool ShowToday;
        public bool ShowTodayCircle;
        public bool ShowWeekNumbers;
        
        public stMonthCalendar(Point Location, Size Size, Color TitleBackColor, Color TitleForeColor, stFontStyle FontSettings,
        int MaxSelectionCount,DateTime MinDate,DateTime MaxDate,
        DateTime TodayDate,bool ShowToday=true,bool ShowTodayCircle=true,bool ShowWeekNumbers=false,AnchorStyles Anchor=AnchorStyles.None)
        {
            this.Location = Location;
            this.Size = Size;
            this.TitleBackColor = TitleBackColor;
            this.TitleForeColor = TitleForeColor;
            this.FontSettings = FontSettings;
            this.Anchor = Anchor;
            this.MaxSelectionCount = MaxSelectionCount;
            this.MinDate = MinDate;
            this.MaxDate = MaxDate;
            this.TodayDate = TodayDate;
            this.ShowToday = ShowToday;
            this.ShowTodayCircle = ShowTodayCircle;
            this.ShowWeekNumbers = ShowWeekNumbers;
        }
    }
    public struct stTimer
    {
        public int Interval;
        public bool Enabled;
        public stTimer(int Interval,bool Enabled=false)
        {
            this.Interval = Interval;
            this.Enabled = Enabled;
        }
    }
    public struct stPictureBox
    {
        public string ImagePath;             
        public Point Location;
        public Size Size;
        public Color BackColor; 
        public AnchorStyles Anchor;
        public PictureBoxSizeMode SizeMode;
        public bool Visible;
        public stPictureBox(Point Location, Size Size,PictureBoxSizeMode SizeMode,string ImagePath,bool Visible=true,Color? BackColor=null ,AnchorStyles Anchor=AnchorStyles.None)
        {
            this.ImagePath = ImagePath;
            this.Location = Location;
            this.Size = Size;
            this.Visible = Visible;
            this.SizeMode = SizeMode;
            this.BackColor = BackColor ?? Color.Transparent; 
            this.Anchor = Anchor;
        }
    }
    public struct stNotifyIcon
    {
        public Icon AppIcon;
        public string ToolTipText;
        public string BalloonTitle;
        public string BalloonText;
        public ToolTipIcon BalloonIcon;
        public stNotifyIcon(Icon AppIcon,string ToolTipText,
        string BalloonTitle,string BalloonText,ToolTipIcon BalloonIcon)
        {
            this.AppIcon = AppIcon;
            this.ToolTipText = ToolTipText;
            this.BalloonTitle = BalloonTitle;
            this.BalloonText = BalloonText;
            this.BalloonIcon = BalloonIcon;
        }
    }
    public struct stListViewStyle
    {
       public Point Location;
       public Size Size;
       public Color BackgroundColor;
       public Color ForeColor;
       public stFontStyle FontSettings;
       public AnchorStyles Anchor;
       public View ViewMode;
       public bool FullRowSelect;
       public bool GridLines; 

       public stListViewStyle(Point Location, Size Size, Color BackgroundColor, Color ForeColor, 
       stFontStyle FontSettings, AnchorStyles Anchor, View ViewMode, bool FullRowSelect = true, bool GridLines = true)
       {
           this.Location = Location;
           this.Size = Size;
           this.BackgroundColor = BackgroundColor;
           this.ForeColor = ForeColor;
           this.FontSettings = FontSettings;
           this.Anchor = Anchor;
           this.ViewMode = ViewMode;
           this.FullRowSelect = FullRowSelect;
           this.GridLines = GridLines;
       }
    }
    public struct stTrackBarStyle
    {
       public Point Location;
       public Size Size;
       public Color BackgroundColor;
       public int Minimum;
       public int Maximum;
       public int Value;
       public int TickFrequency;
       public AnchorStyles Anchor;

       public stTrackBarStyle(Point Location, Size Size, Color BackgroundColor, AnchorStyles Anchor,
       int Minimum, int Maximum, int Value, int TickFrequency)
       {
          this.Location = Location;
          this.Size = Size;
          this.BackgroundColor = BackgroundColor;
          this.Anchor = Anchor;
          this.Minimum = Minimum;
          this.Maximum = Maximum;
          this.Value = Value;
          this.TickFrequency = TickFrequency;
       }
    }
    public struct stErrorProviderStyle
    {
       public ErrorBlinkStyle BlinkStyle;

       public stErrorProviderStyle(ErrorBlinkStyle BlinkStyle)
       {
           this.BlinkStyle = BlinkStyle;
       }
    }
    public struct stNumericUpDownStyle
    {
       public Point Location;
       public Size Size;
       public Color BackgroundColor;
       public Color ForeColor;
       public stFontStyle FontSettings;
       public int Minimum;
       public int Maximum;
       public int Value;
       public int Increment;
       public AnchorStyles Anchor;

       public stNumericUpDownStyle(Point Location, Size Size, Color BackgroundColor, 
       Color ForeColor,stFontStyle FontSettings,int Minimum,int Maximum,
       int Value,int Increment, AnchorStyles Anchor)
       {
           this.Location = Location;
           this.Size = Size;
           this.BackgroundColor = BackgroundColor;
           this.ForeColor = ForeColor;
           this.FontSettings = FontSettings;
           this.Minimum = Minimum;
           this.Maximum = Maximum;
           this.Value = Value;
           this.Increment = Increment;
           this.Anchor = Anchor;
       }
    }
    public struct stTabControlStyle
    {
        public Point Location;
        public Size Size;
        public Color BackgroundColor;
        public stFontStyle FontSettings;
        public AnchorStyles Anchor;
        public TabAlignment TabPosition;
        public stTabControlStyle(Point Location, Size Size, Color BackgroundColor, 
        stFontStyle FontSettings,TabAlignment TabPosition,AnchorStyles Anchor)
        {
            this.Location = Location;
            this.Size = Size;
            this.BackgroundColor = BackgroundColor;
            this.FontSettings = FontSettings;
            this.Anchor = Anchor;
            this.TabPosition = TabPosition;
        }
    }
    public struct stPanelStyle
    {
        public Point Location;
        public Size Size;
        public Color BackgroundColor;
        public BorderStyle PanelBorder;
        public AnchorStyles Anchor;
        public DockStyle Dock;

        public stPanelStyle(Point Location, Size Size, Color BackgroundColor, 
        BorderStyle PanelBorder, AnchorStyles Anchor, DockStyle Dock = DockStyle.None)
        {
            this.Location = Location;
            this.Size = Size;
            this.BackgroundColor = BackgroundColor;
            this.PanelBorder = PanelBorder;
            this.Anchor = Anchor;
            this.Dock = Dock;
        }
    }
    public struct stFolderBrowserDialogStyle
    {
        public string Description;
        public bool ShowNewFolderButton;

        public stFolderBrowserDialogStyle(string Description, bool ShowNewFolderButton = true)
        {
            this.Description = Description;
            this.ShowNewFolderButton = ShowNewFolderButton;
        }
    }
    public struct stOpenFileDialogStyle
    {
        public string Filter;
        public string Title;
        public string InitialDirectory;
        public bool Multiselect;

        public stOpenFileDialogStyle(string Filter, string Title, string InitialDirectory, bool Multiselect = false)
        {
            this.Filter = Filter;
            this.Title = Title;
            this.InitialDirectory = InitialDirectory;
            this.Multiselect = Multiselect;
        }
    }
    public struct stSaveFileDialogStyle
    {
        public string Filter;
        public string DefaultExt;
        public string Title;
        public string InitialDirectory;

        public stSaveFileDialogStyle(string Filter, string DefaultExt, string Title, string InitialDirectory)
        {
            this.Filter = Filter;
            this.DefaultExt = DefaultExt;
            this.Title = Title;
            this.InitialDirectory = InitialDirectory;
        }
    }
    public struct stFontDialogStyle
    {
        public bool ShowColor;
        public bool ShowEffects;
        public int MinSize;
        public int MaxSize;

        public stFontDialogStyle(bool ShowColor, bool ShowEffects, int MinSize, int MaxSize)
        {
           this.ShowColor = ShowColor;
           this.ShowEffects = ShowEffects;
           this.MinSize = MinSize;
           this.MaxSize = MaxSize;
        }
    }
    public struct stColorDialogStyle
    {
        public bool FullOpen;
        public bool AnyColor;
        public Color DefaultColor;

        public stColorDialogStyle(bool FullOpen, bool AnyColor, Color DefaultColor)
        {
            this.FullOpen = FullOpen;
            this.AnyColor = AnyColor;
            this.DefaultColor = DefaultColor;
        }
    }
    public struct stContextMenuStripStyle
    {
        public Color BackgroundColor;
        public Color ForeColor;
        public stFontStyle FontSettings;
        public stContextMenuStripStyle(Color BackgroundColor, Color ForeColor, stFontStyle FontSettings)
        {
            this.BackgroundColor = BackgroundColor;
            this.ForeColor = ForeColor;
            this.FontSettings = FontSettings;
        }
    }
    public struct stMenuStripStyle
    {
        public Color BackgroundColor;
        public Color ForeColor;
        public stFontStyle FontSettings;
        public DockStyle Dock;  

        public stMenuStripStyle(Color BackgroundColor, Color ForeColor, stFontStyle FontSettings, DockStyle Dock = DockStyle.Top)
        {
            this.BackgroundColor = BackgroundColor;
            this.ForeColor = ForeColor;
            this.FontSettings = FontSettings;
            this.Dock = Dock;
        }
	}
	public static class clsControlFactory
	{
		public static Button CreateButton(stButtonStyle style)
		{
			Button btn = new Button();
			btn.Text = style.Text;
			btn.Location = style.Location;
			btn.Size = style.Size;
			btn.BackColor = style.BackgroundColor;
			btn.ForeColor = style.ForeColor;
			btn.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			btn.FlatStyle = FlatStyle.Flat;
			btn.FlatAppearance.BorderSize = style.FlatSettings.BorderSize;
			btn.FlatAppearance.BorderColor = style.FlatSettings.BorderColor;
			btn.FlatAppearance.MouseOverBackColor = style.FlatSettings.MouseOverBackColor;
			btn.FlatAppearance.MouseDownBackColor = style.FlatSettings.MouseDownBackColor;
			btn.Anchor = style.Anchor;
			return btn;
		}

		public static TextBox CreateTextBox(stTextBoxStyle style)
		{
			TextBox txt = new TextBox();
			txt.Text = style.Text;
			txt.Location = style.Location;
			txt.Size = style.Size;
			txt.BackColor = style.BackgroundColor;
			txt.ForeColor = style.ForeColor;
			txt.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			txt.Anchor = style.Anchor;
			return txt;
		}

		public static Label CreateLabel(stLabelStyle style)
		{
			Label label = new Label();
			label.Text = style.Text;
			label.Location = style.Location;
			label.Size = style.Size;
			label.BackColor = style.BackgroundColor;
			label.ForeColor = style.ForeColor;
			label.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.Anchor = style.Anchor;
			return label;
		}

		public static CheckBox CreateCheckBox(stCheckBoxStyle style)
		{
			CheckBox chk = new CheckBox();
			chk.Text = style.Text;
			chk.Location = style.Location;
			chk.Size = style.Size;
			chk.Checked = style.IsChecked;
			chk.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			chk.Anchor = style.Anchor;
			return chk;
		}

		public static RadioButton CreateRadioButton(stRadioButtonStyle style)
		{
			RadioButton Rb = new RadioButton();
			Rb.Text = style.Text;
			Rb.Location = style.Location;
			Rb.Size = style.Size;
			Rb.Checked = style.IsChecked;
			Rb.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			Rb.Anchor = style.Anchor;
			return Rb;
		}
		public static GroupBox CreateGroupBox(stGroupBoxStyle style)
		{
			GroupBox grp = new GroupBox();
			grp.Text = style.Text;
			grp.Location = style.Location;
			grp.Size = style.Size;
			grp.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			grp.Anchor = style.Anchor;
            grp.BackColor = style.BackgroundColor;
            grp.ForeColor = style.ForeColor;

			return grp;
		}
        public static MaskedTextBox CreateMaskedTextBox(stMaskedTextBoxStyle style)
		{
			MaskedTextBox mstxt = new MaskedTextBox();
			mstxt.Text = style.Text;
			mstxt.Location = style.Location;
			mstxt.Size = style.Size;
			mstxt.BackColor = style.BackgroundColor;
			mstxt.ForeColor = style.ForeColor;
			mstxt.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			mstxt.Anchor = style.Anchor;
            mstxt.Mask = style.Mask;                
            mstxt.PromptChar = style.PromptChar;     
            mstxt.TextMaskFormat = style.TextMaskFormat;
			return mstxt;
		}
        public static ComboBox CreateComboBox(stComboBoxStyle style)
		{
			ComboBox Cb = new ComboBox();
			Cb.Location = style.Location;
			Cb.Size = style.Size;
			Cb.BackColor = style.BackgroundColor;
			Cb.ForeColor = style.ForeColor;
			Cb.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			Cb.Anchor = style.Anchor;
            Cb.DropDownStyle = style.DropDownStyle;
			return Cb;
		}
        public static LinkLabel CreateLinkLabel(stLinkLabelStyle style)
        {
          LinkLabel lnk = new LinkLabel();
          lnk.Text = style.Text;
          lnk.Location = style.Location;
          lnk.Size = style.Size;
          lnk.BackColor = style.BackgroundColor;
          lnk.LinkColor = style.LinkColor;
          lnk.VisitedLinkColor = style.VisitedLinkColor;
          lnk.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
          lnk.Anchor = style.Anchor;
    
          return lnk;
        }
        public static CheckedListBox CreateCheckedListBox(stCheckedListBoxStyle style)
        {
          CheckedListBox CLB = new CheckedListBox();
          CLB.Location = style.Location;
          CLB.Size = style.Size;
          CLB.BackColor = style.BackgroundColor;
          CLB.ForeColor = style.ForeColor;
          CLB.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
          CLB.Anchor = style.Anchor;
          CLB.CheckOnClick = style.CheckOnClick;
          CLB.Sorted = style.Sorted;
          CLB.BorderStyle = style.borderstyle;
          return CLB;
        }
        public static DateTimePicker CreateDateTimePicker(stDateTimePicker style)
        {
          DateTimePicker DTP = new DateTimePicker();
          DTP.Location = style.Location;
          DTP.Size = style.Size;
          DTP.BackColor = style.BackgroundColor;
          DTP.ForeColor = style.ForeColor;
          DTP.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
          DTP.Anchor = style.Anchor;
          DTP.ShowUpDown = style.ShowUpDown;
          DTP.ShowCheckBox = style.ShowCheckBox;
          DTP.MinDate = style.MinDate;
          DTP.MaxDate = style.MaxDate;
          DTP.Value = style.Value;
          DTP.Format = style.Format;
          if(!string.IsNullOrEmpty(style.CustomFormat))
          DTP.CustomFormat = style.CustomFormat;
          
          return DTP;
        }
        public static MonthCalendar CreateMonthCalendar(stMonthCalendar style)
        {
          MonthCalendar MC = new MonthCalendar();
          MC.Location = style.Location;
          MC.Size = style.Size;
          MC.TitleForeColor = style.TitleForeColor;
          MC.TitleBackColor = style.TitleBackColor;
          MC.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
          MC.Anchor = style.Anchor;
          MC.MaxSelectionCount = style.MaxSelectionCount;
          MC.MinDate = style.MinDate;
          MC.MaxDate = style.MaxDate;
          MC.TodayDate = style.TodayDate;
          MC.ShowToday = style.ShowToday;
          MC.ShowTodayCircle = style.ShowTodayCircle;
          MC.ShowWeekNumbers = style.ShowWeekNumbers;
          
          return MC;
        }
        public static PictureBox CreatePictureBox(stPictureBox style)
        {
            PictureBox _Pbx = new PictureBox();
            _Pbx.Location = style.Location;
            _Pbx.Size = style.Size;
            _Pbx.SizeMode = style.SizeMode;
            _Pbx.BackColor = style.BackColor; 
            _Pbx.Anchor = style.Anchor;
            _Pbx.Visible = style.Visible;
            if (!string.IsNullOrEmpty(style.ImagePath) && System.IO.File.Exists(style.ImagePath))
            {    
                using (var stream = System.IO.File.OpenRead(style.ImagePath))
                {
                    using (var tempImg = Image.FromStream(stream))
                    {
                        _Pbx.Image = new Bitmap(tempImg);
                    }
                }
            }
            return _Pbx;
        }
        public static System.Windows.Forms.Timer CreateTimer(stTimer style)
        {
            System.Windows.Forms.Timer T = new System.Windows.Forms.Timer();
            T.Interval = style.Interval;
            T.Enabled = style.Enabled;
            return T;
        }
        public static NotifyIcon CreateNotifyIcon(stNotifyIcon style)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = style.AppIcon;
            notifyIcon.Text = style.ToolTipText;
            notifyIcon.BalloonTipTitle = style.BalloonTitle;
            notifyIcon.BalloonTipText = style.BalloonText;
            notifyIcon.BalloonTipIcon = style.BalloonIcon;
            
            notifyIcon.Visible = true;
            
            return notifyIcon;
        }
        public static ProgressBar CreateProgressBar(stProgressBarStyle style)
        {
            ProgressBar PB = new ProgressBar();
            PB.Location = style.Location;
            PB.Size = style.Size;
            PB.Anchor = style.Anchor;
            PB.Minimum = style.Minimum;
            PB.Maximum = style.Maximum;
            PB.Value = style.Value;
            PB.Step = style.Step;
            PB.Style = ProgressBarStyle.Blocks; 
            return PB;
        }
        public static ListView CreateListView(stListViewStyle style)
        {
            ListView lv = new ListView();
            lv.Location = style.Location;
            lv.Size = style.Size;
            lv.BackColor = style.BackgroundColor;
            lv.ForeColor = style.ForeColor;
            lv.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
            lv.Anchor = style.Anchor;
            lv.View = style.ViewMode;
            lv.FullRowSelect = style.FullRowSelect;
            lv.GridLines = style.GridLines;
            lv.MultiSelect = true;

            return lv;
        }
        public static TrackBar CreateTrackBar(stTrackBarStyle style)
        {
             TrackBar tb = new TrackBar();
             tb.Location = style.Location;
             tb.Size = style.Size;
             tb.BackColor = style.BackgroundColor;
             tb.Anchor = style.Anchor;
             tb.Minimum = style.Minimum;
             tb.Maximum = style.Maximum;
             tb.Value = style.Value;
             tb.TickFrequency = style.TickFrequency;
             tb.TickStyle = TickStyle.BottomRight; 
    
             return tb;
        }
        public static ErrorProvider CreateErrorProvider(stErrorProviderStyle style)
        {
           ErrorProvider ep = new ErrorProvider();
           ep.BlinkStyle = style.BlinkStyle;
           return ep;
        }
        public static NumericUpDown CreateNumericUpDown(stNumericUpDownStyle style)
        {
            NumericUpDown nud = new NumericUpDown();
            nud.Location = style.Location;
            nud.Size = style.Size;
            nud.BackColor = style.BackgroundColor;
            nud.ForeColor = style.ForeColor;
            nud.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
            nud.Anchor = style.Anchor;
            nud.Minimum = style.Minimum;
            nud.Maximum = style.Maximum;
            nud.Value = style.Value;
            nud.Increment = style.Increment;
    
            return nud;
        }
        public static TabControl CreateTabControl(stTabControlStyle style)
        {
            TabControl tc = new TabControl();
            tc.Location = style.Location;
            tc.Size = style.Size;
            tc.BackColor = style.BackgroundColor;
            tc.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
            tc.Anchor = style.Anchor;
            tc.Alignment = style.TabPosition;
            return tc;
        }
        public static Panel CreatePanel(stPanelStyle style)
        {
            Panel pnl = new Panel();
            pnl.Location = style.Location;
            pnl.Size = style.Size;
            pnl.BackColor = style.BackgroundColor;
            pnl.BorderStyle = style.PanelBorder;
            pnl.Anchor = style.Anchor;
            pnl.Dock = style.Dock;
            pnl.AutoScroll = true; 
    
            return pnl;
        }
        public static FolderBrowserDialog CreateFolderBrowserDialog(stFolderBrowserDialogStyle style)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = style.Description;
            fbd.ShowNewFolderButton = style.ShowNewFolderButton;
            return fbd;
        }
        public static OpenFileDialog CreateOpenFileDialog(stOpenFileDialogStyle style)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = style.Filter;
            ofd.Title = style.Title;
            ofd.InitialDirectory = style.InitialDirectory;
            ofd.Multiselect = style.Multiselect;
            ofd.CheckFileExists = true; 
            ofd.CheckPathExists = true;
    
            return ofd;
        }
        public static SaveFileDialog CreateSaveFileDialog(stSaveFileDialogStyle style)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = style.Filter;
            sfd.DefaultExt = style.DefaultExt;
            sfd.Title = style.Title;
            sfd.InitialDirectory = style.InitialDirectory;
            sfd.OverwritePrompt = true; 
    
            return sfd;
        }
        public static FontDialog CreateFontDialog(stFontDialogStyle style)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = style.ShowColor;
            fd.ShowEffects = style.ShowEffects;
            fd.MinSize = style.MinSize;
            fd.MaxSize = style.MaxSize;
            if (style.MinSize > 0 || style.MaxSize > 0)
            {
                fd.AllowVectorFonts = true;
                fd.AllowVerticalFonts = false;
            }
            return fd;
        }
        public static ColorDialog CreateColorDialog(stColorDialogStyle style)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = style.FullOpen;
            cd.AnyColor = style.AnyColor;
            cd.Color = style.DefaultColor;
            return cd;
        }
        public static ContextMenuStrip CreateContextMenuStrip(stContextMenuStripStyle style)
        {
        	ContextMenuStrip cms = new ContextMenuStrip();
        	cms.BackColor = style.BackgroundColor;
        	cms.ForeColor = style.ForeColor;
        	cms.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
        	return cms;
        }
        public static MenuStrip CreateMenuStrip(stMenuStripStyle style)
        {
            MenuStrip ms = new MenuStrip();
            ms.BackColor = style.BackgroundColor;
            ms.ForeColor = style.ForeColor;
            ms.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
            ms.Dock = style.Dock;
            return ms;
        }

	}
    public class clsItemInfo
    {
        public string MaterialName { get; set; }
        public string ImagePath { get; set; }
        public string Composition { get; set; }
        public string Porosity { get; set; }
        public string MeanPoreSize { get; set; }
        public string CompressiveStrength { get; set; }
        public string ElasticModulus { get; set; }
        public string BioCompatibility { get; set; }
        public string Applications { get; set; }
        
        public clsItemInfo() { } // Constructor فارغ ضروري لعمل الـ Deserialization

        public clsItemInfo(string MaterialName, string ImagePath, string Composition,
        string Porosity, string MeanPoreSize, string CompressiveStrength,
        string ElasticModulus, string BioCompatibility, string Applications)
        {
            this.MaterialName = MaterialName;
            this.ImagePath = ImagePath;
            this.Composition = Composition;
            this.Porosity = Porosity;
            this.MeanPoreSize = MeanPoreSize;
            this.CompressiveStrength = CompressiveStrength;
            this.ElasticModulus = ElasticModulus;
            this.BioCompatibility = BioCompatibility;
            this.Applications = Applications;
        }

        public void SetInfoAsGroup(TextBox textBoxTarget)
        {
            if(textBoxTarget.Text != "")
                textBoxTarget.Text = "";
            
            textBoxTarget.Text += "Properties : " + Environment.NewLine;
            textBoxTarget.Text += "Composition : " + this.Composition + Environment.NewLine;
            textBoxTarget.Text += "Porosity : " + this.Porosity + Environment.NewLine;
            textBoxTarget.Text += "Mean Pore Size : " + this.MeanPoreSize + Environment.NewLine;
            textBoxTarget.Text += "Compressive Strength : " + this.CompressiveStrength + Environment.NewLine;
            textBoxTarget.Text += "Elastic Modulus : " + this.ElasticModulus + Environment.NewLine; 
            textBoxTarget.Text += "Applications : " + this.Applications + Environment.NewLine;
            textBoxTarget.Text += "BioCompatibility : " + this.BioCompatibility;
        }

        public string GetInfoAsText()
        {
            return $"Composition: {this.Composition}, Porosity: {this.Porosity}, MeanPoreSize: {this.MeanPoreSize}, CompressiveStrength: {this.CompressiveStrength}, ElasticModulus: {this.ElasticModulus}, Applications: {this.Applications}, BioCompatibility: {this.BioCompatibility}";
        }
    }

	public class MyFirstForm : Form
	{
        private Label lblSelectedMaterialTitle;
        private TabControl tabMainNavigation;
        private MenuStrip menuMainStrip;
        private TabPage tabExplorer;
        private TabPage tabCompatibilityCheck;
        private TabPage tabResearchSearch;
        private TabPage tabSimulationLab;
        private ListView lstMaterials;
        private Button btnAddMaterial;
        private Button btnRemoveMaterial;
        private Button btnCompareMaterials;
        private int itemCounter = 0;
        private ImageList imageListMaterials;
        private PictureBox picMaterialImage;
        private TextBox txtMaterialDetails;
        
        private Label lblBiomaterialDataPrompt;
        private Button btnGeminiAiCheck;
        private Button btnEnterMaterialData;
        private TextBox txtAiResultReport;
        
        private TextBox txtSearchQuery;
        private Button btnExecuteSearch;
        private WebBrowser webBrowserNih;
        private Panel pnlSearchHeader;
        
        private GroupBox grpMaterialDetails;
        private GroupBox grpTestParameters;
        
        private ComboBox cmbMaterialModel;
        private ComboBox cmbTestProtocol;
        
        private NumericUpDown numSampleDiameter;
        private NumericUpDown numLoadSpeed;
        
        private Label lblSampleDiameter;
        private Label lblLoadSpeed;
        private Label lblLoadType;
        
        private RadioButton rbQuasiStatic;
        private RadioButton rbFatigue;
        private RadioButton rbImpact;
        private CheckedListBox chkListOutputFocus;
        
        private Button btnMaterialDataInfo;
        private Button btnRunSimulation;
        private string selectedLoadType = "Impact";
        
    	public MyFirstForm()
		{
            this.Text = "Biomaterials Analysis Platform";
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(244, 246, 249); // لون خلفية هادئ ومريح للعين (Off-White/Light Gray)
            
            clsGlobal.SelectedMaterials = new string[2];
            clsGlobal.SelectedImagesPaths = new string[2];
            clsGlobal.SelectedItems = new clsItemInfo[2];

            stFontStyle Font1 = new stFontStyle("Segoe UI", 10, FontStyle.Bold);
            
            stMenuStripStyle MenuStyle = new stMenuStripStyle(Color.FromArgb(30, 41, 59), Color.FromArgb(241, 245, 249), Font1, DockStyle.Top);
            menuMainStrip = clsControlFactory.CreateMenuStrip(MenuStyle);

            ToolStripMenuItem fileMenu = new ToolStripMenuItem("&File");
            ToolStripMenuItem editMenu = new ToolStripMenuItem("&Edit");
            ToolStripMenuItem viewMenu = new ToolStripMenuItem("&View");
            ToolStripMenuItem helpMenu = new ToolStripMenuItem("&Help");
                        
            ToolStripMenuItem newItem = new ToolStripMenuItem("&New");
            ToolStripMenuItem saveItem = new ToolStripMenuItem("&Save");
            ToolStripMenuItem exitItem = new ToolStripMenuItem("E&xit");
            ToolStripMenuItem copyItem = new ToolStripMenuItem("&Copy");
            ToolStripMenuItem pasteItem = new ToolStripMenuItem("&Paste");
            ToolStripMenuItem selectAllItem = new ToolStripMenuItem("Select &All");
            ToolStripMenuItem cutItem = new ToolStripMenuItem("C&ut");
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("&Delete");
            deleteItem.ShortcutKeys = Keys.Control | Keys.D; 
            deleteItem.ShowShortcutKeys = true;
            
            fileMenu.DropDownItems.Add(newItem);
            fileMenu.DropDownItems.Add(saveItem);
            fileMenu.DropDownItems.Add(new ToolStripSeparator()); 
            fileMenu.DropDownItems.Add(exitItem);
            
            menuMainStrip.Items.Add(fileMenu);
            editMenu.DropDownItems.Add(selectAllItem);
            editMenu.DropDownItems.Add(copyItem);
            editMenu.DropDownItems.Add(pasteItem);
            editMenu.DropDownItems.Add(cutItem);
            editMenu.DropDownItems.Add(new ToolStripSeparator());
            editMenu.DropDownItems.Add(deleteItem);
            
            deleteItem.Click += new EventHandler(btnRemoveMaterial_Click);
            newItem.Click += new EventHandler(btnAddMaterial_Click);
            saveItem.Click += new EventHandler(btnSaveMaterial_Click);
            
            
            menuMainStrip.Items.Add(editMenu);
            menuMainStrip.Items.Add(viewMenu);
            menuMainStrip.Items.Add(helpMenu);
            
            this.MainMenuStrip = menuMainStrip;
            this.Controls.Add(menuMainStrip);
            
            stFontStyle Font2 = new stFontStyle("Segoe UI", 11, FontStyle.Bold);
            
            stTabControlStyle TabStyle = new stTabControlStyle(new Point(420, 40), 
            new Size(830, 620), Color.FromArgb(255, 255, 255), 
            Font2, TabAlignment.Top, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            tabMainNavigation = clsControlFactory.CreateTabControl(TabStyle);
            
            tabExplorer = new TabPage("Biomaterials Explorer");
            tabExplorer.BackColor = Color.FromArgb(248, 250, 252);
            tabMainNavigation.Controls.Add(tabExplorer);
            
            tabCompatibilityCheck = new TabPage("BioCompatibility Check");
            tabCompatibilityCheck.BackColor = Color.FromArgb(248, 250, 252);
            tabMainNavigation.Controls.Add(tabCompatibilityCheck);
            
            tabResearchSearch = new TabPage("Search");
            tabResearchSearch.BackColor = Color.FromArgb(248, 250, 252);
            tabMainNavigation.Controls.Add(tabResearchSearch);
            
            tabSimulationLab = new TabPage("Simulation Lab");
            tabSimulationLab.BackColor = Color.FromArgb(248, 250, 252);
            tabMainNavigation.Controls.Add(tabSimulationLab);
            
            this.Controls.Add(tabMainNavigation);
            
            imageListMaterials = new ImageList();
            imageListMaterials.ImageSize = new Size(48,48);
            
            stFontStyle fontList = new stFontStyle("Segoe UI", 11, FontStyle.Bold);
            
            stListViewStyle LVstyle = new stListViewStyle(new Point(10, 50), new Size(400, 540), Color.White, Color.FromArgb(30, 41, 59), 
            fontList, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left, View.Details, true, false);
            lstMaterials = clsControlFactory.CreateListView(LVstyle);
            lstMaterials.Columns.Add("MaterialsColumn", 350); 
            lstMaterials.SmallImageList = imageListMaterials; 
            lstMaterials.HeaderStyle = ColumnHeaderStyle.None; 
            lstMaterials.Scrollable = true;
            this.Controls.Add(lstMaterials);
            lstMaterials.SelectedIndexChanged += new EventHandler(lstMaterials_SelectedIndexChanged);
            
            // ألوان أزرار مريحة (أزرق هادئ مع تأثيرات خفيفة)
            stFlatAppearanceStyle StyleApper = new stFlatAppearanceStyle(1, Color.FromArgb(203, 213, 225), Color.FromArgb(14, 165, 233), Color.FromArgb(2, 132, 199));
            
            stButtonStyle BtStyle = new stButtonStyle("Add", new Point(10, 605), new Size(120, 50), Color.FromArgb(14, 165, 233), Color.White, fontList, StyleApper, AnchorStyles.Bottom | AnchorStyles.Left);
            
            btnAddMaterial = clsControlFactory.CreateButton(BtStyle);
            this.Controls.Add(btnAddMaterial);
            btnAddMaterial.Click += new EventHandler(btnAddMaterial_Click);
            
            btnRemoveMaterial = clsControlFactory.CreateButton(BtStyle);
            btnRemoveMaterial.Text = "Remove";
            btnRemoveMaterial.Location = new Point(145, 605);
            btnRemoveMaterial.BackColor = Color.FromArgb(244, 63, 94); // لون تنبيهي ناعم للحذف
            btnRemoveMaterial.Enabled = false;
            this.Controls.Add(btnRemoveMaterial);
            btnRemoveMaterial.Click += new EventHandler(btnRemoveMaterial_Click);
            
            btnCompareMaterials = clsControlFactory.CreateButton(BtStyle);
            btnCompareMaterials.Text = "Compare";
            btnCompareMaterials.Location = new Point(280, 605);
            btnCompareMaterials.BackColor = Color.FromArgb(71, 85, 105);
            btnCompareMaterials.Enabled = false;
            this.Controls.Add(btnCompareMaterials);
            btnCompareMaterials.Click += new EventHandler(btnCompareMaterials_Click);
            
            stPictureBox PBstyle = new stPictureBox(new Point(600, 20), new Size(400, 400), PictureBoxSizeMode.Zoom, @"D:\Biomaterials\Icon.png", true, null, AnchorStyles.Top | AnchorStyles.Left);
            picMaterialImage = clsControlFactory.CreatePictureBox(PBstyle);
            tabExplorer.Controls.Add(picMaterialImage);
            
            stLabelStyle stylelabel = new stLabelStyle("", new Point(450, 310), new Size(300, 40), Color.Transparent, Color.FromArgb(30, 41, 59), Font1, AnchorStyles.Top | AnchorStyles.Left);
            lblSelectedMaterialTitle = clsControlFactory.CreateLabel(stylelabel);
            tabExplorer.Controls.Add(lblSelectedMaterialTitle);
            
            stFontStyle fonttxt = new stFontStyle("Segoe UI", 11f, FontStyle.Regular);
            
            stTextBoxStyle TxtStyle = new stTextBoxStyle("", new Point(20, 20), new Size(350, 230), Color.FromArgb(255, 255, 255), Color.FromArgb(30, 41, 59), fonttxt, AnchorStyles.Top | AnchorStyles.Left);
            txtMaterialDetails = clsControlFactory.CreateTextBox(TxtStyle);
            txtMaterialDetails.Visible = false;
            txtMaterialDetails.ReadOnly = true;
            txtMaterialDetails.Multiline = true; 
            txtMaterialDetails.ScrollBars = ScrollBars.Vertical;
            tabExplorer.Controls.Add(txtMaterialDetails);
            
            stFontStyle fontStyle = new stFontStyle("Segoe UI", 12, FontStyle.Bold);

            stLabelStyle lblStyle = new stLabelStyle("Enter the biological material data :", new Point(30, 30), new Size(400, 40), Color.Transparent, Color.FromArgb(30, 41, 59), fontStyle, AnchorStyles.Top | AnchorStyles.Left);
            lblBiomaterialDataPrompt = clsControlFactory.CreateLabel(lblStyle);
            lblBiomaterialDataPrompt.TextAlign = ContentAlignment.MiddleLeft;
            tabCompatibilityCheck.Controls.Add(lblBiomaterialDataPrompt);
            
            stFlatAppearanceStyle btnFlat = new stFlatAppearanceStyle(1, Color.FromArgb(203, 213, 225), Color.FromArgb(2, 132, 199), Color.FromArgb(3, 105, 161));
            stButtonStyle btnStyle = new stButtonStyle("BioCompatibility Check", new Point(30, 90), new Size(260, 50), Color.FromArgb(3, 105, 161), Color.White, fontStyle, btnFlat, AnchorStyles.Top | AnchorStyles.Left);
            btnGeminiAiCheck = clsControlFactory.CreateButton(btnStyle);
            btnGeminiAiCheck.Click += new EventHandler(BtnCheck_Click);
            tabCompatibilityCheck.Controls.Add(btnGeminiAiCheck);
            
            stButtonStyle btnStyle2 = new stButtonStyle("Enter Material Data", new Point(300, 90), new Size(260, 50), Color.FromArgb(14, 165, 233), Color.White, fontStyle, btnFlat, AnchorStyles.Top | AnchorStyles.Left);
            btnEnterMaterialData = clsControlFactory.CreateButton(btnStyle2);
            btnEnterMaterialData.Click += new EventHandler(btnEnterIno_Click);
            tabCompatibilityCheck.Controls.Add(btnEnterMaterialData);

            stTextBoxStyle txtOutStyle = new stTextBoxStyle("Result...", new Point(30, 160), new Size(760, 380), Color.FromArgb(255, 255, 255), Color.FromArgb(30, 41, 59), fonttxt, AnchorStyles.Top | AnchorStyles.Left);
            txtAiResultReport = clsControlFactory.CreateTextBox(txtOutStyle);
            txtAiResultReport.Multiline = true;
            txtAiResultReport.ReadOnly = true;
            txtAiResultReport.ScrollBars = ScrollBars.Both; 
            txtAiResultReport.WordWrap = false; 
            tabCompatibilityCheck.Controls.Add(txtAiResultReport);
            
            stPanelStyle topPanelStyle = new stPanelStyle(
                new Point(0, 0), 
                new Size(830, 60), 
                Color.FromArgb(241, 245, 249), 
                BorderStyle.None, 
                AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, 
                DockStyle.Top
            );

            pnlSearchHeader = clsControlFactory.CreatePanel(topPanelStyle);
            tabResearchSearch.Controls.Add(pnlSearchHeader);
            
            stTextBoxStyle txtStyle = new stTextBoxStyle("", new Point(20, 15), new Size(500, 30), Color.White, Color.FromArgb(30, 41, 59), fontStyle, AnchorStyles.Top | AnchorStyles.Left);
            txtSearchQuery = clsControlFactory.CreateTextBox(txtStyle);
            pnlSearchHeader.Controls.Add(txtSearchQuery);

            stFlatAppearanceStyle btnFlat2 = new stFlatAppearanceStyle(1, Color.FromArgb(203, 213, 225), Color.FromArgb(14, 165, 233), Color.FromArgb(2, 132, 199));
            stButtonStyle btnStyle3 = new stButtonStyle("Search", new Point(535, 12), new Size(120, 35), Color.FromArgb(14, 165, 233), Color.White, fontStyle, btnFlat2, AnchorStyles.Top | AnchorStyles.Left);
            btnExecuteSearch = clsControlFactory.CreateButton(btnStyle3);
            btnExecuteSearch.Click += new EventHandler(BtnSearch_Click);
            pnlSearchHeader.Controls.Add(btnExecuteSearch);
            
            webBrowserNih = new WebBrowser { Dock = DockStyle.Fill };
            tabResearchSearch.Controls.Add(webBrowserNih);
            tabResearchSearch.Controls.SetChildIndex(webBrowserNih, 0);
            InitializeBrowser();
            
            stFontStyle Font3 = new stFontStyle("Segoe UI", 12, FontStyle.Bold);
            
            stGroupBoxStyle GRPstyle1 = new stGroupBoxStyle("BioMaterial Details", new Point(20, 20), new Size(360, 240), fontStyle, AnchorStyles.Top | AnchorStyles.Left, Color.FromArgb(248, 250, 252), Color.FromArgb(30, 41, 59));
            grpMaterialDetails = clsControlFactory.CreateGroupBox(GRPstyle1);
            tabSimulationLab.Controls.Add(grpMaterialDetails);

            stComboBoxStyle comboStyle1 = new stComboBoxStyle(new Point(20, 40), new Size(320, 35), Font3, AnchorStyles.Top | AnchorStyles.Left, Color.White, Color.FromArgb(30, 41, 59), ComboBoxStyle.DropDownList);
            cmbMaterialModel = clsControlFactory.CreateComboBox(comboStyle1);
            cmbMaterialModel.Items.AddRange(new string[] { "Titanium Alloy (Ti-6Al-4V)", "Hydroxyapatite", "Bioglass 45S5", "Polymethyl Methacrylate (PMMA)", "Zirconia", "Co-Cr Alloy", "Medical Grade PEEK" });
            if (cmbMaterialModel.Items.Count > 0) cmbMaterialModel.SelectedIndex = 0;
            grpMaterialDetails.Controls.Add(cmbMaterialModel);

            stComboBoxStyle comboStyle2 = new stComboBoxStyle(new Point(20, 100), new Size(320, 35), Font3, AnchorStyles.Top | AnchorStyles.Left, Color.White, Color.FromArgb(30, 41, 59), ComboBoxStyle.DropDownList);
            cmbTestProtocol = clsControlFactory.CreateComboBox(comboStyle2);
            cmbTestProtocol.Items.AddRange(new string[] { "Compression Test", "Tensile Test", "Bending Test", "Fatigue Resistance", "Wear & Abrasion Test", "Degradation Rate Test", "Impact Toughness" });
            if (cmbTestProtocol.Items.Count > 0) cmbTestProtocol.SelectedIndex = 0;
            grpMaterialDetails.Controls.Add(cmbTestProtocol);

            stGroupBoxStyle GRPstyle2 = new stGroupBoxStyle("Test Parameters", new Point(400, 20), new Size(400, 240), fontStyle, AnchorStyles.Top | AnchorStyles.Left, Color.FromArgb(248, 250, 252), Color.FromArgb(30, 41, 59));
            grpTestParameters = clsControlFactory.CreateGroupBox(GRPstyle2);
            tabSimulationLab.Controls.Add(grpTestParameters);

            stLabelStyle stylelabel1 = new stLabelStyle("Sample Diameter (mm) :", new Point(20, 40), new Size(200, 30), Color.Transparent, Color.FromArgb(30, 41, 59), Font3, AnchorStyles.Top | AnchorStyles.Left);
            lblSampleDiameter = clsControlFactory.CreateLabel(stylelabel1);
            lblSampleDiameter.TextAlign = ContentAlignment.MiddleLeft;
            grpTestParameters.Controls.Add(lblSampleDiameter);

            stNumericUpDownStyle Numstyle1 = new stNumericUpDownStyle(new Point(230, 40), new Size(150, 30), Color.White, Color.FromArgb(30, 41, 59), Font3, 1, 100, 10, 1, AnchorStyles.Top | AnchorStyles.Left);
            numSampleDiameter = clsControlFactory.CreateNumericUpDown(Numstyle1);
            grpTestParameters.Controls.Add(numSampleDiameter);

            stLabelStyle stylelabel3 = new stLabelStyle("Load Speed (mm/s) :", new Point(20, 90), new Size(200, 30), Color.Transparent, Color.FromArgb(30, 41, 59), Font3, AnchorStyles.Top | AnchorStyles.Left);
            lblLoadSpeed = clsControlFactory.CreateLabel(stylelabel3);
            lblLoadSpeed.TextAlign = ContentAlignment.MiddleLeft;
            grpTestParameters.Controls.Add(lblLoadSpeed);

            stNumericUpDownStyle Numstyle2 = new stNumericUpDownStyle(new Point(230, 90), new Size(150, 30), Color.White, Color.FromArgb(30, 41, 59), Font3, 1, 500, 50, 5, AnchorStyles.Top | AnchorStyles.Left);
            numLoadSpeed = clsControlFactory.CreateNumericUpDown(Numstyle2);
            grpTestParameters.Controls.Add(numLoadSpeed);

            stLabelStyle stylelabelLoadType = new stLabelStyle("Load Type :", new Point(20, 140), new Size(200, 30), Color.Transparent, Color.FromArgb(30, 41, 59), Font3, AnchorStyles.Top | AnchorStyles.Left);
            lblLoadType = clsControlFactory.CreateLabel(stylelabelLoadType);
            lblLoadType.TextAlign = ContentAlignment.MiddleLeft;
            grpTestParameters.Controls.Add(lblLoadType);

            stRadioButtonStyle RBstyle1 = new stRadioButtonStyle("Quasi-static", new Point(20, 180), new Size(110, 30), false, Font3, AnchorStyles.Top | AnchorStyles.Left);
            rbQuasiStatic = clsControlFactory.CreateRadioButton(RBstyle1);
            grpTestParameters.Controls.Add(rbQuasiStatic);

            stRadioButtonStyle RBstyle2 = new stRadioButtonStyle("Fatigue", new Point(145, 180), new Size(90, 30), false, Font3, AnchorStyles.Top | AnchorStyles.Left);
            rbFatigue = clsControlFactory.CreateRadioButton(RBstyle2);
            grpTestParameters.Controls.Add(rbFatigue);

            stRadioButtonStyle RBstyle3 = new stRadioButtonStyle("Impact", new Point(250, 180), new Size(130, 30), true, Font3, AnchorStyles.Top | AnchorStyles.Left);
            rbImpact = clsControlFactory.CreateRadioButton(RBstyle3);
            grpTestParameters.Controls.Add(rbImpact);

            rbQuasiStatic.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbFatigue.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbImpact.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

            stGroupBoxStyle GRPstyle3 = new stGroupBoxStyle("Output Focus Metrics", new Point(20, 280), new Size(780, 180), fontStyle, AnchorStyles.Top | AnchorStyles.Left, Color.FromArgb(248, 250, 252), Color.FromArgb(30, 41, 59));
            GroupBox grpOutputMetrics = clsControlFactory.CreateGroupBox(GRPstyle3);
            tabSimulationLab.Controls.Add(grpOutputMetrics);

            stCheckedListBoxStyle CLBstyle = new stCheckedListBoxStyle(
                new Point(20, 35), new Size(740, 125), Color.White,
                Color.FromArgb(30, 41, 59), Font3, AnchorStyles.Top | AnchorStyles.Left,
                BorderStyle.FixedSingle, true, true
            );
            chkListOutputFocus = clsControlFactory.CreateCheckedListBox(CLBstyle);
            chkListOutputFocus.Items.AddRange(new string[] { "Stress-Strain Curve & Yield Strength", "Energy Absorption & Toughness", "Deformation & Elastic Displacement", "Micro-structural Failure Analysis" });
            for (int i = 0; i < chkListOutputFocus.Items.Count; i++) chkListOutputFocus.SetItemChecked(i, true);
            grpOutputMetrics.Controls.Add(chkListOutputFocus);

            stFlatAppearanceStyle btStyle = new stFlatAppearanceStyle(1, Color.FromArgb(203, 213, 225), Color.FromArgb(14, 165, 233), Color.FromArgb(2, 132, 199));

            stButtonStyle BtStyle1 = new stButtonStyle("Material Data", new Point(20, 480), new Size(180, 45), Color.FromArgb(14, 165, 233), Color.White, fontList, btStyle, AnchorStyles.Top | AnchorStyles.Left);
            btnMaterialDataInfo = clsControlFactory.CreateButton(BtStyle1);
            btnMaterialDataInfo.Click += new EventHandler(Button1_Clicked);
            tabSimulationLab.Controls.Add(btnMaterialDataInfo);

            stButtonStyle BtStyle2 = new stButtonStyle("Run Simulation", new Point(220, 480), new Size(200, 45), Color.FromArgb(16, 185, 129), Color.White, fontList, btStyle, AnchorStyles.Top | AnchorStyles.Left); // أخضر زمردي مريح للعين لبدء العمليات
            btnRunSimulation = clsControlFactory.CreateButton(BtStyle2);
            btnRunSimulation.Click += new EventHandler(Button2_Clicked);
            tabSimulationLab.Controls.Add(btnRunSimulation);
            
            LoadDatabaseFromPhone();
            this.WindowState = FormWindowState.Maximized;
        }
        private bool MaterialIsExiset(string materialName)
        {
            foreach (ListViewItem item in lstMaterials.Items)
            {
                if (item.Text.Trim().Equals(materialName.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false; 
        }
        private void btnSaveMaterial_Click(object ? sender,EventArgs e)
        {
            SaveDatabaseToJson();
        }
        private string GetServerUrl()
        {
            try
            {
                string folderPath = @"D:\BioApp-Ready-For-Mobile";
                string settingsPath = System.IO.Path.Combine(folderPath, "settings.txt");
                if (System.IO.File.Exists(settingsPath))
                {
                    string savedUrl = System.IO.File.ReadAllText(settingsPath).Trim();
                    if (!string.IsNullOrEmpty(savedUrl)) return savedUrl;
                }
            }
            catch (Exception)
            {
        
            }
            return "https://pinggy.link"; 
        }



        private async void LoadDatabaseFromPhone()
        {
            using (HttpClient client = new HttpClient())
            {
                string baseUrl = GetServerUrl(); 
                string fullUrl = $"{baseUrl}/biomaterials.json";
                try
                {
                    string jsonResponse = await client.GetStringAsync(fullUrl);
                    var materialsList = JsonSerializer.Deserialize<List<clsItemInfo>>(jsonResponse);

                    if (materialsList != null)
                    {
                        lstMaterials.Items.Clear();
                        itemCounter = 0;

                        foreach (var item in materialsList)
                        {
                            ListViewItem newItem = new ListViewItem(item.MaterialName, itemCounter);
                            newItem.Tag = item;
                            lstMaterials.Items.Add(newItem);
                            itemCounter++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Fetch Failed : " + ex.Message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            RadioButton? rb = (RadioButton)(sender);
            if (rb != null && rb.Checked)
            {
                selectedLoadType = rb.Text;
            }
        }

        private void Button1_Clicked(object? sender, EventArgs e)
        {
            if (lstMaterials.SelectedItems.Count > 0)
            {
                clsItemInfo info = (clsItemInfo)lstMaterials.SelectedItems[0].Tag;
                string materialName = lstMaterials.SelectedItems[0].Text;

                MessageBox.Show($"Material Data Loaded from Explorer:\n\nMaterial: {materialName}\nComposition: {info.Composition}\nCompressive Strength: {info.CompressiveStrength}\nElastic Modulus: {info.ElasticModulus}", 
                        "Data Integration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a material from the 'Biomaterials Explorer' tab first to load its specific parameters!", 
                        "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void Button2_Clicked(object? sender, EventArgs e)
        {
            string materialModel = cmbMaterialModel.SelectedItem?.ToString() ?? "General BioMaterial";
            string testProtocol = cmbTestProtocol.SelectedItem?.ToString() ?? "Mechanical Test";
            double diameter = (double)numSampleDiameter.Value;
            double speed = (double)numLoadSpeed.Value;
            string focusMetrics = "";
            foreach (var item in chkListOutputFocus.CheckedItems)
            {
                focusMetrics += item.ToString() + ", ";
            }
            if (focusMetrics.EndsWith(", ")) focusMetrics = focusMetrics.Substring(0, focusMetrics.Length - 2);
            if (string.IsNullOrEmpty(focusMetrics)) focusMetrics = "General Mechanical Behavior";
            
            string prompt = $"Act as a Biomaterials Mechanical & Physical Testing Simulation Engine. Analyze this testing setup:\n" +
                   $"- Selected Material: {materialModel}\n" +
                   $"- Test Protocol: {testProtocol}\n" +
                   $"- Sample Diameter: {diameter} mm\n" +
                   $"- Load Speed: {speed} mm/s\n" +
                   $"- Loading Mode: {selectedLoadType}\n" +
                   $"- Focus Output Metrics: {focusMetrics}\n\n" +
                   $"Provide a detailed engineering diagnostic report in English including:\n" +
                   $"1. Calculated Stress/Strain Estimates and Safety Assessment.\n" +
                   $"2. An ASCII text-based Stress-Strain Chart/Plot representation (e.g. using '|', '*', '-').\n" +
                   $"3. Physical Failure Mode Diagnostic & Biocompatibility Assessment under load.";

            btnRunSimulation.Enabled = false;
            btnRunSimulation.Text = "Simulating...";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMinutes(3);
                    var requestBody = new
                    {
                        contents = new[]
                        {
                            new { parts = new[] { new { text = prompt } } }
                        }
                    };

                    string jsonPayload = JsonSerializer.Serialize(requestBody);
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls13;
                    string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent";
            
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
                    request.Headers.Add("x-goog-api-key", clsGlobal.GeminiApiKey);
                    request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        using (JsonDocument doc = JsonDocument.Parse(jsonResponse))
                        {
                            var candidates = doc.RootElement.GetProperty("candidates");
                            if (candidates.GetArrayLength() > 0)
                            {
                                var parts = candidates[0].GetProperty("content").GetProperty("parts");
                                if (parts.GetArrayLength() > 0)
                                {
                                    string aiReport = parts[0].GetProperty("text").GetString() ?? "No output generated.";
                            
                                    using (SimulationResultForm resultForm = new SimulationResultForm(aiReport))
                                    {
                                        resultForm.ShowDialog();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        string errorDetails = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Simulation Request Failed!\nStatus: {response.StatusCode}\nDetails: {errorDetails}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during simulation analysis: " + ex.Message, "Simulation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRunSimulation.Enabled = true;
                btnRunSimulation.Text = "Run Simulation";
            }
        }

        private void InitializeBrowser()
        {
            try
            {
                string headers = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36\r\n";
                webBrowserNih.Navigate("https://www.ncbi.nlm.nih.gov/pmc/", "", null, headers);
            }
            catch (Exception ex)
            {
                txtAiResultReport.Text = "Browser initialization failed: " + ex.Message;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchQuery.Text))
            {
                string url = "https://www.ncbi.nlm.nih.gov/pmc/?term=" + Uri.EscapeDataString(txtSearchQuery.Text);
                string headers = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36\r\n";
                webBrowserNih.Navigate(url, "", null, headers);
            }
        }

        private async void BtnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clsGlobal.Info.Composition))
            {
                MessageBox.Show("Please enter the material data using the form first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtAiResultReport.Text = "Connecting to Gemini and analyzing data... Please wait.";
            btnGeminiAiCheck.Enabled = false;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMinutes(3); 
                    string materialText = clsGlobal.Info.GetInfoAsText();
                    string prompt = $"Analyze this material and its data scientifically, determine whether it is biocompatible for medical use or not, and state the reasons very briefly in English. Material Data: {materialText}";
            
                    var requestBody = new
                    {
                        contents = new[]
                        {
                            new { parts = new[] { new { text = prompt } } }
                        }
                    };
                    string jsonPayload = JsonSerializer.Serialize(requestBody);
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls13;
                    string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent";
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
                    request.Headers.Add("x-goog-api-key", clsGlobal.GeminiApiKey);
                    request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        
                        using (JsonDocument doc = JsonDocument.Parse(jsonResponse))
                        {
                           var candidates = doc.RootElement.GetProperty("candidates");
                           if (candidates.GetArrayLength() > 0)
                           {
                              var parts = candidates[0].GetProperty("content").GetProperty("parts");
                              if (parts.GetArrayLength() > 0)
                              {
                                 string aiResponse = parts[0].GetProperty("text").GetString();
                                 txtAiResultReport.Text = aiResponse;
                              }
                           }
                        }
                    }
                    else
                    {
                         string errorDetails = await response.Content.ReadAsStringAsync();
                         txtAiResultReport.Text = $"Status: {response.StatusCode}\r\nDetails: {errorDetails}";
                    }
                }
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate { 
                    txtAiResultReport.Text = "An error occurred during data verification: " + ex.Message; 
                });
            }
            finally
            {
                btnGeminiAiCheck.Enabled = true;
            }
        }
        private void SaveDatabaseToJson()
        {
            try
            {
                List<clsItemInfo> materialsList = new List<clsItemInfo>();
        
                foreach (ListViewItem item in lstMaterials.Items)
                {
                    if (item.Tag is clsItemInfo info)
                    {
                        info.MaterialName = item.Text;
                        materialsList.Add(info);
                    }
                }

                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(materialsList, options);
                string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "biomaterials.json");
                System.IO.File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save the database : " + ex.Message, "Error in saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEnterIno_Click(object? sender, EventArgs e)
        {
             using (form1 f1 = new form1(false))
             {
                    f1.ShowDialog();
                    if(!string.IsNullOrEmpty(clsGlobal.Info.Composition) && clsGlobal.HeClickOk)
                    {
                       txtAiResultReport.Text = "Material data entered successfully!\r\n\r\n" + clsGlobal.Info.GetInfoAsText();
                    }
             }
        }
        
        private string OpenFile()
        {
            stOpenFileDialogStyle OpenStyle = new stOpenFileDialogStyle("Images (*.png;*.jpg)|*.png;*.jpg|All Files (*.*)|*.*", "Add Image", @"D:\");
            using(OpenFileDialog OFD = clsControlFactory.CreateOpenFileDialog(OpenStyle))
            {
                if(OFD.ShowDialog() == DialogResult.OK)
                {
                    return OFD.FileName;
                }
            }
            return "";
        }

        private bool AddListViewItem(string Path)
        {
            if (Path != "" && clsGlobal.SelectedMaterials != null && clsGlobal.SelectedMaterials[0] != "")
            {
                if (MaterialIsExiset(clsGlobal.SelectedMaterials[0]))
                {
                    MessageBox.Show($"The Material '{clsGlobal.SelectedMaterials[0]}' The material is already in the database and you cannot repeat it!", 
                            "Error in adding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (System.IO.File.Exists(Path)) 
                {
                    using (var stream = System.IO.File.OpenRead(Path))
                    {
                        using (var tempImg = Image.FromStream(stream))
                        {
                            imageListMaterials.Images.Add(clsGlobal.SelectedMaterials[0], new Bitmap(tempImg));
                        }
                    }
                }
                ListViewItem newItem = new ListViewItem(clsGlobal.SelectedMaterials[0], itemCounter);
                clsItemInfo Info = new clsItemInfo(clsGlobal.SelectedMaterials[0], Path, clsGlobal.Info.Composition, clsGlobal.Info.Porosity,
                clsGlobal.Info.MeanPoreSize, clsGlobal.Info.CompressiveStrength,
                clsGlobal.Info.ElasticModulus, clsGlobal.Info.BioCompatibility, clsGlobal.Info.Applications);
                newItem.Tag = Info;
                lstMaterials.Items.Add(newItem);
                itemCounter++;
                SaveDatabaseToJson();
                return true;
            }
            return false;
        }

        private bool DeleteListViewItem()
        {
            if (lstMaterials.SelectedItems.Count > 0)
            {
                lstMaterials.Items.Remove(lstMaterials.SelectedItems[0]);
                btnRemoveMaterial.Enabled = false;
                btnCompareMaterials.Enabled = false;
                txtMaterialDetails.Visible = false;
                SaveDatabaseToJson();
                return true;
            }
            return false;
        }

        private void lstMaterials_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if(lstMaterials.SelectedItems.Count == 2)
            {
                btnCompareMaterials.Enabled = true;
                clsGlobal.SelectedItems = new clsItemInfo[2];
                clsGlobal.SelectedItems[0] = (clsItemInfo)(lstMaterials.SelectedItems[0].Tag);
                clsGlobal.SelectedItems[1] = (clsItemInfo)(lstMaterials.SelectedItems[1].Tag);
            }
            else
            {
                btnCompareMaterials.Enabled = false;
            }
            
            btnRemoveMaterial.Enabled = (lstMaterials.SelectedItems.Count == 1);
            
            if(lstMaterials.SelectedItems.Count > 0)
            {
                clsItemInfo InfoItem = (clsItemInfo)(lstMaterials.SelectedItems[0].Tag);
                string Path = InfoItem.ImagePath;
                if(System.IO.File.Exists(Path))
                {
                    using (var stream = System.IO.File.OpenRead(Path))
                    {
                        using (var tempImg = Image.FromStream(stream))
                        {
                            picMaterialImage.Image = new Bitmap(tempImg);
                        }
                    }
                    lblSelectedMaterialTitle.Text = lstMaterials.SelectedItems[0].Text;
                    InfoItem.SetInfoAsGroup(txtMaterialDetails);
                    txtMaterialDetails.Visible = true;
                }
                else
                {
                    picMaterialImage.Image = null;
                    lblSelectedMaterialTitle.Text = "";
                    txtMaterialDetails.Visible = false;
                }
            }
            else
            {
                picMaterialImage.Image = null;
                lblSelectedMaterialTitle.Text = "";
                txtMaterialDetails.Text = "";
                txtMaterialDetails.Visible = false;
            }
        }

        private void btnAddMaterial_Click(object? sender, EventArgs e)
        {
            string Path = OpenFile();
            if(Path != "")
            {
                clsGlobal.SelectedImagesPaths[0] = Path;
                using (form1 f1 = new form1(true))
                {
                    if (f1.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("You canceled add item operation!", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if(AddListViewItem(Path))
                {
                    MessageBox.Show("Item Added Successfully!", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred!", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You canceled add item operation!", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnRemoveMaterial_Click(object? sender, EventArgs e)
        {
            if(lstMaterials.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this item ?", "Remove Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if(result == DialogResult.OK)
                {
                    if(DeleteListViewItem())
                    {
                       MessageBox.Show("Item Removed Successfully!", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred!", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if(System.IO.File.Exists(@"D:\Biomaterials\Icon.png"))
                    {
                        using (var stream = System.IO.File.OpenRead(@"D:\Biomaterials\Icon.png"))
                        {
                            using (var tempImg = Image.FromStream(stream))
                            {
                                picMaterialImage.Image = new Bitmap(tempImg);
                            }
                        }
                        lblSelectedMaterialTitle.Text = "";
                    }
                    else
                    {
                        picMaterialImage.Image = null;
                        lblSelectedMaterialTitle.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("No Item Selected!", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCompareMaterials_Click(object? sender, EventArgs e)
        {
           clsGlobal.SelectedMaterials = new string[2];
           clsGlobal.SelectedImagesPaths = new string[2];  
    
           if(lstMaterials.SelectedItems.Count >= 1 && lstMaterials.SelectedItems[0].Tag != null)
           {
               clsItemInfo InfoItem1 = (clsItemInfo)(lstMaterials.SelectedItems[0].Tag);
               clsGlobal.SelectedImagesPaths[0] = InfoItem1.ImagePath;
               clsGlobal.SelectedMaterials[0] = lstMaterials.SelectedItems[0].Text;
           }
    
           if(lstMaterials.SelectedItems.Count >= 2 && lstMaterials.SelectedItems[1].Tag != null)
           {
               clsItemInfo InfoItem2 = (clsItemInfo)(lstMaterials.SelectedItems[1].Tag);
               clsGlobal.SelectedImagesPaths[1] = InfoItem2.ImagePath;
               clsGlobal.SelectedMaterials[1] = lstMaterials.SelectedItems[1].Text;
           }
            
           using (form2 f = new form2())
           {
               f.ShowDialog();
           }
        }
    }
    
    public class form1 : Form
    {
        private TextBox txtItemName;
        private Button btnConfirm;
        private Button btnCancelOperation;
        private Label lblItemNamePrompt;
        private Label lblCompositionPrompt;
        private Label lblPorosityPrompt;
        private Label lblMeanPoreSizePrompt;
        private Label lblApplicationsPrompt;
        private Label lblCompressiveMin;
        private Label lblCompressiveMax;
        private Label lblElasticMin;
        private Label lblElasticMax;
        private NumericUpDown numPorosityValue;
        private NumericUpDown numMeanPoreSizeValue;
        private NumericUpDown numCompressiveMin;
        private NumericUpDown numCompressiveMax;
        private NumericUpDown numElasticMin;
        private NumericUpDown numElasticMax;
        private GroupBox grpBiocompatibilityOptions;
        private GroupBox grpCompressiveStrengthGroup;
        private GroupBox grpElasticModulusGroup;
        private RadioButton rbBioActive;
        private RadioButton rbBioInert;
        private RadioButton rbResorbable;
        private ComboBox cmbApplicationsList;
        private CheckedListBox chkListComposition;
        
        private string Compatibility = "Resorbable";

        public form1(bool isSpecialMode)
        {
            this.Text = "Item Informations";
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(244, 246, 249);

            stFontStyle Font1 = new stFontStyle("Segoe UI", 11, FontStyle.Bold);
            stFontStyle grbfont = new stFontStyle("Segoe UI", 12, FontStyle.Bold);
            
            stLabelStyle stylelabel1 = new stLabelStyle("Item Name : ", new Point(50, 40), new Size(200, 35), Color.Transparent, Color.FromArgb(30, 41, 59), Font1, AnchorStyles.Top | AnchorStyles.Left);
            lblItemNamePrompt = clsControlFactory.CreateLabel(stylelabel1);
            this.Controls.Add(lblItemNamePrompt);

            stTextBoxStyle TxtStyleLeft = new stTextBoxStyle("", new Point(250, 40), new Size(320, 35), Color.White, Color.FromArgb(30, 41, 59), Font1, AnchorStyles.Top | AnchorStyles.Left);
            txtItemName = clsControlFactory.CreateTextBox(TxtStyleLeft);
            this.Controls.Add(txtItemName);
            
            stLabelStyle stylelabel3 = new stLabelStyle("Porosity (%) : ", new Point(50, 95), new Size(200, 35), Color.Transparent, Color.FromArgb(30, 41, 59), Font1, AnchorStyles.Top | AnchorStyles.Left);
            lblPorosityPrompt = clsControlFactory.CreateLabel(stylelabel3);
            this.Controls.Add(lblPorosityPrompt);

            stNumericUpDownStyle Numstyle1 = new stNumericUpDownStyle(new Point(250, 95), new Size(320, 35), Color.White, Color.FromArgb(30, 41, 59), Font1, 0, 100, 50, 1, AnchorStyles.Top | AnchorStyles.Left);
            numPorosityValue = clsControlFactory.CreateNumericUpDown(Numstyle1);
            this.Controls.Add(numPorosityValue);
            
            stLabelStyle stylelabel4 = new stLabelStyle("Mean Pore Size (μm) : ", new Point(50, 150), new Size(200, 35), Color.Transparent, Color.FromArgb(30, 41, 59), Font1, AnchorStyles.Top | AnchorStyles.Left);
            lblMeanPoreSizePrompt = clsControlFactory.CreateLabel(stylelabel4);
            this.Controls.Add(lblMeanPoreSizePrompt);

            stNumericUpDownStyle Numstyle2 = new stNumericUpDownStyle(new Point(250, 150), new Size(320, 35), Color.White, Color.FromArgb(30, 41, 59), Font1, 1, 1000, 500, 1, AnchorStyles.Top | AnchorStyles.Left);
            numMeanPoreSizeValue = clsControlFactory.CreateNumericUpDown(Numstyle2);
            this.Controls.Add(numMeanPoreSizeValue);
            
            stGroupBoxStyle GRPstyle2 = new stGroupBoxStyle("Compressive Strength (MPa)", new Point(50, 205), new Size(520, 90), grbfont, AnchorStyles.Top | AnchorStyles.Left, Color.FromArgb(248, 250, 252), Color.FromArgb(30, 41, 59));
            grpCompressiveStrengthGroup = clsControlFactory.CreateGroupBox(GRPstyle2);
            this.Controls.Add(grpCompressiveStrengthGroup);

            stFontStyle Font2 = new stFontStyle("Segoe UI", 9, FontStyle.Bold);
            stLabelStyle stylelabel2 = new stLabelStyle("Min :", new Point(20, 35), new Size(40, 25), Color.Transparent, Color.FromArgb(30, 41, 59), Font2, AnchorStyles.Top | AnchorStyles.Left);
            lblCompressiveMin = clsControlFactory.CreateLabel(stylelabel2);
            grpCompressiveStrengthGroup.Controls.Add(lblCompressiveMin);

            stNumericUpDownStyle Numstyle3 = new stNumericUpDownStyle(new Point(65, 32), new Size(160, 30), Color.White, Color.FromArgb(30, 41, 59), Font1, 0, 3000, 600, 1, AnchorStyles.Top | AnchorStyles.Left);
            numCompressiveMin = clsControlFactory.CreateNumericUpDown(Numstyle3);
            grpCompressiveStrengthGroup.Controls.Add(numCompressiveMin);

            stLabelStyle stylelabel7 = new stLabelStyle("Max :", new Point(255, 35), new Size(40, 25), Color.Transparent, Color.FromArgb(30, 41, 59), Font2, AnchorStyles.Top | AnchorStyles.Left);
            lblCompressiveMax = clsControlFactory.CreateLabel(stylelabel7);
            grpCompressiveStrengthGroup.Controls.Add(lblCompressiveMax);

            stNumericUpDownStyle Numstyle4 = new stNumericUpDownStyle(new Point(300, 32), new Size(160, 30), Color.White, Color.FromArgb(30, 41, 59), Font1, 1, 3000, 2000, 1, AnchorStyles.Top | AnchorStyles.Left);
            numCompressiveMax = clsControlFactory.CreateNumericUpDown(Numstyle4);
            grpCompressiveStrengthGroup.Controls.Add(numCompressiveMax);
            
            stLabelStyle stylelabel2_comp = new stLabelStyle("Composition : ", new Point(50, 310), new Size(200, 35), Color.Transparent, Color.FromArgb(30, 41, 59), Font1, AnchorStyles.Top | AnchorStyles.Left);
            lblCompositionPrompt = clsControlFactory.CreateLabel(stylelabel2_comp);
            this.Controls.Add(lblCompositionPrompt);

            stCheckedListBoxStyle CLBstyle = new stCheckedListBoxStyle(
                new Point(250, 310), new Size(320, 220), Color.White,
                Color.FromArgb(30, 41, 59), Font1, AnchorStyles.Top | AnchorStyles.Left,
                BorderStyle.FixedSingle, true, true
            );
            chkListComposition = clsControlFactory.CreateCheckedListBox(CLBstyle);
            chkListComposition.Items.AddRange(new string[] { "Titanium (Ti)", "Aluminum (Al)", "Vanadium (V)", "Hydroxyapatite (HA)", "Bioglass", "Polymethyl Methacrylate (PMMA)", "Collagen", "Zirconia (ZrO2)" });
            this.Controls.Add(chkListComposition);
            
            stGroupBoxStyle GRPstyle3 = new stGroupBoxStyle("Elastic Modulus (GPa)", new Point(620, 40), new Size(580, 90), grbfont, AnchorStyles.Top | AnchorStyles.Right, Color.FromArgb(248, 250, 252), Color.FromArgb(30, 41, 59));
            grpElasticModulusGroup = clsControlFactory.CreateGroupBox(GRPstyle3);
            this.Controls.Add(grpElasticModulusGroup);

            lblElasticMin = clsControlFactory.CreateLabel(stylelabel2);
            lblElasticMin.Location = new Point(20, 35);
            grpElasticModulusGroup.Controls.Add(lblElasticMin);

            stNumericUpDownStyle Numstyle5 = new stNumericUpDownStyle(new Point(65, 32), new Size(190, 30), Color.White, Color.FromArgb(30, 41, 59), Font1, 0, 400, 100, 1, AnchorStyles.Top | AnchorStyles.Left);
            numElasticMin = clsControlFactory.CreateNumericUpDown(Numstyle5);
            grpElasticModulusGroup.Controls.Add(numElasticMin);

            lblElasticMax = clsControlFactory.CreateLabel(stylelabel7);
            lblElasticMax.Location = new Point(285, 35);
            grpElasticModulusGroup.Controls.Add(lblElasticMax);

            stNumericUpDownStyle Numstyle6 = new stNumericUpDownStyle(new Point(330, 32), new Size(190, 30), Color.White, Color.FromArgb(30, 41, 59), Font1, 1, 400, 300, 1, AnchorStyles.Top | AnchorStyles.Left);
            numElasticMax = clsControlFactory.CreateNumericUpDown(Numstyle6);
            grpElasticModulusGroup.Controls.Add(numElasticMax);

            stLabelStyle stylelabelRight = new stLabelStyle("Applications : ", new Point(620, 150), new Size(150, 35), Color.Transparent, Color.FromArgb(30, 41, 59), Font1, AnchorStyles.Top | AnchorStyles.Right);
            lblApplicationsPrompt = clsControlFactory.CreateLabel(stylelabelRight);
            this.Controls.Add(lblApplicationsPrompt);

            stComboBoxStyle comboStyle = new stComboBoxStyle(new Point(780, 150), new Size(420, 35), Font1, AnchorStyles.Top | AnchorStyles.Right, Color.White, Color.FromArgb(30, 41, 59), ComboBoxStyle.DropDownList);
            cmbApplicationsList = clsControlFactory.CreateComboBox(comboStyle);
            string[] services = {
                "Orthopedic Bone Plates & Screws",
                "Hip Joint Replacement",
                "Knee Joint Replacement",
                "Spinal Fusion Cages",
                "Bone Graft Scaffolds",
                "Dental Implants",
                "Dental Crowns & Bridges",
                "Heart Valve Prostheses",
                "Vascular Stents",
                "Surgical Sutures",
                "Drug Delivery Systems",
                "Intraocular Lenses (IOLs)"
            };
            cmbApplicationsList.Items.AddRange(services);
            cmbApplicationsList.SelectedIndex = 0;
            this.Controls.Add(cmbApplicationsList);
            
            stGroupBoxStyle GRPstyle1 = new stGroupBoxStyle("BioCompatibility", new Point(620, 205), new Size(580, 120), grbfont, AnchorStyles.Top | AnchorStyles.Right, Color.FromArgb(248, 250, 252), Color.FromArgb(30, 41, 59));
            grpBiocompatibilityOptions = clsControlFactory.CreateGroupBox(GRPstyle1);
            this.Controls.Add(grpBiocompatibilityOptions);

            stRadioButtonStyle RBstyle1 = new stRadioButtonStyle("BioActive", new Point(30, 45), new Size(140, 35), false, Font1, AnchorStyles.Top | AnchorStyles.Left);
            rbBioActive = clsControlFactory.CreateRadioButton(RBstyle1);
            grpBiocompatibilityOptions.Controls.Add(rbBioActive);

            stRadioButtonStyle RBstyle2 = new stRadioButtonStyle("BioInert", new Point(210, 45), new Size(140, 35), false, Font1, AnchorStyles.Top | AnchorStyles.Left);
            rbBioInert = clsControlFactory.CreateRadioButton(RBstyle2);
            grpBiocompatibilityOptions.Controls.Add(rbBioInert);

            stRadioButtonStyle RBstyle3 = new stRadioButtonStyle("Resorbable", new Point(390, 45), new Size(140, 35), true, Font1, AnchorStyles.Top | AnchorStyles.Left);
            rbResorbable = clsControlFactory.CreateRadioButton(RBstyle3);
            grpBiocompatibilityOptions.Controls.Add(rbResorbable);

            rbBioActive.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbBioInert.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbResorbable.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

            stFlatAppearanceStyle StyleApper = new stFlatAppearanceStyle(1, Color.FromArgb(203, 213, 225), Color.FromArgb(14, 165, 233), Color.FromArgb(2, 132, 199));
            
            stButtonStyle BtStyleOk = new stButtonStyle("Confirm", new Point(630, 460), new Size(180, 50), Color.FromArgb(14, 165, 233), Color.White, Font1, StyleApper, AnchorStyles.Bottom);
            btnConfirm = clsControlFactory.CreateButton(BtStyleOk);
            this.Controls.Add(btnConfirm);
            btnConfirm.Click += new EventHandler(BtnOk_Clicked);

            stButtonStyle BtStyleCancel = new stButtonStyle("Cancel", new Point(890, 460), new Size(180, 50), Color.FromArgb(244, 63, 94), Color.White, Font1, StyleApper, AnchorStyles.Bottom);
            btnCancelOperation = clsControlFactory.CreateButton(BtStyleCancel);
            this.Controls.Add(btnCancelOperation);
            btnCancelOperation.Click += new EventHandler(btnCancel_Clicked);

            if (!isSpecialMode)
            {
                grpBiocompatibilityOptions.Visible = false;
                Compatibility = "Not Specified";
            }

            this.WindowState = FormWindowState.Maximized;
        }

        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            RadioButton? rb = (RadioButton)(sender);
            if (rb != null && rb.Checked)
            {
                Compatibility = rb.Text;
            }
        }

        private void BtnOk_Clicked(object? sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                MessageBox.Show("You did not enter the item name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemName.BackColor = Color.FromArgb(254, 226, 226);
                txtItemName.Focus();
                return;
            }
            else if (numCompressiveMin.Value > numCompressiveMax.Value)
            {
                MessageBox.Show("The maximum compressive strength must be greater than the minimum value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numElasticMin.Value > numElasticMax.Value)
            {
                MessageBox.Show("The maximum elastic modulus must be greater than the minimum value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtItemName.BackColor = Color.White;
                string compositionStr = "";
                foreach (var item in chkListComposition.CheckedItems)
                {
                    compositionStr += item.ToString() + ", ";
                }
                if (compositionStr.EndsWith(", "))
                {
                    compositionStr = compositionStr.Substring(0, compositionStr.Length - 2);
                }
                if (string.IsNullOrEmpty(compositionStr)) compositionStr = "None";

                string porosityStr = numPorosityValue.Value.ToString() + " %";
                string poreSizeStr = numMeanPoreSizeValue.Value.ToString() + " μm";
                string compStrengthStr = numCompressiveMin.Value.ToString() + " - " + numCompressiveMax.Value.ToString() + " MPa";
                string elasticModulusStr = numElasticMin.Value.ToString() + " - " + numElasticMax.Value.ToString() + " GPa";
                string applicationStr = cmbApplicationsList.SelectedItem?.ToString() ?? "General";

                clsGlobal.SelectedMaterials[0] = txtItemName.Text;
                clsGlobal.Info = new clsItemInfo(clsGlobal.SelectedMaterials[0],
                    clsGlobal.SelectedImagesPaths[0], 
                    compositionStr, 
                    porosityStr, 
                    poreSizeStr, 
                    compStrengthStr, 
                    elasticModulusStr, 
                    Compatibility, 
                    applicationStr
                );
                clsGlobal.HeClickOk = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Clicked(object? sender, EventArgs e)
        {
            string Message = "Are you sure you want to " + Environment.NewLine + "cancel this operation ?! " + Environment.NewLine + "No item will be added!";
            DialogResult result = MessageBox.Show(Message, "Cancel Operation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                clsGlobal.SelectedMaterials[0] = "";
                clsGlobal.HeClickOk = false;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }

    public class form2 : Form
    {
        private GroupBox grpMaterialOneContainer;
        private GroupBox grpMaterialTwoContainer;
        private TextBox txtMaterialOneDetails;
        private TextBox txtMaterialTwoDetails;
        private PictureBox picMaterialOneImage;
        private PictureBox picMaterialTwoImage;
        
        public form2()
        {
            this.Text = "Compare Materials";
            this.Size = new Size(900, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(244, 246, 249);
            
            stFontStyle font = new stFontStyle("Segoe UI", 11f, FontStyle.Bold);
            
            stGroupBoxStyle gboxStyle1 = new stGroupBoxStyle(clsGlobal.SelectedMaterials[0], new Point(20, 20), new Size(410, 610), font, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left, Color.FromArgb(248, 250, 252), Color.FromArgb(30, 41, 59));
            grpMaterialOneContainer = clsControlFactory.CreateGroupBox(gboxStyle1);
            this.Controls.Add(grpMaterialOneContainer);
            
            stGroupBoxStyle gboxStyle2 = new stGroupBoxStyle(clsGlobal.SelectedMaterials[1], new Point(450, 20), new Size(410, 610), font, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right, Color.FromArgb(248, 250, 252), Color.FromArgb(30, 41, 59));
            grpMaterialTwoContainer = clsControlFactory.CreateGroupBox(gboxStyle2);
            this.Controls.Add(grpMaterialTwoContainer);
            
            string Path1 = clsGlobal.SelectedImagesPaths[0];
            if(System.IO.File.Exists(Path1))
            {
                 stPictureBox PBstyle1 = new stPictureBox(new Point(30, 380), new Size(350, 200), PictureBoxSizeMode.Zoom, Path1, true, null, AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                 picMaterialOneImage = clsControlFactory.CreatePictureBox(PBstyle1);
                 grpMaterialOneContainer.Controls.Add(picMaterialOneImage);
            }
            string Path2 = clsGlobal.SelectedImagesPaths[1];
            if(System.IO.File.Exists(Path2))
            {
                 stPictureBox PBstyle2 = new stPictureBox(new Point(30, 380), new Size(350, 200), PictureBoxSizeMode.Zoom, Path2, true, null, AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                 picMaterialTwoImage = clsControlFactory.CreatePictureBox(PBstyle2);
                 grpMaterialTwoContainer.Controls.Add(picMaterialTwoImage);
            }
            stFontStyle fonttxt = new stFontStyle("Segoe UI", 11f, FontStyle.Regular);
            stTextBoxStyle TxtStyle = new stTextBoxStyle("", new Point(15, 30), new Size(380, 330), Color.White,
			Color.FromArgb(30, 41, 59), fonttxt, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            
            txtMaterialOneDetails = clsControlFactory.CreateTextBox(TxtStyle);
            txtMaterialOneDetails.ReadOnly = true;
            txtMaterialOneDetails.Multiline = true;
            txtMaterialOneDetails.ScrollBars = ScrollBars.Vertical;
            grpMaterialOneContainer.Controls.Add(txtMaterialOneDetails);
            
            txtMaterialTwoDetails = clsControlFactory.CreateTextBox(TxtStyle);
            txtMaterialTwoDetails.ReadOnly = true;
            txtMaterialTwoDetails.Multiline = true;
            txtMaterialTwoDetails.ScrollBars = ScrollBars.Vertical;
            grpMaterialTwoContainer.Controls.Add(txtMaterialTwoDetails);
            
            clsGlobal.SelectedItems[0].SetInfoAsGroup(txtMaterialOneDetails);
            clsGlobal.SelectedItems[1].SetInfoAsGroup(txtMaterialTwoDetails);
        }
    }

    public class SimulationResultForm : Form
    {
        private TextBox txtSimulationReport;
        private Button btnCloseReport;

        public SimulationResultForm(string reportContent)
        {
            this.Text = "Simulation Analysis & AI Diagnostic Report";
            this.Size = new Size(850, 650);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(244, 246, 249);

            stFontStyle fontTitle = new stFontStyle("Segoe UI", 11, FontStyle.Bold);
            stFontStyle fontReport = new stFontStyle("Consolas", 10, FontStyle.Regular);

            stTextBoxStyle boxStyle = new stTextBoxStyle(reportContent, new Point(20, 20), new Size(790, 520), Color.FromArgb(255, 255, 255), Color.FromArgb(30, 41, 59), fontReport, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            txtSimulationReport = clsControlFactory.CreateTextBox(boxStyle);
            txtSimulationReport.Multiline = true;
            txtSimulationReport.ReadOnly = true;
            txtSimulationReport.ScrollBars = ScrollBars.Both;
            txtSimulationReport.WordWrap = false;
            this.Controls.Add(txtSimulationReport);

            stFlatAppearanceStyle flat = new stFlatAppearanceStyle(1, Color.FromArgb(203, 213, 225), Color.FromArgb(244, 63, 94), Color.FromArgb(225, 29, 72));
            stButtonStyle btnStyle = new stButtonStyle("Close Report", new Point(630, 555), new Size(180, 40), Color.FromArgb(244, 63, 94), Color.White, fontTitle, flat, AnchorStyles.Bottom | AnchorStyles.Right);
            btnCloseReport = clsControlFactory.CreateButton(btnStyle);
            btnCloseReport.Click += (s, e) => this.Close();
            this.Controls.Add(btnCloseReport);
        }
    }

    public static class clsGlobal
    {
        public static string[] SelectedMaterials;
        public static string[] SelectedImagesPaths;
        public static clsItemInfo[] SelectedItems;
        public static bool HeClickOk = false;
        public static clsItemInfo Info = new clsItemInfo("", "", "", "", "", "", "", "", "");
        
        public static string GeminiApiKey
        {
            get
            {
                try
                {
                    string filePath = "config.json";
                    if (System.IO.File.Exists(filePath))
                    {
                        string jsonContent = System.IO.File.ReadAllText(filePath);
                        using (JsonDocument doc = JsonDocument.Parse(jsonContent))
                        {
                            if (doc.RootElement.TryGetProperty("GeminiApiKey", out JsonElement prop))
                            {
                                string key = prop.GetString();
                                if (!string.IsNullOrEmpty(key))
                                {
                                    return key;
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    
                }
                return "YOUR_API_KEY_HERE"; 
            }
        }
    }

    public class Program
	{
		[STAThread] 
        public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MyFirstForm());
        }
    }
}

namespace MauiApp_Test1;

public partial class TextPage : ContentPage
{
	Label lbl;
	Editor editor;
	Button btn_tagasi,btn_edasi,btn_algus;
	HorizontalStackLayout hsl;
	List<string> buttons = new List<string> { "Tagasi", "Avaleht", "Edasi" };

	public TextPage()
	{
		lbl = new Label
		{
			Text="Pealkiri",
			TextColor=Color.FromRgb(200,0,0),
			FontFamily="Socafe 400",
			FontSize=12,
		};
		editor = new Editor
		{
			Placeholder = "Vihje:Sisesta siia tekst",
			PlaceholderColor = Color.FromRgb(50, 100, 100),
			TextColor = Color.FromRgb(200, 0, 0),
			BackgroundColor = Color.FromRgb(10, 50, 200),
		};
		hsl = new HorizontalStackLayout { };
		for (int i = 0; i < 3; i++)
		{
			Button b = new Button
			{
				Text = buttons[i],
			};
			hsl.Add(b);
		}

		VerticalStackLayout vst = new VerticalStackLayout
		{
			Children = { lbl, editor, hsl }
		};
		Content = vst;
	}
}